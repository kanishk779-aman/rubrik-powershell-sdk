// TprRequestedChangeTprRuleEntry.cs
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
    #region TprRequestedChangeTprRuleEntry
    public class TprRequestedChangeTprRuleEntry: BaseType
    {
        #region members

        //      C# -> List<TprRule>? NewValue
        // GraphQL -> newValue: [TprRule!]! (enum)
        [JsonProperty("newValue")]
        public List<TprRule>? NewValue { get; set; }

        //      C# -> List<TprRule>? OldValue
        // GraphQL -> oldValue: [TprRule!]! (enum)
        [JsonProperty("oldValue")]
        public List<TprRule>? OldValue { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TprRequestedChangeTprRuleEntry";
    }

    public TprRequestedChangeTprRuleEntry Set(
        List<TprRule>? NewValue = null,
        List<TprRule>? OldValue = null
    ) 
    {
        if ( NewValue != null ) {
            this.NewValue = NewValue;
        }
        if ( OldValue != null ) {
            this.OldValue = OldValue;
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
        //      C# -> List<TprRule>? NewValue
        // GraphQL -> newValue: [TprRule!]! (enum)
        if (this.NewValue != null) {
            s += ind + "newValue\n" ;
        }
        //      C# -> List<TprRule>? OldValue
        // GraphQL -> oldValue: [TprRule!]! (enum)
        if (this.OldValue != null) {
            s += ind + "oldValue\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<TprRule>? NewValue
        // GraphQL -> newValue: [TprRule!]! (enum)
        if (this.NewValue == null && ec.Includes("newValue",true))
        {
            this.NewValue = new List<TprRule>();
        }
        //      C# -> List<TprRule>? OldValue
        // GraphQL -> oldValue: [TprRule!]! (enum)
        if (this.OldValue == null && ec.Includes("oldValue",true))
        {
            this.OldValue = new List<TprRule>();
        }
    }


    #endregion

    } // class TprRequestedChangeTprRuleEntry
    
    #endregion

    public static class ListTprRequestedChangeTprRuleEntryExtensions
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
            this List<TprRequestedChangeTprRuleEntry> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TprRequestedChangeTprRuleEntry> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TprRequestedChangeTprRuleEntry());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<TprRequestedChangeTprRuleEntry> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types