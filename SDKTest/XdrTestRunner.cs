using AutoFixture.DataAnnotations;
using AutoFixture;
using Stellar.XDR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AutoFixture.Kernel;

namespace SDKTest
{
    public class XdrTestRunner
    {
        private readonly IFixture _fixture;

        public XdrTestRunner()
        {
            _fixture = new Fixture();
            ConfigureFixture();
        }

        private void ConfigureFixture()
        {

            _fixture.Behaviors
                .OfType<ThrowingRecursionBehavior>()
                .ToList()
                .ForEach(b => _fixture.Behaviors.Remove(b));
            _fixture.Behaviors.Add(new OmitOnRecursionBehavior());

            _fixture.Customize(new XdrWrapperCustomization());
            _fixture.Customize(new DataAnnotationsCustomization());


            var abstractMappings = DiscoverAbstractTypeImplementations(typeof(Stellar.XDR.PublicKey).Assembly);
            foreach (var (abstractType, concreteType) in abstractMappings)
            {
                _fixture.Customizations.Add(new TypeRelay(abstractType, concreteType));
            }
        }


        private Dictionary<Type, Type> DiscoverAbstractTypeImplementations(Assembly assembly)
        {
            var mappings = new Dictionary<Type, Type>();
            var processedTypes = new HashSet<Type>();

            // Get all types in the Stellar.XDR namespace
            var allTypes = assembly.GetTypes()
                .Where(t => t.Namespace == "Stellar.XDR")
                .Union(assembly.GetTypes()
                    .Where(t => t.Namespace == "Stellar.XDR")
                    .SelectMany(t => t.GetNestedTypes()));

            // Start with concrete types we want to test
            var concreteTypes = allTypes.Where(t =>
                t.IsClass &&
                !t.IsAbstract &&
                !t.IsInterface &&
                !(t.IsAbstract && t.IsSealed));

            // Process each concrete type and discover all needed abstract types
            foreach (var type in concreteTypes)
            {
                DiscoverAbstractTypesRecursively(type, allTypes, mappings, processedTypes);
            }

            return mappings;
        }

        private void DiscoverAbstractTypesRecursively(Type type, IEnumerable<Type> allTypes,
            Dictionary<Type, Type> mappings, HashSet<Type> processedTypes)
        {
            if (!processedTypes.Add(type)) // Returns false if already processed
                return;

            // Process properties
            foreach (var prop in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                var propertyType = prop.PropertyType;

                // Handle arrays
                if (propertyType.IsArray)
                    propertyType = propertyType.GetElementType();

                // If property type is abstract, find implementation
                if (propertyType.IsClass && propertyType.IsAbstract && !propertyType.IsSealed)
                {
                    if (!mappings.ContainsKey(propertyType))
                    {
                        var implementation = FindConcreteImplementation(propertyType, allTypes);
                        if (implementation != null)
                        {
                            mappings[propertyType] = implementation;
                            // Recursively process the implementation type
                            DiscoverAbstractTypesRecursively(implementation, allTypes, mappings, processedTypes);
                        }
                        else
                        {
                            Console.WriteLine($"WARNING: No concrete implementation found for abstract type {propertyType.Name}");
                        }
                    }
                }

                // Recursively process non-abstract property types
                if (propertyType.IsClass && propertyType.Namespace == "Stellar.XDR")
                {
                    DiscoverAbstractTypesRecursively(propertyType, allTypes, mappings, processedTypes);
                }
            }
        }

        private Type FindConcreteImplementation(Type abstractType, IEnumerable<Type> allTypes)
        {
            var implementations = allTypes
                .Where(t =>
                    !t.IsAbstract &&
                    abstractType.IsAssignableFrom(t))
                .ToList();

            if (implementations.Any())
            {
                var implementation = implementations.First();
                Console.WriteLine($"Mapping abstract type {abstractType.Name} to concrete type {implementation.Name}");
                return implementation;
            }

            return null;
        }

        public async Task RunAllTests()
        {
            // Get the assembly containing Stellar.XDR types
            var assembly = Assembly.Load("StellarRPCSDK");
            var types = GetAllTestableTypes(assembly);

            foreach (var type in types)
            {
                await TestType(type);
            }
        }

        private IEnumerable<Type> GetAllTestableTypes(Assembly assembly)
        {
            var allTypes = assembly.GetTypes()
                .Where(t => t.Namespace == "Stellar.XDR")
                .Union(assembly.GetTypes()
                    .Where(t => t.Namespace == "Stellar.XDR")
                    .SelectMany(t => t.GetNestedTypes()));

            return allTypes.Where(t =>
                t.IsClass &&
                !t.IsAbstract &&
                !t.IsInterface &&
                !(t.IsAbstract && t.IsSealed) && // not static
                t.Name != "XdrReader" &&
                t.Name != "XdrWriter" &&
                // Exclude union case classes
                !(t.IsNested &&
                  t.DeclaringType.IsAbstract &&
                  t.GetProperty("Discriminator") != null));
        }

        private Type FindXdrSerializer(Type type)
        {
            if (!type.IsNested)
            {
                // Normal type - look for TypeXdr
                return type.Assembly.GetType($"{type.Namespace}.{type.Name}Xdr");
            }

            // For nested types, first check if it's a union case class (which we should skip)
            if (type.DeclaringType.IsAbstract && type.GetProperty("Discriminator") != null)
            {
                return null;
            }

            // For nested struct types, look for DeclaringType.TypeXdr
            return type.DeclaringType.GetNestedType($"{type.Name}Xdr");
        }

        private async Task TestType(Type type)
        {
            try
            {
                Console.WriteLine($"\nTesting {type.FullName}");
                var testInstance = _fixture.Create(type, new SpecimenContext(_fixture));

                var xdrType = FindXdrSerializer(type);
                if (xdrType == null)
                {
                    Console.WriteLine($"WARNING: No XDR serializer found for {type.FullName}");
                    return;
                }



                // First serialization
                var firstXdr = InvokeStaticMethod(xdrType, "EncodeToBase64", testInstance);

                // Deserialize and reserialize
                using (var stream = new MemoryStream(Convert.FromBase64String(firstXdr)))
                {
                    var reader = new XdrReader(stream);
                    var decoded = InvokeStaticMethod(xdrType, "Decode", reader);
                    var secondXdr = InvokeStaticMethod(xdrType, "EncodeToBase64", decoded);

                    // Compare XDR strings
                    var success = firstXdr == secondXdr;

                    await LogTestCase(new TestCase
                    {
                        TypeName = type.FullName,
                        FirstXdrBase64 = firstXdr,
                        SecondXdrBase64 = secondXdr,
                        Success = success
                    });

                    if (!success)
                    {
                        Console.WriteLine("WARNING: XDR strings do not match!");
                        Console.WriteLine($"First XDR:  {firstXdr}");
                        Console.WriteLine($"Second XDR: {secondXdr}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR testing {type.FullName}: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }

        private static dynamic InvokeStaticMethod(Type type, string methodName, object parameter)
        {
            var method = type.GetMethod(methodName);
            if (method == null)
                throw new InvalidOperationException($"Method {methodName} not found on type {type.Name}");

            // Pass as single-element array to prevent implicit conversion
            return method.Invoke(null, new[] { parameter });
        }

        private async Task LogTestCase(TestCase testCase)
        {
            var json = JsonSerializer.Serialize(testCase, new JsonSerializerOptions
            {
                WriteIndented = true,
                MaxDepth = 32
            });

            Console.WriteLine(json);

   
        }
    }
}
