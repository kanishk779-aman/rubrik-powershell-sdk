// RubrikCloudVaultLocation.cs
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
    #region RubrikCloudVaultLocation
    public class RubrikCloudVaultLocation: BaseType
    {
        #region members

        //      C# -> RubrikCloudVaultType? Type
        // GraphQL -> type: RubrikCloudVaultType! (enum)
        [JsonProperty("type")]
        public RubrikCloudVaultType? Type { get; set; }

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<System.String>? SlaDomains
        // GraphQL -> slaDomains: [String!]! (scalar)
        [JsonProperty("slaDomains")]
        public List<System.String>? SlaDomains { get; set; }


        #endregion

    #region methods

    public RubrikCloudVaultLocation Set(
        RubrikCloudVaultType? Type = null,
        System.String? ClusterName = null,
        System.String? Id = null,
        System.String? Name = null,
        List<System.String>? SlaDomains = null
    ) 
    {
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( SlaDomains != null ) {
            this.SlaDomains = SlaDomains;
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
        //      C# -> RubrikCloudVaultType? Type
        // GraphQL -> type: RubrikCloudVaultType! (enum)
        if (this.Type != null) {
            s += ind + "type\n" ;
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName != null) {
            s += ind + "clusterName\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> List<System.String>? SlaDomains
        // GraphQL -> slaDomains: [String!]! (scalar)
        if (this.SlaDomains != null) {
            s += ind + "slaDomains\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> RubrikCloudVaultType? Type
        // GraphQL -> type: RubrikCloudVaultType! (enum)
        if (this.Type == null && Exploration.Includes(parent + ".type", true))
        {
            this.Type = new RubrikCloudVaultType();
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName == null && Exploration.Includes(parent + ".clusterName", true))
        {
            this.ClusterName = new System.String("FETCH");
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = new System.String("FETCH");
        }
        //      C# -> List<System.String>? SlaDomains
        // GraphQL -> slaDomains: [String!]! (scalar)
        if (this.SlaDomains == null && Exploration.Includes(parent + ".slaDomains", true))
        {
            this.SlaDomains = new List<System.String>();
        }
    }


    #endregion

    } // class RubrikCloudVaultLocation
    
    #endregion

    public static class ListRubrikCloudVaultLocationExtensions
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
            this List<RubrikCloudVaultLocation> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RubrikCloudVaultLocation> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RubrikCloudVaultLocation());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types