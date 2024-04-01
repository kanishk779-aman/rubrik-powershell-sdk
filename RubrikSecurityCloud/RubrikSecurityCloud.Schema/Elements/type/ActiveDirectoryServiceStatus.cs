// ActiveDirectoryServiceStatus.cs
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
    #region ActiveDirectoryServiceStatus
    public class ActiveDirectoryServiceStatus: BaseType
    {
        #region members

        //      C# -> ServiceStatus? ServiceStatus
        // GraphQL -> serviceStatus: ServiceStatus! (enum)
        [JsonProperty("serviceStatus")]
        public ServiceStatus? ServiceStatus { get; set; }

        //      C# -> DateTime? TimestampMillis
        // GraphQL -> timestampMillis: DateTime (scalar)
        [JsonProperty("timestampMillis")]
        public DateTime? TimestampMillis { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ActiveDirectoryServiceStatus";
    }

    public ActiveDirectoryServiceStatus Set(
        ServiceStatus? ServiceStatus = null,
        DateTime? TimestampMillis = null
    ) 
    {
        if ( ServiceStatus != null ) {
            this.ServiceStatus = ServiceStatus;
        }
        if ( TimestampMillis != null ) {
            this.TimestampMillis = TimestampMillis;
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
        //      C# -> ServiceStatus? ServiceStatus
        // GraphQL -> serviceStatus: ServiceStatus! (enum)
        if (this.ServiceStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "serviceStatus\n" ;
            } else {
                s += ind + "serviceStatus\n" ;
            }
        }
        //      C# -> DateTime? TimestampMillis
        // GraphQL -> timestampMillis: DateTime (scalar)
        if (this.TimestampMillis != null) {
            if (conf.Flat) {
                s += conf.Prefix + "timestampMillis\n" ;
            } else {
                s += ind + "timestampMillis\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ServiceStatus? ServiceStatus
        // GraphQL -> serviceStatus: ServiceStatus! (enum)
        if (ec.Includes("serviceStatus",true))
        {
            if(this.ServiceStatus == null) {

                this.ServiceStatus = new ServiceStatus();

            } else {


            }
        }
        else if (this.ServiceStatus != null && ec.Excludes("serviceStatus",true))
        {
            this.ServiceStatus = null;
        }
        //      C# -> DateTime? TimestampMillis
        // GraphQL -> timestampMillis: DateTime (scalar)
        if (ec.Includes("timestampMillis",true))
        {
            if(this.TimestampMillis == null) {

                this.TimestampMillis = new DateTime();

            } else {


            }
        }
        else if (this.TimestampMillis != null && ec.Excludes("timestampMillis",true))
        {
            this.TimestampMillis = null;
        }
    }


    #endregion

    } // class ActiveDirectoryServiceStatus
    
    #endregion

    public static class ListActiveDirectoryServiceStatusExtensions
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
            this List<ActiveDirectoryServiceStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ActiveDirectoryServiceStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ActiveDirectoryServiceStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActiveDirectoryServiceStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActiveDirectoryServiceStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types