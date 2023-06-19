// AwsCloudAccountValidateInput.cs
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
    #region AwsCloudAccountValidateInput

    public class AwsCloudAccountValidateInput: IInput
    {
        #region members

        //      C# -> List<CloudAccountFeature>? Features
        // GraphQL -> features: [CloudAccountFeature!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("features")]
        public List<CloudAccountFeature>? Features { get; set; }

        //      C# -> AwsCloudAccountAdminInput? AwsAdminAccount
        // GraphQL -> awsAdminAccount: AwsCloudAccountAdminInput (input)
        [JsonProperty("awsAdminAccount")]
        public AwsCloudAccountAdminInput? AwsAdminAccount { get; set; }

        //      C# -> List<AwsCloudAccountInput>? AwsChildAccounts
        // GraphQL -> awsChildAccounts: [AwsCloudAccountInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("awsChildAccounts")]
        public List<AwsCloudAccountInput>? AwsChildAccounts { get; set; }


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

    } // class AwsCloudAccountValidateInput
    #endregion

} // namespace RubrikSecurityCloud.Types