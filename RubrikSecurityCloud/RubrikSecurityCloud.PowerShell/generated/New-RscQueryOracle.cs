// New-RscQueryOracle.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Queries for the 'Oracle' API domain.
    /// </summary>
    /// <description>
    /// New-RscQueryOracle is a master cmdlet for Oracle work that can invoke any of the following subcommands: TopLevelDescendants, Databases, Host, Rac, DataGuardGroup, Database, LiveMounts, AcoParameters, RecoverableRanges, MissedRecoverableRanges, MissedSnapshots, AcoExampleDownloadLink, PdbDetails, HostLogBackupConfig, DatabaseLogBackupConfig, RacLogBackupConfig.
    /// </description>
    /// <example>
    /// <code>New-RscQueryOracle -TopLevelDescendants [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryOracle -Databases [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryOracle -Host [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryOracle -Rac [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryOracle -DataGuardGroup [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryOracle -Database [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryOracle -LiveMounts [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryOracle -AcoParameters [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryOracle -RecoverableRanges [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryOracle -MissedRecoverableRanges [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryOracle -MissedSnapshots [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryOracle -AcoExampleDownloadLink [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryOracle -PdbDetails [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryOracle -HostLogBackupConfig [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryOracle -DatabaseLogBackupConfig [-Arg ..] [-Field ..]</code>
    /// </example>
    /// <example>
    /// <code>New-RscQueryOracle -RacLogBackupConfig [-Arg ..] [-Field ..]</code>
    /// </example>
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQueryOracle",
        DefaultParameterSetName = "Host")
    ]
    public class New_RscQueryOracle : RscGqlPSCmdlet
    {
        
        /// <summary>
        /// TopLevelDescendants parameter set
        ///
        /// [GraphQL: oracleTopLevelDescendants]
        /// </summary>
        [Parameter(
            ParameterSetName = "TopLevelDescendants",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of the highest-level Oracle Objects accessible by the current user.
[GraphQL: oracleTopLevelDescendants]",
            Position = 0
        )]
        public SwitchParameter TopLevelDescendants { get; set; }

        
        /// <summary>
        /// Databases parameter set
        ///
        /// [GraphQL: oracleDatabases]
        /// </summary>
        [Parameter(
            ParameterSetName = "Databases",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of Oracle Databases.
[GraphQL: oracleDatabases]",
            Position = 0
        )]
        public SwitchParameter Databases { get; set; }

        
        /// <summary>
        /// Host parameter set
        ///
        /// [GraphQL: oracleHost]
        /// </summary>
        [Parameter(
            ParameterSetName = "Host",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"An Oracle Host.
[GraphQL: oracleHost]",
            Position = 0
        )]
        public new SwitchParameter Host { get; set; }

        
        /// <summary>
        /// Rac parameter set
        ///
        /// [GraphQL: oracleRac]
        /// </summary>
        [Parameter(
            ParameterSetName = "Rac",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"An Oracle Real Application Cluster.
[GraphQL: oracleRac]",
            Position = 0
        )]
        public SwitchParameter Rac { get; set; }

        
        /// <summary>
        /// DataGuardGroup parameter set
        ///
        /// [GraphQL: oracleDataGuardGroup]
        /// </summary>
        [Parameter(
            ParameterSetName = "DataGuardGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"An Oracle Data Guard Group.
[GraphQL: oracleDataGuardGroup]",
            Position = 0
        )]
        public SwitchParameter DataGuardGroup { get; set; }

        
        /// <summary>
        /// Database parameter set
        ///
        /// [GraphQL: oracleDatabase]
        /// </summary>
        [Parameter(
            ParameterSetName = "Database",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"An Oracle Database.
[GraphQL: oracleDatabase]",
            Position = 0
        )]
        public SwitchParameter Database { get; set; }

        
        /// <summary>
        /// LiveMounts parameter set
        ///
        /// [GraphQL: oracleLiveMounts]
        /// </summary>
        [Parameter(
            ParameterSetName = "LiveMounts",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Paginated list of Oracle Live Mounts.
[GraphQL: oracleLiveMounts]",
            Position = 0
        )]
        public SwitchParameter LiveMounts { get; set; }

        
        /// <summary>
        /// AcoParameters parameter set
        ///
        /// [GraphQL: oracleAcoParameters]
        /// </summary>
        [Parameter(
            ParameterSetName = "AcoParameters",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"List of supported Advanced Cloning Options

Supported in v6.0+
Get the list of supported Advanced Cloning Options (ACO) parameters.
[GraphQL: oracleAcoParameters]",
            Position = 0
        )]
        public SwitchParameter AcoParameters { get; set; }

        
        /// <summary>
        /// RecoverableRanges parameter set
        ///
        /// [GraphQL: oracleRecoverableRanges]
        /// </summary>
        [Parameter(
            ParameterSetName = "RecoverableRanges",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get recoverable ranges of a Oracle database

Supported in v5.0+
Retrieve the recoverable ranges for a specified Oracle database. A begin and/or end timestamp can be provided to retrieve only the ranges that fall within the window.
[GraphQL: oracleRecoverableRanges]",
            Position = 0
        )]
        public SwitchParameter RecoverableRanges { get; set; }

        
        /// <summary>
        /// MissedRecoverableRanges parameter set
        ///
        /// [GraphQL: oracleMissedRecoverableRanges]
        /// </summary>
        [Parameter(
            ParameterSetName = "MissedRecoverableRanges",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get missed recoverable ranges of a Oracle database

Supported in v5.0+
Retrieve a list of missed recoverable ranges for a Oracle database. For each run of one type of error, the first and last occurrence of the error are given.
[GraphQL: oracleMissedRecoverableRanges]",
            Position = 0
        )]
        public SwitchParameter MissedRecoverableRanges { get; set; }

        
        /// <summary>
        /// MissedSnapshots parameter set
        ///
        /// [GraphQL: oracleMissedSnapshots]
        /// </summary>
        [Parameter(
            ParameterSetName = "MissedSnapshots",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get missed snapshots for an Oracle database

Supported in v5.0+
Retrieve summary information about the missed snapshots of an Oracle database.
[GraphQL: oracleMissedSnapshots]",
            Position = 0
        )]
        public SwitchParameter MissedSnapshots { get; set; }

        
        /// <summary>
        /// AcoExampleDownloadLink parameter set
        ///
        /// [GraphQL: oracleAcoExampleDownloadLink]
        /// </summary>
        [Parameter(
            ParameterSetName = "AcoExampleDownloadLink",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Link to download the Advanced Recovery Options example file

Supported in v5.3+
Link to download the Advanced Recovery Options example file which can be used to customize Oracle recoveries.
[GraphQL: oracleAcoExampleDownloadLink]",
            Position = 0
        )]
        public SwitchParameter AcoExampleDownloadLink { get; set; }

        
        /// <summary>
        /// PdbDetails parameter set
        ///
        /// [GraphQL: oraclePdbDetails]
        /// </summary>
        [Parameter(
            ParameterSetName = "PdbDetails",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Get PDB details

Supported in v8.0+
Retrieves information about available pluggable databases (PDBs) for a given recovery point.
[GraphQL: oraclePdbDetails]",
            Position = 0
        )]
        public SwitchParameter PdbDetails { get; set; }

        
        /// <summary>
        /// HostLogBackupConfig parameter set
        ///
        /// [GraphQL: oracleHostLogBackupConfig]
        /// </summary>
        [Parameter(
            ParameterSetName = "HostLogBackupConfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Oracle Log backup configuration for Oracle Host.
[GraphQL: oracleHostLogBackupConfig]",
            Position = 0
        )]
        public SwitchParameter HostLogBackupConfig { get; set; }

        
        /// <summary>
        /// DatabaseLogBackupConfig parameter set
        ///
        /// [GraphQL: oracleDatabaseLogBackupConfig]
        /// </summary>
        [Parameter(
            ParameterSetName = "DatabaseLogBackupConfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Oracle log backup configuration for an Oracle Database.
[GraphQL: oracleDatabaseLogBackupConfig]",
            Position = 0
        )]
        public SwitchParameter DatabaseLogBackupConfig { get; set; }

        
        /// <summary>
        /// RacLogBackupConfig parameter set
        ///
        /// [GraphQL: oracleRacLogBackupConfig]
        /// </summary>
        [Parameter(
            ParameterSetName = "RacLogBackupConfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Oracle log backup configuration for an Oracle RAC.
[GraphQL: oracleRacLogBackupConfig]",
            Position = 0
        )]
        public SwitchParameter RacLogBackupConfig { get; set; }


// ignore warning 'Missing XML comment'
#pragma warning disable 1591
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(Op)
                {
                    case "TopLevelDescendants":
                        this.ProcessRecord_TopLevelDescendants();
                        break;
                    case "Databases":
                        this.ProcessRecord_Databases();
                        break;
                    case "Host":
                        this.ProcessRecord_Host();
                        break;
                    case "Rac":
                        this.ProcessRecord_Rac();
                        break;
                    case "DataGuardGroup":
                        this.ProcessRecord_DataGuardGroup();
                        break;
                    case "Database":
                        this.ProcessRecord_Database();
                        break;
                    case "LiveMounts":
                        this.ProcessRecord_LiveMounts();
                        break;
                    case "AcoParameters":
                        this.ProcessRecord_AcoParameters();
                        break;
                    case "RecoverableRanges":
                        this.ProcessRecord_RecoverableRanges();
                        break;
                    case "MissedRecoverableRanges":
                        this.ProcessRecord_MissedRecoverableRanges();
                        break;
                    case "MissedSnapshots":
                        this.ProcessRecord_MissedSnapshots();
                        break;
                    case "AcoExampleDownloadLink":
                        this.ProcessRecord_AcoExampleDownloadLink();
                        break;
                    case "PdbDetails":
                        this.ProcessRecord_PdbDetails();
                        break;
                    case "HostLogBackupConfig":
                        this.ProcessRecord_HostLogBackupConfig();
                        break;
                    case "DatabaseLogBackupConfig":
                        this.ProcessRecord_DatabaseLogBackupConfig();
                        break;
                    case "RacLogBackupConfig":
                        this.ProcessRecord_RacLogBackupConfig();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }
#pragma warning restore 1591

        // This parameter set invokes a single graphql operation:
        // oracleTopLevelDescendants.
        internal void ProcessRecord_TopLevelDescendants()
        {
            this._logger.name += " -TopLevelDescendants";
            // Create new graphql operation oracleTopLevelDescendants
            InitQueryOracleTopLevelDescendants();
        }

        // This parameter set invokes a single graphql operation:
        // oracleDatabases.
        internal void ProcessRecord_Databases()
        {
            this._logger.name += " -Databases";
            // Create new graphql operation oracleDatabases
            InitQueryOracleDatabases();
        }

        // This parameter set invokes a single graphql operation:
        // oracleHost.
        internal void ProcessRecord_Host()
        {
            this._logger.name += " -Host";
            // Create new graphql operation oracleHost
            InitQueryOracleHost();
        }

        // This parameter set invokes a single graphql operation:
        // oracleRac.
        internal void ProcessRecord_Rac()
        {
            this._logger.name += " -Rac";
            // Create new graphql operation oracleRac
            InitQueryOracleRac();
        }

        // This parameter set invokes a single graphql operation:
        // oracleDataGuardGroup.
        internal void ProcessRecord_DataGuardGroup()
        {
            this._logger.name += " -DataGuardGroup";
            // Create new graphql operation oracleDataGuardGroup
            InitQueryOracleDataGuardGroup();
        }

        // This parameter set invokes a single graphql operation:
        // oracleDatabase.
        internal void ProcessRecord_Database()
        {
            this._logger.name += " -Database";
            // Create new graphql operation oracleDatabase
            InitQueryOracleDatabase();
        }

        // This parameter set invokes a single graphql operation:
        // oracleLiveMounts.
        internal void ProcessRecord_LiveMounts()
        {
            this._logger.name += " -LiveMounts";
            // Create new graphql operation oracleLiveMounts
            InitQueryOracleLiveMounts();
        }

        // This parameter set invokes a single graphql operation:
        // oracleAcoParameters.
        internal void ProcessRecord_AcoParameters()
        {
            this._logger.name += " -AcoParameters";
            // Create new graphql operation oracleAcoParameters
            InitQueryOracleAcoParameters();
        }

        // This parameter set invokes a single graphql operation:
        // oracleRecoverableRanges.
        internal void ProcessRecord_RecoverableRanges()
        {
            this._logger.name += " -RecoverableRanges";
            // Create new graphql operation oracleRecoverableRanges
            InitQueryOracleRecoverableRanges();
        }

        // This parameter set invokes a single graphql operation:
        // oracleMissedRecoverableRanges.
        internal void ProcessRecord_MissedRecoverableRanges()
        {
            this._logger.name += " -MissedRecoverableRanges";
            // Create new graphql operation oracleMissedRecoverableRanges
            InitQueryOracleMissedRecoverableRanges();
        }

        // This parameter set invokes a single graphql operation:
        // oracleMissedSnapshots.
        internal void ProcessRecord_MissedSnapshots()
        {
            this._logger.name += " -MissedSnapshots";
            // Create new graphql operation oracleMissedSnapshots
            InitQueryOracleMissedSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // oracleAcoExampleDownloadLink.
        internal void ProcessRecord_AcoExampleDownloadLink()
        {
            this._logger.name += " -AcoExampleDownloadLink";
            // Create new graphql operation oracleAcoExampleDownloadLink
            InitQueryOracleAcoExampleDownloadLink();
        }

        // This parameter set invokes a single graphql operation:
        // oraclePdbDetails.
        internal void ProcessRecord_PdbDetails()
        {
            this._logger.name += " -PdbDetails";
            // Create new graphql operation oraclePdbDetails
            InitQueryOraclePdbDetails();
        }

        // This parameter set invokes a single graphql operation:
        // oracleHostLogBackupConfig.
        internal void ProcessRecord_HostLogBackupConfig()
        {
            this._logger.name += " -HostLogBackupConfig";
            // Create new graphql operation oracleHostLogBackupConfig
            InitQueryOracleHostLogBackupConfig();
        }

        // This parameter set invokes a single graphql operation:
        // oracleDatabaseLogBackupConfig.
        internal void ProcessRecord_DatabaseLogBackupConfig()
        {
            this._logger.name += " -DatabaseLogBackupConfig";
            // Create new graphql operation oracleDatabaseLogBackupConfig
            InitQueryOracleDatabaseLogBackupConfig();
        }

        // This parameter set invokes a single graphql operation:
        // oracleRacLogBackupConfig.
        internal void ProcessRecord_RacLogBackupConfig()
        {
            this._logger.name += " -RacLogBackupConfig";
            // Create new graphql operation oracleRacLogBackupConfig
            InitQueryOracleRacLogBackupConfig();
        }


        // Create new GraphQL Query:
        // oracleTopLevelDescendants(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     typeFilter: [HierarchyObjectTypeEnum!]
        //     filter: [Filter!]
        //   ): OracleTopLevelDescendantTypeConnection!
        internal void InitQueryOracleTopLevelDescendants()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("typeFilter", "[HierarchyObjectTypeEnum!]"),
                Tuple.Create("filter", "[Filter!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleTopLevelDescendants",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$typeFilter: [HierarchyObjectTypeEnum!],$filter: [Filter!])",
                "OracleTopLevelDescendantTypeConnection",
                Query.OracleTopLevelDescendants_ObjectFieldSpec,
                Query.OracleTopLevelDescendantsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.typeFilter = @(
	<HierarchyObjectTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
)
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // oracleDatabases(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): OracleDatabaseConnection!
        internal void InitQueryOracleDatabases()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleDatabases",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "OracleDatabaseConnection",
                Query.OracleDatabases_ObjectFieldSpec,
                Query.OracleDatabasesFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // oracleHost(fid: UUID!): OracleHost!
        internal void InitQueryOracleHost()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleHost",
                "($fid: UUID!)",
                "OracleHost",
                Query.OracleHost_ObjectFieldSpec,
                Query.OracleHostFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // oracleRac(fid: UUID!): OracleRac!
        internal void InitQueryOracleRac()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleRac",
                "($fid: UUID!)",
                "OracleRac",
                Query.OracleRac_ObjectFieldSpec,
                Query.OracleRacFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // oracleDataGuardGroup(fid: UUID!): OracleDataGuardGroup!
        internal void InitQueryOracleDataGuardGroup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleDataGuardGroup",
                "($fid: UUID!)",
                "OracleDataGuardGroup",
                Query.OracleDataGuardGroup_ObjectFieldSpec,
                Query.OracleDataGuardGroupFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // oracleDatabase(fid: UUID!): OracleDatabase!
        internal void InitQueryOracleDatabase()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleDatabase",
                "($fid: UUID!)",
                "OracleDatabase",
                Query.OracleDatabase_ObjectFieldSpec,
                Query.OracleDatabaseFieldSpec,
                @"# REQUIRED
$inputs.Var.fid = <System.String>"
            );
        }

        // Create new GraphQL Query:
        // oracleLiveMounts(
        //     first: Int
        //     after: String
        //     filters: [OracleLiveMountFilterInput!]
        //     sortBy: OracleLiveMountSortBy
        //   ): OracleLiveMountConnection!
        internal void InitQueryOracleLiveMounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("filters", "[OracleLiveMountFilterInput!]"),
                Tuple.Create("sortBy", "OracleLiveMountSortBy"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleLiveMounts",
                "($first: Int,$after: String,$filters: [OracleLiveMountFilterInput!],$sortBy: OracleLiveMountSortBy)",
                "OracleLiveMountConnection",
                Query.OracleLiveMounts_ObjectFieldSpec,
                Query.OracleLiveMountsFieldSpec,
                @"# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.filters = @(
	@{
		# OPTIONAL
		field = <OracleLiveMountFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OracleLiveMountFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
}
)
# OPTIONAL
$inputs.Var.sortBy = @{
	# OPTIONAL
	field = <OracleLiveMountSortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OracleLiveMountSortByField]) for enum values.
	# OPTIONAL
	sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}"
            );
        }

        // Create new GraphQL Query:
        // oracleAcoParameters(input: ClusterUuidWithDbIdInput!): OracleAcoParameterList!
        internal void InitQueryOracleAcoParameters()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterUuidWithDbIdInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleAcoParameters",
                "($input: ClusterUuidWithDbIdInput!)",
                "OracleAcoParameterList",
                Query.OracleAcoParameters_ObjectFieldSpec,
                Query.OracleAcoParametersFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	dbId = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // oracleRecoverableRanges(input: GetOracleDbRecoverableRangesInput!): OracleRecoverableRangeListResponse!
        internal void InitQueryOracleRecoverableRanges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetOracleDbRecoverableRangesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleRecoverableRanges",
                "($input: GetOracleDbRecoverableRangesInput!)",
                "OracleRecoverableRangeListResponse",
                Query.OracleRecoverableRanges_ObjectFieldSpec,
                Query.OracleRecoverableRangesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	afterTime = <DateTime>
	# OPTIONAL
	beforeTime = <DateTime>
	# OPTIONAL
	shouldIncludeDbSnapshotSummaries = <System.Boolean>
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // oracleMissedRecoverableRanges(input: GetOracleDbMissedRecoverableRangesInput!): OracleMissedRecoverableRangeListResponse!
        internal void InitQueryOracleMissedRecoverableRanges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetOracleDbMissedRecoverableRangesInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleMissedRecoverableRanges",
                "($input: GetOracleDbMissedRecoverableRangesInput!)",
                "OracleMissedRecoverableRangeListResponse",
                Query.OracleMissedRecoverableRanges_ObjectFieldSpec,
                Query.OracleMissedRecoverableRangesFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	afterTime = <DateTime>
	# OPTIONAL
	beforeTime = <DateTime>
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // oracleMissedSnapshots(input: GetMissedOracleDbSnapshotsInput!): MissedSnapshotListResponse!
        internal void InitQueryOracleMissedSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMissedOracleDbSnapshotsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleMissedSnapshots",
                "($input: GetMissedOracleDbSnapshotsInput!)",
                "MissedSnapshotListResponse",
                Query.OracleMissedSnapshots_ObjectFieldSpec,
                Query.OracleMissedSnapshotsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	afterTime = <DateTime>
	# OPTIONAL
	beforeTime = <DateTime>
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // oracleAcoExampleDownloadLink(input: ClusterUuidWithDbIdInput!): OracleFileDownloadLink!
        internal void InitQueryOracleAcoExampleDownloadLink()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterUuidWithDbIdInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleAcoExampleDownloadLink",
                "($input: ClusterUuidWithDbIdInput!)",
                "OracleFileDownloadLink",
                Query.OracleAcoExampleDownloadLink_ObjectFieldSpec,
                Query.OracleAcoExampleDownloadLinkFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	dbId = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // oraclePdbDetails(input: OraclePdbDetailsInput!): OraclePdbDetails!
        internal void InitQueryOraclePdbDetails()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "OraclePdbDetailsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOraclePdbDetails",
                "($input: OraclePdbDetailsInput!)",
                "OraclePdbDetails",
                Query.OraclePdbDetails_ObjectFieldSpec,
                Query.OraclePdbDetailsFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	pdbDetailsRequest = @{
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			snapshotId = <System.String>
			# OPTIONAL
			timestampMs = <System.Int64>
		}
	}
}"
            );
        }

        // Create new GraphQL Query:
        // oracleHostLogBackupConfig(input: OracleHostInput!): OracleLogBackupConfig!
        internal void InitQueryOracleHostLogBackupConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "OracleHostInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleHostLogBackupConfig",
                "($input: OracleHostInput!)",
                "OracleLogBackupConfig",
                Query.OracleHostLogBackupConfig_ObjectFieldSpec,
                Query.OracleHostLogBackupConfigFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // oracleDatabaseLogBackupConfig(input: OracleDbInput!): OracleLogBackupConfig!
        internal void InitQueryOracleDatabaseLogBackupConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "OracleDbInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleDatabaseLogBackupConfig",
                "($input: OracleDbInput!)",
                "OracleLogBackupConfig",
                Query.OracleDatabaseLogBackupConfig_ObjectFieldSpec,
                Query.OracleDatabaseLogBackupConfigFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }

        // Create new GraphQL Query:
        // oracleRacLogBackupConfig(input: OracleRacInput!): OracleLogBackupConfig!
        internal void InitQueryOracleRacLogBackupConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "OracleRacInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryOracleRacLogBackupConfig",
                "($input: OracleRacInput!)",
                "OracleLogBackupConfig",
                Query.OracleRacLogBackupConfig_ObjectFieldSpec,
                Query.OracleRacLogBackupConfigFieldSpec,
                @"# REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}"
            );
        }


    } // class New_RscQueryOracle
}