// RestoreFormConfigurationSmtp.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region RestoreFormConfigurationSmtp
    public class RestoreFormConfigurationSmtp: BaseType
    {
        #region members

        //      C# -> System.String? FromEmailId
        // GraphQL -> fromEmailId: String! (scalar)
        [JsonProperty("fromEmailId")]
        public System.String? FromEmailId { get; set; }

        //      C# -> System.String? SmtpHostname
        // GraphQL -> smtpHostname: String! (scalar)
        [JsonProperty("smtpHostname")]
        public System.String? SmtpHostname { get; set; }

        //      C# -> System.Int64? SmtpPort
        // GraphQL -> smtpPort: Long! (scalar)
        [JsonProperty("smtpPort")]
        public System.Int64? SmtpPort { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RestoreFormConfigurationSmtp";
    }

    public RestoreFormConfigurationSmtp Set(
        System.String? FromEmailId = null,
        System.String? SmtpHostname = null,
        System.Int64? SmtpPort = null
    ) 
    {
        if ( FromEmailId != null ) {
            this.FromEmailId = FromEmailId;
        }
        if ( SmtpHostname != null ) {
            this.SmtpHostname = SmtpHostname;
        }
        if ( SmtpPort != null ) {
            this.SmtpPort = SmtpPort;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? FromEmailId
        // GraphQL -> fromEmailId: String! (scalar)
        if (this.FromEmailId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fromEmailId\n" ;
            } else {
                s += ind + "fromEmailId\n" ;
            }
        }
        //      C# -> System.String? SmtpHostname
        // GraphQL -> smtpHostname: String! (scalar)
        if (this.SmtpHostname != null) {
            if (conf.Flat) {
                s += conf.Prefix + "smtpHostname\n" ;
            } else {
                s += ind + "smtpHostname\n" ;
            }
        }
        //      C# -> System.Int64? SmtpPort
        // GraphQL -> smtpPort: Long! (scalar)
        if (this.SmtpPort != null) {
            if (conf.Flat) {
                s += conf.Prefix + "smtpPort\n" ;
            } else {
                s += ind + "smtpPort\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? FromEmailId
        // GraphQL -> fromEmailId: String! (scalar)
        if (ec.Includes("fromEmailId",true))
        {
            if(this.FromEmailId == null) {

                this.FromEmailId = "FETCH";

            } else {


            }
        }
        else if (this.FromEmailId != null && ec.Excludes("fromEmailId",true))
        {
            this.FromEmailId = null;
        }
        //      C# -> System.String? SmtpHostname
        // GraphQL -> smtpHostname: String! (scalar)
        if (ec.Includes("smtpHostname",true))
        {
            if(this.SmtpHostname == null) {

                this.SmtpHostname = "FETCH";

            } else {


            }
        }
        else if (this.SmtpHostname != null && ec.Excludes("smtpHostname",true))
        {
            this.SmtpHostname = null;
        }
        //      C# -> System.Int64? SmtpPort
        // GraphQL -> smtpPort: Long! (scalar)
        if (ec.Includes("smtpPort",true))
        {
            if(this.SmtpPort == null) {

                this.SmtpPort = new System.Int64();

            } else {


            }
        }
        else if (this.SmtpPort != null && ec.Excludes("smtpPort",true))
        {
            this.SmtpPort = null;
        }
    }


    #endregion

    } // class RestoreFormConfigurationSmtp
    
    #endregion

    public static class ListRestoreFormConfigurationSmtpExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<RestoreFormConfigurationSmtp> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RestoreFormConfigurationSmtp> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RestoreFormConfigurationSmtp> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RestoreFormConfigurationSmtp());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RestoreFormConfigurationSmtp> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types