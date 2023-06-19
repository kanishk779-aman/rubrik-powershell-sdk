// ExportSnapshotJobConfigForBatchInput.cs
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
    #region ExportSnapshotJobConfigForBatchInput

    public class ExportSnapshotJobConfigForBatchInput: IInput
    {
        #region members

        //      C# -> DateTime? SnapshotAfterDate
        // GraphQL -> snapshotAfterDate: DateTime (scalar)
        [JsonProperty("snapshotAfterDate")]
        public DateTime? SnapshotAfterDate { get; set; }

        //      C# -> DateTime? SnapshotBeforeDate
        // GraphQL -> snapshotBeforeDate: DateTime (scalar)
        [JsonProperty("snapshotBeforeDate")]
        public DateTime? SnapshotBeforeDate { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? VmNamePrefix
        // GraphQL -> vmNamePrefix: String (scalar)
        [JsonProperty("vmNamePrefix")]
        public System.String? VmNamePrefix { get; set; }

        //      C# -> ExportSnapshotJobConfigV2Input? Config
        // GraphQL -> config: ExportSnapshotJobConfigV2Input! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("config")]
        public ExportSnapshotJobConfigV2Input? Config { get; set; }

        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("vmId")]
        public System.String? VmId { get; set; }


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

    } // class ExportSnapshotJobConfigForBatchInput
    #endregion

} // namespace RubrikSecurityCloud.Types