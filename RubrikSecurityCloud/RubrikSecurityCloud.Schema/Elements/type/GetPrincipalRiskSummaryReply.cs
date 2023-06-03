// GetPrincipalRiskSummaryReply.cs
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
    #region GetPrincipalRiskSummaryReply
    public class GetPrincipalRiskSummaryReply: BaseType
    {
        #region members

        //      C# -> RiskSummary? RiskSummary
        // GraphQL -> riskSummary: RiskSummary (type)
        [JsonProperty("riskSummary")]
        public RiskSummary? RiskSummary { get; set; }


        #endregion

    #region methods

    public GetPrincipalRiskSummaryReply Set(
        RiskSummary? RiskSummary = null
    ) 
    {
        if ( RiskSummary != null ) {
            this.RiskSummary = RiskSummary;
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
        //      C# -> RiskSummary? RiskSummary
        // GraphQL -> riskSummary: RiskSummary (type)
        if (this.RiskSummary != null) {
            s += ind + "riskSummary {\n" + this.RiskSummary.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> RiskSummary? RiskSummary
        // GraphQL -> riskSummary: RiskSummary (type)
        if (this.RiskSummary == null && Exploration.Includes(parent + ".riskSummary"))
        {
            this.RiskSummary = new RiskSummary();
            this.RiskSummary.ApplyExploratoryFieldSpec(parent + ".riskSummary");
        }
    }


    #endregion

    } // class GetPrincipalRiskSummaryReply
    
    #endregion

    public static class ListGetPrincipalRiskSummaryReplyExtensions
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
            this List<GetPrincipalRiskSummaryReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GetPrincipalRiskSummaryReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GetPrincipalRiskSummaryReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types