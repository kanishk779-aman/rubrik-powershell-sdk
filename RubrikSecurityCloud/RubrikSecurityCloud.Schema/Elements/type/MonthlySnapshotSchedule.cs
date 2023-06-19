// MonthlySnapshotSchedule.cs
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
    #region MonthlySnapshotSchedule
    public class MonthlySnapshotSchedule: BaseType
    {
        #region members

        //      C# -> DayOfMonth? DayOfMonth
        // GraphQL -> dayOfMonth: DayOfMonth! (enum)
        [JsonProperty("dayOfMonth")]
        public DayOfMonth? DayOfMonth { get; set; }

        //      C# -> BasicSnapshotSchedule? BasicSchedule
        // GraphQL -> basicSchedule: BasicSnapshotSchedule (type)
        [JsonProperty("basicSchedule")]
        public BasicSnapshotSchedule? BasicSchedule { get; set; }


        #endregion

    #region methods

    public MonthlySnapshotSchedule Set(
        DayOfMonth? DayOfMonth = null,
        BasicSnapshotSchedule? BasicSchedule = null
    ) 
    {
        if ( DayOfMonth != null ) {
            this.DayOfMonth = DayOfMonth;
        }
        if ( BasicSchedule != null ) {
            this.BasicSchedule = BasicSchedule;
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
        //      C# -> DayOfMonth? DayOfMonth
        // GraphQL -> dayOfMonth: DayOfMonth! (enum)
        if (this.DayOfMonth != null) {
            s += ind + "dayOfMonth\n" ;
        }
        //      C# -> BasicSnapshotSchedule? BasicSchedule
        // GraphQL -> basicSchedule: BasicSnapshotSchedule (type)
        if (this.BasicSchedule != null) {
            var fspec = this.BasicSchedule.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "basicSchedule {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DayOfMonth? DayOfMonth
        // GraphQL -> dayOfMonth: DayOfMonth! (enum)
        if (this.DayOfMonth == null && Exploration.Includes(parent + ".dayOfMonth", true))
        {
            this.DayOfMonth = new DayOfMonth();
        }
        //      C# -> BasicSnapshotSchedule? BasicSchedule
        // GraphQL -> basicSchedule: BasicSnapshotSchedule (type)
        if (this.BasicSchedule == null && Exploration.Includes(parent + ".basicSchedule"))
        {
            this.BasicSchedule = new BasicSnapshotSchedule();
            this.BasicSchedule.ApplyExploratoryFieldSpec(parent + ".basicSchedule");
        }
    }


    #endregion

    } // class MonthlySnapshotSchedule
    
    #endregion

    public static class ListMonthlySnapshotScheduleExtensions
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
            this List<MonthlySnapshotSchedule> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MonthlySnapshotSchedule> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new MonthlySnapshotSchedule());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types