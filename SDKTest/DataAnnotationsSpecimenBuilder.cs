using AutoFixture.Kernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SDKTest
{
    public class DataAnnotationsSpecimenBuilder : ISpecimenBuilder
    {
        public object Create(object request, ISpecimenContext context)
        {
            PropertyInfo propertyInfo = null;

            if (request is PropertyInfo pi)
            {
                propertyInfo = pi;
            }
            else if (request is SeededRequest seededRequest)
            {
                propertyInfo = seededRequest.Request as PropertyInfo;
            }

            if (propertyInfo == null)
                return new NoSpecimen();

            var minLength = propertyInfo.GetCustomAttribute<MinLengthAttribute>()?.Length;
            var maxLength = propertyInfo.GetCustomAttribute<MaxLengthAttribute>()?.Length;

            if (propertyInfo.PropertyType.IsArray)
            {
                var elementType = propertyInfo.PropertyType.GetElementType();
                var initialLength = minLength ?? maxLength ?? 1;

                // Special handling for byte arrays
                if (elementType == typeof(byte))
                {
                    var array = Array.CreateInstance(elementType, initialLength);
                    for (int i = 0; i < initialLength; i++)
                    {
                        array.SetValue((byte)0, i);
                    }
                    return array;
                }
                else
                {
                    // For other types, create a list first so we can filter out OmitSpecimens
                    var validElements = new List<object>();

                    for (int i = 0; i < initialLength; i++)
                    {
                        var element = context.Resolve(elementType);
                        if (!(element is OmitSpecimen))
                        {
                            validElements.Add(element);
                        }
                    }

                    // Create array of actual size needed
                    var array = Array.CreateInstance(elementType, validElements.Count);
                    for (int i = 0; i < validElements.Count; i++)
                    {
                        array.SetValue(validElements[i], i);
                    }
                    return array;
                }
            }

            return new NoSpecimen();
        }
    }
}
