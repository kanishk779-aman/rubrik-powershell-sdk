// CheckGuestOsReply.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region CheckGuestOsReply
    public class CheckGuestOsReply: BaseType
    {
        #region members

        //      C# -> List<GuestOs>? SupportedOs
        // GraphQL -> supportedOs: [GuestOS!]! (enum)
        [JsonProperty("supportedOs")]
        public List<GuestOs>? SupportedOs { get; set; }

        //      C# -> System.Boolean? Success
        // GraphQL -> success: Boolean! (scalar)
        [JsonProperty("success")]
        public System.Boolean? Success { get; set; }

        //      C# -> List<CheckGuestOsResult>? ValidationResult
        // GraphQL -> validationResult: [CheckGuestOsResult!]! (type)
        [JsonProperty("validationResult")]
        public List<CheckGuestOsResult>? ValidationResult { get; set; }


        #endregion

    #region methods

    public CheckGuestOsReply Set(
        List<GuestOs>? SupportedOs = null,
        System.Boolean? Success = null,
        List<CheckGuestOsResult>? ValidationResult = null
    ) 
    {
        if ( SupportedOs != null ) {
            this.SupportedOs = SupportedOs;
        }
        if ( Success != null ) {
            this.Success = Success;
        }
        if ( ValidationResult != null ) {
            this.ValidationResult = ValidationResult;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<GuestOs>? SupportedOs
        // GraphQL -> supportedOs: [GuestOS!]! (enum)
        if (this.SupportedOs != null) {
            s += ind + "supportedOs\n" ;
        }
        //      C# -> System.Boolean? Success
        // GraphQL -> success: Boolean! (scalar)
        if (this.Success != null) {
            s += ind + "success\n" ;
        }
        //      C# -> List<CheckGuestOsResult>? ValidationResult
        // GraphQL -> validationResult: [CheckGuestOsResult!]! (type)
        if (this.ValidationResult != null) {
            s += ind + "validationResult {\n" + this.ValidationResult.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<GuestOs>? SupportedOs
        // GraphQL -> supportedOs: [GuestOS!]! (enum)
        if (this.SupportedOs == null && Exploration.Includes(parent + ".supportedOs", true))
        {
            this.SupportedOs = new List<GuestOs>();
        }
        //      C# -> System.Boolean? Success
        // GraphQL -> success: Boolean! (scalar)
        if (this.Success == null && Exploration.Includes(parent + ".success", true))
        {
            this.Success = true;
        }
        //      C# -> List<CheckGuestOsResult>? ValidationResult
        // GraphQL -> validationResult: [CheckGuestOsResult!]! (type)
        if (this.ValidationResult == null && Exploration.Includes(parent + ".validationResult"))
        {
            this.ValidationResult = new List<CheckGuestOsResult>();
            this.ValidationResult.ApplyExploratoryFieldSpec(parent + ".validationResult");
        }
    }


    #endregion

    } // class CheckGuestOsReply
    
    #endregion

    public static class ListCheckGuestOsReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<CheckGuestOsReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CheckGuestOsReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CheckGuestOsReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types