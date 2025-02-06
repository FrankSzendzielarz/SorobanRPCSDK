using AutoFixture;
using AutoFixture.Kernel;

namespace SDKTest
{
    public class DataAnnotationsCustomization : ICustomization
    {
        public void Customize(IFixture fixture)
        {
            fixture.Customizations.Add(new DataAnnotationsSpecimenBuilder());
        }
    }
    public class XdrWrapperCustomization : ICustomization
    {
        public void Customize(IFixture fixture)
        {
            fixture.Customizations.Add(new XdrWrapperBuilder());
        }
    }

    public class XdrWrapperBuilder : ISpecimenBuilder
    {
        public object Create(object request, ISpecimenContext context)
        {
            var type = request as Type;
            if (type == null) return new NoSpecimen();

            // Only handle Stellar.XDR types
            if (type.Namespace != "Stellar.XDR")
                return new NoSpecimen();

            // Check if this is a wrapper type by looking for InnerValue property
            var innerValueProp = type.GetProperty("InnerValue");
            if (innerValueProp == null)
                return new NoSpecimen();

            try
            {
                var instance = Activator.CreateInstance(type);

                // Create inner value with property info preservation
                var innerRequest = new SeededRequest(
                    innerValueProp,  // The PropertyInfo
                    innerValueProp.PropertyType  // The type
                );
                var innerValue = context.Resolve(innerRequest);

                innerValueProp.SetValue(instance, innerValue);
                return instance;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in XdrWrapperBuilder: {ex.Message}");
                throw;
            }
        }
    }
}
