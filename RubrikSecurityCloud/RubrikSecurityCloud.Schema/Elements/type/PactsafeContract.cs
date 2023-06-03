// PactsafeContract.cs
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
    #region PactsafeContract
    public class PactsafeContract: BaseType
    {
        #region members

        //      C# -> System.String? ContractFile
        // GraphQL -> contractFile: String! (scalar)
        [JsonProperty("contractFile")]
        public System.String? ContractFile { get; set; }

        //      C# -> System.String? ContractId
        // GraphQL -> contractId: String! (scalar)
        [JsonProperty("contractId")]
        public System.String? ContractId { get; set; }

        //      C# -> System.String? DownloadEndpoint
        // GraphQL -> downloadEndpoint: URL! (scalar)
        [JsonProperty("downloadEndpoint")]
        public System.String? DownloadEndpoint { get; set; }

        //      C# -> DateTime? EffectiveDate
        // GraphQL -> effectiveDate: DateTime! (scalar)
        [JsonProperty("effectiveDate")]
        public DateTime? EffectiveDate { get; set; }

        //      C# -> System.Boolean? IsAccepted
        // GraphQL -> isAccepted: Boolean! (scalar)
        [JsonProperty("isAccepted")]
        public System.Boolean? IsAccepted { get; set; }

        //      C# -> System.String? MajorVersionId
        // GraphQL -> majorVersionId: String! (scalar)
        [JsonProperty("majorVersionId")]
        public System.String? MajorVersionId { get; set; }

        //      C# -> System.String? PublishedVersionId
        // GraphQL -> publishedVersionId: String! (scalar)
        [JsonProperty("publishedVersionId")]
        public System.String? PublishedVersionId { get; set; }

        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        [JsonProperty("title")]
        public System.String? Title { get; set; }


        #endregion

    #region methods

    public PactsafeContract Set(
        System.String? ContractFile = null,
        System.String? ContractId = null,
        System.String? DownloadEndpoint = null,
        DateTime? EffectiveDate = null,
        System.Boolean? IsAccepted = null,
        System.String? MajorVersionId = null,
        System.String? PublishedVersionId = null,
        System.String? Title = null
    ) 
    {
        if ( ContractFile != null ) {
            this.ContractFile = ContractFile;
        }
        if ( ContractId != null ) {
            this.ContractId = ContractId;
        }
        if ( DownloadEndpoint != null ) {
            this.DownloadEndpoint = DownloadEndpoint;
        }
        if ( EffectiveDate != null ) {
            this.EffectiveDate = EffectiveDate;
        }
        if ( IsAccepted != null ) {
            this.IsAccepted = IsAccepted;
        }
        if ( MajorVersionId != null ) {
            this.MajorVersionId = MajorVersionId;
        }
        if ( PublishedVersionId != null ) {
            this.PublishedVersionId = PublishedVersionId;
        }
        if ( Title != null ) {
            this.Title = Title;
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
        //      C# -> System.String? ContractFile
        // GraphQL -> contractFile: String! (scalar)
        if (this.ContractFile != null) {
            s += ind + "contractFile\n" ;
        }
        //      C# -> System.String? ContractId
        // GraphQL -> contractId: String! (scalar)
        if (this.ContractId != null) {
            s += ind + "contractId\n" ;
        }
        //      C# -> System.String? DownloadEndpoint
        // GraphQL -> downloadEndpoint: URL! (scalar)
        if (this.DownloadEndpoint != null) {
            s += ind + "downloadEndpoint\n" ;
        }
        //      C# -> DateTime? EffectiveDate
        // GraphQL -> effectiveDate: DateTime! (scalar)
        if (this.EffectiveDate != null) {
            s += ind + "effectiveDate\n" ;
        }
        //      C# -> System.Boolean? IsAccepted
        // GraphQL -> isAccepted: Boolean! (scalar)
        if (this.IsAccepted != null) {
            s += ind + "isAccepted\n" ;
        }
        //      C# -> System.String? MajorVersionId
        // GraphQL -> majorVersionId: String! (scalar)
        if (this.MajorVersionId != null) {
            s += ind + "majorVersionId\n" ;
        }
        //      C# -> System.String? PublishedVersionId
        // GraphQL -> publishedVersionId: String! (scalar)
        if (this.PublishedVersionId != null) {
            s += ind + "publishedVersionId\n" ;
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title != null) {
            s += ind + "title\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ContractFile
        // GraphQL -> contractFile: String! (scalar)
        if (this.ContractFile == null && Exploration.Includes(parent + ".contractFile", true))
        {
            this.ContractFile = new System.String("FETCH");
        }
        //      C# -> System.String? ContractId
        // GraphQL -> contractId: String! (scalar)
        if (this.ContractId == null && Exploration.Includes(parent + ".contractId", true))
        {
            this.ContractId = new System.String("FETCH");
        }
        //      C# -> System.String? DownloadEndpoint
        // GraphQL -> downloadEndpoint: URL! (scalar)
        if (this.DownloadEndpoint == null && Exploration.Includes(parent + ".downloadEndpoint", true))
        {
            this.DownloadEndpoint = new System.String("FETCH");
        }
        //      C# -> DateTime? EffectiveDate
        // GraphQL -> effectiveDate: DateTime! (scalar)
        if (this.EffectiveDate == null && Exploration.Includes(parent + ".effectiveDate", true))
        {
            this.EffectiveDate = new DateTime();
        }
        //      C# -> System.Boolean? IsAccepted
        // GraphQL -> isAccepted: Boolean! (scalar)
        if (this.IsAccepted == null && Exploration.Includes(parent + ".isAccepted", true))
        {
            this.IsAccepted = true;
        }
        //      C# -> System.String? MajorVersionId
        // GraphQL -> majorVersionId: String! (scalar)
        if (this.MajorVersionId == null && Exploration.Includes(parent + ".majorVersionId", true))
        {
            this.MajorVersionId = new System.String("FETCH");
        }
        //      C# -> System.String? PublishedVersionId
        // GraphQL -> publishedVersionId: String! (scalar)
        if (this.PublishedVersionId == null && Exploration.Includes(parent + ".publishedVersionId", true))
        {
            this.PublishedVersionId = new System.String("FETCH");
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title == null && Exploration.Includes(parent + ".title", true))
        {
            this.Title = new System.String("FETCH");
        }
    }


    #endregion

    } // class PactsafeContract
    
    #endregion

    public static class ListPactsafeContractExtensions
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
            this List<PactsafeContract> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<PactsafeContract> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new PactsafeContract());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types