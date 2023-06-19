// AddConfiguredGroupToHierarchyReply.cs
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
    #region AddConfiguredGroupToHierarchyReply
    public class AddConfiguredGroupToHierarchyReply: BaseType
    {
        #region members

        //      C# -> System.String? GroupId
        // GraphQL -> groupId: UUID! (scalar)
        [JsonProperty("groupId")]
        public System.String? GroupId { get; set; }


        #endregion

    #region methods

    public AddConfiguredGroupToHierarchyReply Set(
        System.String? GroupId = null
    ) 
    {
        if ( GroupId != null ) {
            this.GroupId = GroupId;
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
        //      C# -> System.String? GroupId
        // GraphQL -> groupId: UUID! (scalar)
        if (this.GroupId != null) {
            s += ind + "groupId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? GroupId
        // GraphQL -> groupId: UUID! (scalar)
        if (this.GroupId == null && Exploration.Includes(parent + ".groupId", true))
        {
            this.GroupId = "FETCH";
        }
    }


    #endregion

    } // class AddConfiguredGroupToHierarchyReply
    
    #endregion

    public static class ListAddConfiguredGroupToHierarchyReplyExtensions
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
            this List<AddConfiguredGroupToHierarchyReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AddConfiguredGroupToHierarchyReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AddConfiguredGroupToHierarchyReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types