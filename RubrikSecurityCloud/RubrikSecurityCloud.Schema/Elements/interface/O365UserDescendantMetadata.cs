// O365UserDescendantMetadata.cs
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
    #region O365UserDescendantMetadata

    public interface O365UserDescendantMetadata: IFieldSpec
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        System.String? Name { get; set; }

        //      C# -> System.String? UserPrincipalName
        // GraphQL -> userPrincipalName: String! (scalar)
        [JsonProperty("userPrincipalName")]
        System.String? UserPrincipalName { get; set; }

        //      C# -> System.String? PreferredDataLocation
        // GraphQL -> preferredDataLocation: String! (scalar)
        [JsonProperty("preferredDataLocation")]
        System.String? PreferredDataLocation { get; set; }


        #endregion

    } // interface O365UserDescendantMetadata

    #endregion



    public static class ListO365UserDescendantMetadataExtensions
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
            this List<O365UserDescendantMetadata> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            string fieldspecs = "";
            foreach (O365UserDescendantMetadata item in list) 
            {
                var fspec = item.AsFieldSpec(indent+1);
                if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                    fieldspecs += ind + " ... on " + item.GetType().Name + " {\n" + fspec + ind + "}\n";
                }
            }
            return fieldspecs;
        }

        public static void ApplyExploratoryFieldSpec(
            this List<O365UserDescendantMetadata> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                InterfaceHelper
                    .AddInstancesOfImplementingTypes<O365UserDescendantMetadata>(
                        ref list, 
                        instance => instance.ApplyExploratoryFieldSpec(parent));
            } else {
                foreach (O365UserDescendantMetadata item in list) {
                    item.ApplyExploratoryFieldSpec(parent);
                }
            }

        }
    }


} // namespace RubrikSecurityCloud.Types