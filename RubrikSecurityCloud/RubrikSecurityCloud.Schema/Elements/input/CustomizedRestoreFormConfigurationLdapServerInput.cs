// CustomizedRestoreFormConfigurationLdapServerInput.cs
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
    #region CustomizedRestoreFormConfigurationLdapServerInput

    public class CustomizedRestoreFormConfigurationLdapServerInput: IInput
    {
        #region members

        //      C# -> System.String? BindUserName
        // GraphQL -> bindUserName: String (scalar)
        [JsonProperty("bindUserName")]
        public System.String? BindUserName { get; set; }

        //      C# -> System.String? BindUserPassword
        // GraphQL -> bindUserPassword: String (scalar)
        [JsonProperty("bindUserPassword")]
        public System.String? BindUserPassword { get; set; }

        //      C# -> RestoreFormConfigurationLdapServerInput? RestoreFormConfigurationLdapServer
        // GraphQL -> restoreFormConfigurationLdapServer: RestoreFormConfigurationLdapServerInput (input)
        [JsonProperty("restoreFormConfigurationLdapServer")]
        public RestoreFormConfigurationLdapServerInput? RestoreFormConfigurationLdapServer { get; set; }


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

    } // class CustomizedRestoreFormConfigurationLdapServerInput
    #endregion

} // namespace RubrikSecurityCloud.Types