// DailyChangeSummary.cs
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
    #region DailyChangeSummary
    public class DailyChangeSummary: BaseType
    {
        #region members

        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }

        //      C# -> ChangeCounts? Counts
        // GraphQL -> counts: ChangeCounts (type)
        [JsonProperty("counts")]
        public ChangeCounts? Counts { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DailyChangeSummary";
    }

    public DailyChangeSummary Set(
        DateTime? StartTime = null,
        ChangeCounts? Counts = null
    ) 
    {
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( Counts != null ) {
            this.Counts = Counts;
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
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime != null) {
            s += ind + "startTime\n" ;
        }
        //      C# -> ChangeCounts? Counts
        // GraphQL -> counts: ChangeCounts (type)
        if (this.Counts != null) {
            var fspec = this.Counts.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "counts {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime == null && Exploration.Includes(parent + ".startTime", true))
        {
            this.StartTime = new DateTime();
        }
        //      C# -> ChangeCounts? Counts
        // GraphQL -> counts: ChangeCounts (type)
        if (this.Counts == null && Exploration.Includes(parent + ".counts"))
        {
            this.Counts = new ChangeCounts();
            this.Counts.ApplyExploratoryFieldSpec(parent + ".counts");
        }
    }


    #endregion

    } // class DailyChangeSummary
    
    #endregion

    public static class ListDailyChangeSummaryExtensions
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
            this List<DailyChangeSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DailyChangeSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new DailyChangeSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types