// PreviewFilterInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region PreviewFilterInput

    public class PreviewFilterInput: IInput
    {
        #region members

        //      C# -> System.Int32? Limit
        // GraphQL -> limit: Int (scalar)
        [JsonProperty("limit")]
        public System.Int32? Limit { get; set; }

        //      C# -> System.Int32? Offset
        // GraphQL -> offset: Int (scalar)
        [JsonProperty("offset")]
        public System.Int32? Offset { get; set; }

        //      C# -> System.String? FilterCondition
        // GraphQL -> filterCondition: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("filterCondition")]
        public System.String? FilterCondition { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }


        #endregion

    
        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;

                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion

    } // class PreviewFilterInput
    #endregion

} // namespace RubrikSecurityCloud.Types