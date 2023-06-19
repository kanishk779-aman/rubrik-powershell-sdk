// ClassificationBannerSettingsInputType.cs
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
    #region ClassificationBannerSettingsInputType

    public class ClassificationBannerSettingsInputType: IInput
    {
        #region members

        //      C# -> System.String? Account
        // GraphQL -> account: String (scalar)
        [JsonProperty("account")]
        public System.String? Account { get; set; }

        //      C# -> System.String? BannerText
        // GraphQL -> bannerText: String (scalar)
        [JsonProperty("bannerText")]
        public System.String? BannerText { get; set; }

        //      C# -> BannerColor? BannerColor
        // GraphQL -> bannerColor: BannerColor (enum)
        [JsonProperty("bannerColor")]
        public BannerColor? BannerColor { get; set; }


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

    } // class ClassificationBannerSettingsInputType
    #endregion

} // namespace RubrikSecurityCloud.Types