// SetRansomwareInvestigationEnabledInput.cs
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
    #region SetRansomwareInvestigationEnabledInput

    public class SetRansomwareInvestigationEnabledInput: IInput
    {
        #region members

        //      C# -> System.String? EntityId
        // GraphQL -> entityId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("entityId")]
        public System.String? EntityId { get; set; }

        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("enabled")]
        public System.Boolean? Enabled { get; set; }

        //      C# -> RansomwareInvestigationEnablementEntity? EntityType
        // GraphQL -> entityType: RansomwareInvestigationEnablementEntity! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("entityType")]
        public RansomwareInvestigationEnablementEntity? EntityType { get; set; }


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

    } // class SetRansomwareInvestigationEnabledInput
    #endregion

} // namespace RubrikSecurityCloud.Types