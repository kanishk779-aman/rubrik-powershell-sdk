// RemoveCloudClusterNodesInput.cs
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
    #region RemoveCloudClusterNodesInput

    public class RemoveCloudClusterNodesInput: IInput
    {
        #region members

        //      C# -> List<System.String>? NodeIds
        // GraphQL -> nodeIds: [String!] (scalar)
        [JsonProperty("nodeIds")]
        public List<System.String>? NodeIds { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("cloudAccountId")]
        public System.String? CloudAccountId { get; set; }


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

    } // class RemoveCloudClusterNodesInput
    #endregion

} // namespace RubrikSecurityCloud.Types