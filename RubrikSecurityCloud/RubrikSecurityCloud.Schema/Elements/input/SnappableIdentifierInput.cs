// SnappableIdentifierInput.cs
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
    #region SnappableIdentifierInput

    public class SnappableIdentifierInput: IInput
    {
        #region members

        //      C# -> System.String? SnappableId
        // GraphQL -> snappableId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snappableId")]
        public System.String? SnappableId { get; set; }

        //      C# -> ObjectTypeEnum? SnappableType
        // GraphQL -> snappableType: ObjectTypeEnum! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("snappableType")]
        public ObjectTypeEnum? SnappableType { get; set; }

        //      C# -> System.Int64? RecoveryPoint
        // GraphQL -> recoveryPoint: Long (scalar)
        [JsonProperty("recoveryPoint")]
        public System.Int64? RecoveryPoint { get; set; }


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

    } // class SnappableIdentifierInput
    #endregion

} // namespace RubrikSecurityCloud.Types