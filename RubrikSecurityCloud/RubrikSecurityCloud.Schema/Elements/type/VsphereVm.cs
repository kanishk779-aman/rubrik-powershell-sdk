// VsphereVm.cs
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
    #region VsphereVm
 
    public class VsphereVm: BaseType, CdmHierarchyObject, CdmHierarchySnappableNew, HierarchyObject, HierarchySnappable, VcdDescendantType, VcdLogicalChildType, VcdOrgDescendantType, VcdOrgLogicalChildType, VcdOrgVdcDescendantType, VcdOrgVdcLogicalChildType, VcdTopLevelDescendantType, VcdVappDescendantType, VcdVappLogicalChildType, VsphereComputeClusterDescendantType, VsphereDatacenterDescendantType, VsphereFolderDescendantType, VsphereFolderLogicalChildType, VsphereHostDescendantType, VsphereHostPhysicalChildType, VsphereTagCategoryDescendantType, VsphereTagDescendantType, VsphereTagTagChildType, VsphereVcenterDescendantType
    {
        #region members

        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<Operation>? AuthorizedOperations { get; set; }

        //      C# -> GuestCredentialAuthorizationStatus? GuestCredentialAuthorizationStatus
        // GraphQL -> guestCredentialAuthorizationStatus: GuestCredentialAuthorizationStatus! (enum)
        [JsonProperty("guestCredentialAuthorizationStatus")]
        public GuestCredentialAuthorizationStatus? GuestCredentialAuthorizationStatus { get; set; }

        //      C# -> GuestOsType? GuestOsType
        // GraphQL -> guestOsType: GuestOsType! (enum)
        [JsonProperty("guestOsType")]
        public GuestOsType? GuestOsType { get; set; }

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

        //      C# -> VmPowerStatus? PowerStatus
        // GraphQL -> powerStatus: VmPowerStatus (enum)
        [JsonProperty("powerStatus")]
        public VmPowerStatus? PowerStatus { get; set; }

        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        [JsonProperty("slaAssignment")]
        public SlaAssignmentTypeEnum? SlaAssignment { get; set; }

        //      C# -> ConsistencyLevelEnum? SnapshotConsistencyMandate
        // GraphQL -> snapshotConsistencyMandate: ConsistencyLevelEnum! (enum)
        [JsonProperty("snapshotConsistencyMandate")]
        public ConsistencyLevelEnum? SnapshotConsistencyMandate { get; set; }

        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        [JsonProperty("configuredSlaDomain")]
        public SlaDomain? ConfiguredSlaDomain { get; set; }

        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        [JsonProperty("effectiveRetentionSlaDomain")]
        public SlaDomain? EffectiveRetentionSlaDomain { get; set; }

        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        [JsonProperty("effectiveSlaDomain")]
        public SlaDomain? EffectiveSlaDomain { get; set; }

        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        [JsonProperty("pendingSla")]
        public SlaDomain? PendingSla { get; set; }

        //      C# -> List<CdmHierarchyObject>? ReplicatedObjects
        // GraphQL -> replicatedObjects: [CdmHierarchyObject!]! (interface)
        [JsonProperty("replicatedObjects")]
        public List<CdmHierarchyObject>? ReplicatedObjects { get; set; }

        //      C# -> System.Boolean? ArrayIntegrationEnabled
        // GraphQL -> arrayIntegrationEnabled: Boolean! (scalar)
        [JsonProperty("arrayIntegrationEnabled")]
        public System.Boolean? ArrayIntegrationEnabled { get; set; }

        //      C# -> System.String? BlueprintId
        // GraphQL -> blueprintId: String (scalar)
        [JsonProperty("blueprintId")]
        public System.String? BlueprintId { get; set; }

        //      C# -> System.String? BlueprintName
        // GraphQL -> blueprintName: String (scalar)
        [JsonProperty("blueprintName")]
        public System.String? BlueprintName { get; set; }

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? CdmLink
        // GraphQL -> cdmLink: String! (scalar)
        [JsonProperty("cdmLink")]
        public System.String? CdmLink { get; set; }

        //      C# -> System.String? GuestCredentialId
        // GraphQL -> guestCredentialId: String! (scalar)
        [JsonProperty("guestCredentialId")]
        public System.String? GuestCredentialId { get; set; }

        //      C# -> System.String? GuestOsName
        // GraphQL -> guestOsName: String! (scalar)
        [JsonProperty("guestOsName")]
        public System.String? GuestOsName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        [JsonProperty("isActive")]
        public System.Boolean? IsActive { get; set; }

        //      C# -> System.Boolean? IsArrayIntegrationPossible
        // GraphQL -> isArrayIntegrationPossible: Boolean! (scalar)
        [JsonProperty("isArrayIntegrationPossible")]
        public System.Boolean? IsArrayIntegrationPossible { get; set; }

        //      C# -> System.Boolean? IsBlueprintChild
        // GraphQL -> isBlueprintChild: Boolean! (scalar)
        [JsonProperty("isBlueprintChild")]
        public System.Boolean? IsBlueprintChild { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        [JsonProperty("numWorkloadDescendants")]
        public System.Int32? NumWorkloadDescendants { get; set; }

        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        [JsonProperty("onDemandSnapshotCount")]
        public System.Int32? OnDemandSnapshotCount { get; set; }

        //      C# -> System.String? ParentWorkloadIdOpt
        // GraphQL -> parentWorkloadIdOpt: UUID (scalar)
        [JsonProperty("parentWorkloadIdOpt")]
        public System.String? ParentWorkloadIdOpt { get; set; }

        //      C# -> System.String? ParentWorkloadTypeOpt
        // GraphQL -> parentWorkloadTypeOpt: String (scalar)
        [JsonProperty("parentWorkloadTypeOpt")]
        public System.String? ParentWorkloadTypeOpt { get; set; }

        //      C# -> DateTime? ProtectionDate
        // GraphQL -> protectionDate: DateTime (scalar)
        [JsonProperty("protectionDate")]
        public DateTime? ProtectionDate { get; set; }

        //      C# -> System.Int32? ReplicatedObjectCount
        // GraphQL -> replicatedObjectCount: Int! (scalar)
        [JsonProperty("replicatedObjectCount")]
        public System.Int32? ReplicatedObjectCount { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> System.Boolean? VmwareToolsInstalled
        // GraphQL -> vmwareToolsInstalled: Boolean! (scalar)
        [JsonProperty("vmwareToolsInstalled")]
        public System.Boolean? VmwareToolsInstalled { get; set; }

        //      C# -> AgentStatus? AgentStatus
        // GraphQL -> agentStatus: AgentStatus (type)
        [JsonProperty("agentStatus")]
        public AgentStatus? AgentStatus { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> List<DuplicatedVm>? DuplicatedVms
        // GraphQL -> duplicatedVms: [DuplicatedVm!]! (type)
        [JsonProperty("duplicatedVms")]
        public List<DuplicatedVm>? DuplicatedVms { get; set; }

        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        [JsonProperty("effectiveSlaSourceObject")]
        public PathNode? EffectiveSlaSourceObject { get; set; }

        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        [JsonProperty("latestUserNote")]
        public LatestUserNote? LatestUserNote { get; set; }

        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        [JsonProperty("logicalPath")]
        public List<PathNode>? LogicalPath { get; set; }

        //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
        // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection (type)
        [JsonProperty("missedSnapshotConnection")]
        public MissedSnapshotCommonConnection? MissedSnapshotConnection { get; set; }

        //      C# -> MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection
        // GraphQL -> missedSnapshotGroupByConnection: MissedSnapshotGroupByConnection (type)
        [JsonProperty("missedSnapshotGroupByConnection")]
        public MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection { get; set; }

        //      C# -> CdmSnapshot? NewestArchivedSnapshot
        // GraphQL -> newestArchivedSnapshot: CdmSnapshot (type)
        [JsonProperty("newestArchivedSnapshot")]
        public CdmSnapshot? NewestArchivedSnapshot { get; set; }

        //      C# -> CdmSnapshot? NewestReplicatedSnapshot
        // GraphQL -> newestReplicatedSnapshot: CdmSnapshot (type)
        [JsonProperty("newestReplicatedSnapshot")]
        public CdmSnapshot? NewestReplicatedSnapshot { get; set; }

        //      C# -> CdmSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: CdmSnapshot (type)
        [JsonProperty("newestSnapshot")]
        public CdmSnapshot? NewestSnapshot { get; set; }

        //      C# -> CdmSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: CdmSnapshot (type)
        [JsonProperty("oldestSnapshot")]
        public CdmSnapshot? OldestSnapshot { get; set; }

        //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
        // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
        [JsonProperty("pendingObjectDeletionStatus")]
        public PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus { get; set; }

        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        [JsonProperty("physicalPath")]
        public List<PathNode>? PhysicalPath { get; set; }

        //      C# -> PrePostScript? PostBackupScript
        // GraphQL -> postBackupScript: PrePostScript (type)
        [JsonProperty("postBackupScript")]
        public PrePostScript? PostBackupScript { get; set; }

        //      C# -> PrePostScript? PostSnapScript
        // GraphQL -> postSnapScript: PrePostScript (type)
        [JsonProperty("postSnapScript")]
        public PrePostScript? PostSnapScript { get; set; }

        //      C# -> PrePostScript? PreBackupScript
        // GraphQL -> preBackupScript: PrePostScript (type)
        [JsonProperty("preBackupScript")]
        public PrePostScript? PreBackupScript { get; set; }

        //      C# -> DataLocation? PrimaryClusterLocation
        // GraphQL -> primaryClusterLocation: DataLocation! (type)
        [JsonProperty("primaryClusterLocation")]
        public DataLocation? PrimaryClusterLocation { get; set; }

        //      C# -> Snappable? ReportWorkload
        // GraphQL -> reportWorkload: Snappable (type)
        [JsonProperty("reportWorkload")]
        public Snappable? ReportWorkload { get; set; }

        //      C# -> CdmSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: CdmSnapshotConnection (type)
        [JsonProperty("snapshotConnection")]
        public CdmSnapshotConnection? SnapshotConnection { get; set; }

        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        [JsonProperty("snapshotDistribution")]
        public SnapshotDistribution? SnapshotDistribution { get; set; }

        //      C# -> CdmSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: CdmSnapshotGroupByConnection (type)
        [JsonProperty("snapshotGroupByConnection")]
        public CdmSnapshotGroupByConnection? SnapshotGroupByConnection { get; set; }

        //      C# -> CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary
        // GraphQL -> snapshotGroupBySummary: CdmSnapshotGroupBySummaryConnection (type)
        [JsonProperty("snapshotGroupBySummary")]
        public CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary { get; set; }

        //      C# -> VsphereLiveMountConnection? VsphereLiveMounts
        // GraphQL -> vSphereLiveMounts: VsphereLiveMountConnection! (type)
        [JsonProperty("vSphereLiveMounts")]
        public VsphereLiveMountConnection? VsphereLiveMounts { get; set; }

        //      C# -> VsphereMountConnection? VsphereMounts
        // GraphQL -> vSphereMounts: VsphereMountConnection! (type)
        [JsonProperty("vSphereMounts")]
        public VsphereMountConnection? VsphereMounts { get; set; }

        //      C# -> List<PathNode>? VsphereTagPath
        // GraphQL -> vsphereTagPath: [PathNode!]! (type)
        [JsonProperty("vsphereTagPath")]
        public List<PathNode>? VsphereTagPath { get; set; }

        //      C# -> VsphereVirtualDiskConnection? VsphereVirtualDisks
        // GraphQL -> vsphereVirtualDisks: VsphereVirtualDiskConnection! (type)
        [JsonProperty("vsphereVirtualDisks")]
        public VsphereVirtualDiskConnection? VsphereVirtualDisks { get; set; }


        #endregion

    #region methods

    public VsphereVm Set(
        List<Operation>? AuthorizedOperations = null,
        GuestCredentialAuthorizationStatus? GuestCredentialAuthorizationStatus = null,
        GuestOsType? GuestOsType = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        VmPowerStatus? PowerStatus = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        ConsistencyLevelEnum? SnapshotConsistencyMandate = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null,
        SlaDomain? PendingSla = null,
        List<CdmHierarchyObject>? ReplicatedObjects = null,
        System.Boolean? ArrayIntegrationEnabled = null,
        System.String? BlueprintId = null,
        System.String? BlueprintName = null,
        System.String? CdmId = null,
        System.String? CdmLink = null,
        System.String? GuestCredentialId = null,
        System.String? GuestOsName = null,
        System.String? Id = null,
        System.Boolean? IsActive = null,
        System.Boolean? IsArrayIntegrationPossible = null,
        System.Boolean? IsBlueprintChild = null,
        System.Boolean? IsRelic = null,
        System.String? Name = null,
        System.Int32? NumWorkloadDescendants = null,
        System.Int32? OnDemandSnapshotCount = null,
        System.String? ParentWorkloadIdOpt = null,
        System.String? ParentWorkloadTypeOpt = null,
        DateTime? ProtectionDate = null,
        System.Int32? ReplicatedObjectCount = null,
        System.Boolean? SlaPauseStatus = null,
        System.Boolean? VmwareToolsInstalled = null,
        AgentStatus? AgentStatus = null,
        List<Org>? AllOrgs = null,
        Cluster? Cluster = null,
        List<DuplicatedVm>? DuplicatedVms = null,
        PathNode? EffectiveSlaSourceObject = null,
        LatestUserNote? LatestUserNote = null,
        List<PathNode>? LogicalPath = null,
        MissedSnapshotCommonConnection? MissedSnapshotConnection = null,
        MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection = null,
        CdmSnapshot? NewestArchivedSnapshot = null,
        CdmSnapshot? NewestReplicatedSnapshot = null,
        CdmSnapshot? NewestSnapshot = null,
        CdmSnapshot? OldestSnapshot = null,
        PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus = null,
        List<PathNode>? PhysicalPath = null,
        PrePostScript? PostBackupScript = null,
        PrePostScript? PostSnapScript = null,
        PrePostScript? PreBackupScript = null,
        DataLocation? PrimaryClusterLocation = null,
        Snappable? ReportWorkload = null,
        CdmSnapshotConnection? SnapshotConnection = null,
        SnapshotDistribution? SnapshotDistribution = null,
        CdmSnapshotGroupByConnection? SnapshotGroupByConnection = null,
        CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary = null,
        VsphereLiveMountConnection? VsphereLiveMounts = null,
        VsphereMountConnection? VsphereMounts = null,
        List<PathNode>? VsphereTagPath = null,
        VsphereVirtualDiskConnection? VsphereVirtualDisks = null
    ) 
    {
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( GuestCredentialAuthorizationStatus != null ) {
            this.GuestCredentialAuthorizationStatus = GuestCredentialAuthorizationStatus;
        }
        if ( GuestOsType != null ) {
            this.GuestOsType = GuestOsType;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( PowerStatus != null ) {
            this.PowerStatus = PowerStatus;
        }
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
        }
        if ( SnapshotConsistencyMandate != null ) {
            this.SnapshotConsistencyMandate = SnapshotConsistencyMandate;
        }
        if ( ConfiguredSlaDomain != null ) {
            this.ConfiguredSlaDomain = ConfiguredSlaDomain;
        }
        if ( EffectiveRetentionSlaDomain != null ) {
            this.EffectiveRetentionSlaDomain = EffectiveRetentionSlaDomain;
        }
        if ( EffectiveSlaDomain != null ) {
            this.EffectiveSlaDomain = EffectiveSlaDomain;
        }
        if ( PendingSla != null ) {
            this.PendingSla = PendingSla;
        }
        if ( ReplicatedObjects != null ) {
            this.ReplicatedObjects = ReplicatedObjects;
        }
        if ( ArrayIntegrationEnabled != null ) {
            this.ArrayIntegrationEnabled = ArrayIntegrationEnabled;
        }
        if ( BlueprintId != null ) {
            this.BlueprintId = BlueprintId;
        }
        if ( BlueprintName != null ) {
            this.BlueprintName = BlueprintName;
        }
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( CdmLink != null ) {
            this.CdmLink = CdmLink;
        }
        if ( GuestCredentialId != null ) {
            this.GuestCredentialId = GuestCredentialId;
        }
        if ( GuestOsName != null ) {
            this.GuestOsName = GuestOsName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsActive != null ) {
            this.IsActive = IsActive;
        }
        if ( IsArrayIntegrationPossible != null ) {
            this.IsArrayIntegrationPossible = IsArrayIntegrationPossible;
        }
        if ( IsBlueprintChild != null ) {
            this.IsBlueprintChild = IsBlueprintChild;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumWorkloadDescendants != null ) {
            this.NumWorkloadDescendants = NumWorkloadDescendants;
        }
        if ( OnDemandSnapshotCount != null ) {
            this.OnDemandSnapshotCount = OnDemandSnapshotCount;
        }
        if ( ParentWorkloadIdOpt != null ) {
            this.ParentWorkloadIdOpt = ParentWorkloadIdOpt;
        }
        if ( ParentWorkloadTypeOpt != null ) {
            this.ParentWorkloadTypeOpt = ParentWorkloadTypeOpt;
        }
        if ( ProtectionDate != null ) {
            this.ProtectionDate = ProtectionDate;
        }
        if ( ReplicatedObjectCount != null ) {
            this.ReplicatedObjectCount = ReplicatedObjectCount;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( VmwareToolsInstalled != null ) {
            this.VmwareToolsInstalled = VmwareToolsInstalled;
        }
        if ( AgentStatus != null ) {
            this.AgentStatus = AgentStatus;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( DuplicatedVms != null ) {
            this.DuplicatedVms = DuplicatedVms;
        }
        if ( EffectiveSlaSourceObject != null ) {
            this.EffectiveSlaSourceObject = EffectiveSlaSourceObject;
        }
        if ( LatestUserNote != null ) {
            this.LatestUserNote = LatestUserNote;
        }
        if ( LogicalPath != null ) {
            this.LogicalPath = LogicalPath;
        }
        if ( MissedSnapshotConnection != null ) {
            this.MissedSnapshotConnection = MissedSnapshotConnection;
        }
        if ( MissedSnapshotGroupByConnection != null ) {
            this.MissedSnapshotGroupByConnection = MissedSnapshotGroupByConnection;
        }
        if ( NewestArchivedSnapshot != null ) {
            this.NewestArchivedSnapshot = NewestArchivedSnapshot;
        }
        if ( NewestReplicatedSnapshot != null ) {
            this.NewestReplicatedSnapshot = NewestReplicatedSnapshot;
        }
        if ( NewestSnapshot != null ) {
            this.NewestSnapshot = NewestSnapshot;
        }
        if ( OldestSnapshot != null ) {
            this.OldestSnapshot = OldestSnapshot;
        }
        if ( PendingObjectDeletionStatus != null ) {
            this.PendingObjectDeletionStatus = PendingObjectDeletionStatus;
        }
        if ( PhysicalPath != null ) {
            this.PhysicalPath = PhysicalPath;
        }
        if ( PostBackupScript != null ) {
            this.PostBackupScript = PostBackupScript;
        }
        if ( PostSnapScript != null ) {
            this.PostSnapScript = PostSnapScript;
        }
        if ( PreBackupScript != null ) {
            this.PreBackupScript = PreBackupScript;
        }
        if ( PrimaryClusterLocation != null ) {
            this.PrimaryClusterLocation = PrimaryClusterLocation;
        }
        if ( ReportWorkload != null ) {
            this.ReportWorkload = ReportWorkload;
        }
        if ( SnapshotConnection != null ) {
            this.SnapshotConnection = SnapshotConnection;
        }
        if ( SnapshotDistribution != null ) {
            this.SnapshotDistribution = SnapshotDistribution;
        }
        if ( SnapshotGroupByConnection != null ) {
            this.SnapshotGroupByConnection = SnapshotGroupByConnection;
        }
        if ( SnapshotGroupBySummary != null ) {
            this.SnapshotGroupBySummary = SnapshotGroupBySummary;
        }
        if ( VsphereLiveMounts != null ) {
            this.VsphereLiveMounts = VsphereLiveMounts;
        }
        if ( VsphereMounts != null ) {
            this.VsphereMounts = VsphereMounts;
        }
        if ( VsphereTagPath != null ) {
            this.VsphereTagPath = VsphereTagPath;
        }
        if ( VsphereVirtualDisks != null ) {
            this.VsphereVirtualDisks = VsphereVirtualDisks;
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
        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        if (this.AuthorizedOperations != null) {
            s += ind + "authorizedOperations\n" ;
        }
        //      C# -> GuestCredentialAuthorizationStatus? GuestCredentialAuthorizationStatus
        // GraphQL -> guestCredentialAuthorizationStatus: GuestCredentialAuthorizationStatus! (enum)
        if (this.GuestCredentialAuthorizationStatus != null) {
            s += ind + "guestCredentialAuthorizationStatus\n" ;
        }
        //      C# -> GuestOsType? GuestOsType
        // GraphQL -> guestOsType: GuestOsType! (enum)
        if (this.GuestOsType != null) {
            s += ind + "guestOsType\n" ;
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType != null) {
            s += ind + "objectType\n" ;
        }
        //      C# -> VmPowerStatus? PowerStatus
        // GraphQL -> powerStatus: VmPowerStatus (enum)
        if (this.PowerStatus != null) {
            s += ind + "powerStatus\n" ;
        }
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (this.SlaAssignment != null) {
            s += ind + "slaAssignment\n" ;
        }
        //      C# -> ConsistencyLevelEnum? SnapshotConsistencyMandate
        // GraphQL -> snapshotConsistencyMandate: ConsistencyLevelEnum! (enum)
        if (this.SnapshotConsistencyMandate != null) {
            s += ind + "snapshotConsistencyMandate\n" ;
        }
        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        if (this.ConfiguredSlaDomain != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.ConfiguredSlaDomain).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "configuredSlaDomain {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        if (this.EffectiveRetentionSlaDomain != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.EffectiveRetentionSlaDomain).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "effectiveRetentionSlaDomain {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (this.EffectiveSlaDomain != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.EffectiveSlaDomain).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "effectiveSlaDomain {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        if (this.PendingSla != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.PendingSla).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "pendingSla {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> List<CdmHierarchyObject>? ReplicatedObjects
        // GraphQL -> replicatedObjects: [CdmHierarchyObject!]! (interface)
        if (this.ReplicatedObjects != null) {
                var fspec = this.ReplicatedObjects.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "replicatedObjects {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.Boolean? ArrayIntegrationEnabled
        // GraphQL -> arrayIntegrationEnabled: Boolean! (scalar)
        if (this.ArrayIntegrationEnabled != null) {
            s += ind + "arrayIntegrationEnabled\n" ;
        }
        //      C# -> System.String? BlueprintId
        // GraphQL -> blueprintId: String (scalar)
        if (this.BlueprintId != null) {
            s += ind + "blueprintId\n" ;
        }
        //      C# -> System.String? BlueprintName
        // GraphQL -> blueprintName: String (scalar)
        if (this.BlueprintName != null) {
            s += ind + "blueprintName\n" ;
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId != null) {
            s += ind + "cdmId\n" ;
        }
        //      C# -> System.String? CdmLink
        // GraphQL -> cdmLink: String! (scalar)
        if (this.CdmLink != null) {
            s += ind + "cdmLink\n" ;
        }
        //      C# -> System.String? GuestCredentialId
        // GraphQL -> guestCredentialId: String! (scalar)
        if (this.GuestCredentialId != null) {
            s += ind + "guestCredentialId\n" ;
        }
        //      C# -> System.String? GuestOsName
        // GraphQL -> guestOsName: String! (scalar)
        if (this.GuestOsName != null) {
            s += ind + "guestOsName\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        if (this.IsActive != null) {
            s += ind + "isActive\n" ;
        }
        //      C# -> System.Boolean? IsArrayIntegrationPossible
        // GraphQL -> isArrayIntegrationPossible: Boolean! (scalar)
        if (this.IsArrayIntegrationPossible != null) {
            s += ind + "isArrayIntegrationPossible\n" ;
        }
        //      C# -> System.Boolean? IsBlueprintChild
        // GraphQL -> isBlueprintChild: Boolean! (scalar)
        if (this.IsBlueprintChild != null) {
            s += ind + "isBlueprintChild\n" ;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            s += ind + "isRelic\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        if (this.NumWorkloadDescendants != null) {
            s += ind + "numWorkloadDescendants\n" ;
        }
        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        if (this.OnDemandSnapshotCount != null) {
            s += ind + "onDemandSnapshotCount\n" ;
        }
        //      C# -> System.String? ParentWorkloadIdOpt
        // GraphQL -> parentWorkloadIdOpt: UUID (scalar)
        if (this.ParentWorkloadIdOpt != null) {
            s += ind + "parentWorkloadIdOpt\n" ;
        }
        //      C# -> System.String? ParentWorkloadTypeOpt
        // GraphQL -> parentWorkloadTypeOpt: String (scalar)
        if (this.ParentWorkloadTypeOpt != null) {
            s += ind + "parentWorkloadTypeOpt\n" ;
        }
        //      C# -> DateTime? ProtectionDate
        // GraphQL -> protectionDate: DateTime (scalar)
        if (this.ProtectionDate != null) {
            s += ind + "protectionDate\n" ;
        }
        //      C# -> System.Int32? ReplicatedObjectCount
        // GraphQL -> replicatedObjectCount: Int! (scalar)
        if (this.ReplicatedObjectCount != null) {
            s += ind + "replicatedObjectCount\n" ;
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (this.SlaPauseStatus != null) {
            s += ind + "slaPauseStatus\n" ;
        }
        //      C# -> System.Boolean? VmwareToolsInstalled
        // GraphQL -> vmwareToolsInstalled: Boolean! (scalar)
        if (this.VmwareToolsInstalled != null) {
            s += ind + "vmwareToolsInstalled\n" ;
        }
        //      C# -> AgentStatus? AgentStatus
        // GraphQL -> agentStatus: AgentStatus (type)
        if (this.AgentStatus != null) {
            var fspec = this.AgentStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "agentStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs != null) {
            var fspec = this.AllOrgs.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "allOrgs {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<DuplicatedVm>? DuplicatedVms
        // GraphQL -> duplicatedVms: [DuplicatedVm!]! (type)
        if (this.DuplicatedVms != null) {
            var fspec = this.DuplicatedVms.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "duplicatedVms {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (this.EffectiveSlaSourceObject != null) {
            var fspec = this.EffectiveSlaSourceObject.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "effectiveSlaSourceObject {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        if (this.LatestUserNote != null) {
            var fspec = this.LatestUserNote.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "latestUserNote {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (this.LogicalPath != null) {
            var fspec = this.LogicalPath.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "logicalPath {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
        // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection (type)
        if (this.MissedSnapshotConnection != null) {
            var fspec = this.MissedSnapshotConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "missedSnapshotConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection
        // GraphQL -> missedSnapshotGroupByConnection: MissedSnapshotGroupByConnection (type)
        if (this.MissedSnapshotGroupByConnection != null) {
            var fspec = this.MissedSnapshotGroupByConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "missedSnapshotGroupByConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CdmSnapshot? NewestArchivedSnapshot
        // GraphQL -> newestArchivedSnapshot: CdmSnapshot (type)
        if (this.NewestArchivedSnapshot != null) {
            var fspec = this.NewestArchivedSnapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "newestArchivedSnapshot {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CdmSnapshot? NewestReplicatedSnapshot
        // GraphQL -> newestReplicatedSnapshot: CdmSnapshot (type)
        if (this.NewestReplicatedSnapshot != null) {
            var fspec = this.NewestReplicatedSnapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "newestReplicatedSnapshot {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CdmSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: CdmSnapshot (type)
        if (this.NewestSnapshot != null) {
            var fspec = this.NewestSnapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "newestSnapshot {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CdmSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: CdmSnapshot (type)
        if (this.OldestSnapshot != null) {
            var fspec = this.OldestSnapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "oldestSnapshot {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
        // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
        if (this.PendingObjectDeletionStatus != null) {
            var fspec = this.PendingObjectDeletionStatus.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "pendingObjectDeletionStatus {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (this.PhysicalPath != null) {
            var fspec = this.PhysicalPath.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "physicalPath {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PrePostScript? PostBackupScript
        // GraphQL -> postBackupScript: PrePostScript (type)
        if (this.PostBackupScript != null) {
            var fspec = this.PostBackupScript.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "postBackupScript {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PrePostScript? PostSnapScript
        // GraphQL -> postSnapScript: PrePostScript (type)
        if (this.PostSnapScript != null) {
            var fspec = this.PostSnapScript.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "postSnapScript {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PrePostScript? PreBackupScript
        // GraphQL -> preBackupScript: PrePostScript (type)
        if (this.PreBackupScript != null) {
            var fspec = this.PreBackupScript.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "preBackupScript {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> DataLocation? PrimaryClusterLocation
        // GraphQL -> primaryClusterLocation: DataLocation! (type)
        if (this.PrimaryClusterLocation != null) {
            var fspec = this.PrimaryClusterLocation.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "primaryClusterLocation {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Snappable? ReportWorkload
        // GraphQL -> reportWorkload: Snappable (type)
        if (this.ReportWorkload != null) {
            var fspec = this.ReportWorkload.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "reportWorkload {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CdmSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: CdmSnapshotConnection (type)
        if (this.SnapshotConnection != null) {
            var fspec = this.SnapshotConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution != null) {
            var fspec = this.SnapshotDistribution.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotDistribution {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CdmSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: CdmSnapshotGroupByConnection (type)
        if (this.SnapshotGroupByConnection != null) {
            var fspec = this.SnapshotGroupByConnection.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotGroupByConnection {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary
        // GraphQL -> snapshotGroupBySummary: CdmSnapshotGroupBySummaryConnection (type)
        if (this.SnapshotGroupBySummary != null) {
            var fspec = this.SnapshotGroupBySummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotGroupBySummary {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> VsphereLiveMountConnection? VsphereLiveMounts
        // GraphQL -> vSphereLiveMounts: VsphereLiveMountConnection! (type)
        if (this.VsphereLiveMounts != null) {
            var fspec = this.VsphereLiveMounts.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "vSphereLiveMounts {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> VsphereMountConnection? VsphereMounts
        // GraphQL -> vSphereMounts: VsphereMountConnection! (type)
        if (this.VsphereMounts != null) {
            var fspec = this.VsphereMounts.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "vSphereMounts {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<PathNode>? VsphereTagPath
        // GraphQL -> vsphereTagPath: [PathNode!]! (type)
        if (this.VsphereTagPath != null) {
            var fspec = this.VsphereTagPath.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "vsphereTagPath {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> VsphereVirtualDiskConnection? VsphereVirtualDisks
        // GraphQL -> vsphereVirtualDisks: VsphereVirtualDiskConnection! (type)
        if (this.VsphereVirtualDisks != null) {
            var fspec = this.VsphereVirtualDisks.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "vsphereVirtualDisks {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        if (this.AuthorizedOperations == null && Exploration.Includes(parent + ".authorizedOperations", true))
        {
            this.AuthorizedOperations = new List<Operation>();
        }
        //      C# -> GuestCredentialAuthorizationStatus? GuestCredentialAuthorizationStatus
        // GraphQL -> guestCredentialAuthorizationStatus: GuestCredentialAuthorizationStatus! (enum)
        if (this.GuestCredentialAuthorizationStatus == null && Exploration.Includes(parent + ".guestCredentialAuthorizationStatus", true))
        {
            this.GuestCredentialAuthorizationStatus = new GuestCredentialAuthorizationStatus();
        }
        //      C# -> GuestOsType? GuestOsType
        // GraphQL -> guestOsType: GuestOsType! (enum)
        if (this.GuestOsType == null && Exploration.Includes(parent + ".guestOsType", true))
        {
            this.GuestOsType = new GuestOsType();
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType == null && Exploration.Includes(parent + ".objectType", true))
        {
            this.ObjectType = new HierarchyObjectTypeEnum();
        }
        //      C# -> VmPowerStatus? PowerStatus
        // GraphQL -> powerStatus: VmPowerStatus (enum)
        if (this.PowerStatus == null && Exploration.Includes(parent + ".powerStatus", true))
        {
            this.PowerStatus = new VmPowerStatus();
        }
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (this.SlaAssignment == null && Exploration.Includes(parent + ".slaAssignment", true))
        {
            this.SlaAssignment = new SlaAssignmentTypeEnum();
        }
        //      C# -> ConsistencyLevelEnum? SnapshotConsistencyMandate
        // GraphQL -> snapshotConsistencyMandate: ConsistencyLevelEnum! (enum)
        if (this.SnapshotConsistencyMandate == null && Exploration.Includes(parent + ".snapshotConsistencyMandate", true))
        {
            this.SnapshotConsistencyMandate = new ConsistencyLevelEnum();
        }
        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        if (this.ConfiguredSlaDomain == null && Exploration.Includes(parent + ".configuredSlaDomain"))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(parent + ".configuredSlaDomain");
            this.ConfiguredSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        if (this.EffectiveRetentionSlaDomain == null && Exploration.Includes(parent + ".effectiveRetentionSlaDomain"))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(parent + ".effectiveRetentionSlaDomain");
            this.EffectiveRetentionSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (this.EffectiveSlaDomain == null && Exploration.Includes(parent + ".effectiveSlaDomain"))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(parent + ".effectiveSlaDomain");
            this.EffectiveSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        if (this.PendingSla == null && Exploration.Includes(parent + ".pendingSla"))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(parent + ".pendingSla");
            this.PendingSla = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> List<CdmHierarchyObject>? ReplicatedObjects
        // GraphQL -> replicatedObjects: [CdmHierarchyObject!]! (interface)
        if (this.ReplicatedObjects == null && Exploration.Includes(parent + ".replicatedObjects"))
        {
            this.ReplicatedObjects = new List<CdmHierarchyObject>();
            this.ReplicatedObjects.ApplyExploratoryFieldSpec(parent + ".replicatedObjects");
        }
        //      C# -> System.Boolean? ArrayIntegrationEnabled
        // GraphQL -> arrayIntegrationEnabled: Boolean! (scalar)
        if (this.ArrayIntegrationEnabled == null && Exploration.Includes(parent + ".arrayIntegrationEnabled", true))
        {
            this.ArrayIntegrationEnabled = true;
        }
        //      C# -> System.String? BlueprintId
        // GraphQL -> blueprintId: String (scalar)
        if (this.BlueprintId == null && Exploration.Includes(parent + ".blueprintId", true))
        {
            this.BlueprintId = "FETCH";
        }
        //      C# -> System.String? BlueprintName
        // GraphQL -> blueprintName: String (scalar)
        if (this.BlueprintName == null && Exploration.Includes(parent + ".blueprintName", true))
        {
            this.BlueprintName = "FETCH";
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId == null && Exploration.Includes(parent + ".cdmId", true))
        {
            this.CdmId = "FETCH";
        }
        //      C# -> System.String? CdmLink
        // GraphQL -> cdmLink: String! (scalar)
        if (this.CdmLink == null && Exploration.Includes(parent + ".cdmLink", true))
        {
            this.CdmLink = "FETCH";
        }
        //      C# -> System.String? GuestCredentialId
        // GraphQL -> guestCredentialId: String! (scalar)
        if (this.GuestCredentialId == null && Exploration.Includes(parent + ".guestCredentialId", true))
        {
            this.GuestCredentialId = "FETCH";
        }
        //      C# -> System.String? GuestOsName
        // GraphQL -> guestOsName: String! (scalar)
        if (this.GuestOsName == null && Exploration.Includes(parent + ".guestOsName", true))
        {
            this.GuestOsName = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsActive
        // GraphQL -> isActive: Boolean! (scalar)
        if (this.IsActive == null && Exploration.Includes(parent + ".isActive", true))
        {
            this.IsActive = true;
        }
        //      C# -> System.Boolean? IsArrayIntegrationPossible
        // GraphQL -> isArrayIntegrationPossible: Boolean! (scalar)
        if (this.IsArrayIntegrationPossible == null && Exploration.Includes(parent + ".isArrayIntegrationPossible", true))
        {
            this.IsArrayIntegrationPossible = true;
        }
        //      C# -> System.Boolean? IsBlueprintChild
        // GraphQL -> isBlueprintChild: Boolean! (scalar)
        if (this.IsBlueprintChild == null && Exploration.Includes(parent + ".isBlueprintChild", true))
        {
            this.IsBlueprintChild = true;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic == null && Exploration.Includes(parent + ".isRelic", true))
        {
            this.IsRelic = true;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        if (this.NumWorkloadDescendants == null && Exploration.Includes(parent + ".numWorkloadDescendants", true))
        {
            this.NumWorkloadDescendants = Int32.MinValue;
        }
        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        if (this.OnDemandSnapshotCount == null && Exploration.Includes(parent + ".onDemandSnapshotCount", true))
        {
            this.OnDemandSnapshotCount = Int32.MinValue;
        }
        //      C# -> System.String? ParentWorkloadIdOpt
        // GraphQL -> parentWorkloadIdOpt: UUID (scalar)
        if (this.ParentWorkloadIdOpt == null && Exploration.Includes(parent + ".parentWorkloadIdOpt", true))
        {
            this.ParentWorkloadIdOpt = "FETCH";
        }
        //      C# -> System.String? ParentWorkloadTypeOpt
        // GraphQL -> parentWorkloadTypeOpt: String (scalar)
        if (this.ParentWorkloadTypeOpt == null && Exploration.Includes(parent + ".parentWorkloadTypeOpt", true))
        {
            this.ParentWorkloadTypeOpt = "FETCH";
        }
        //      C# -> DateTime? ProtectionDate
        // GraphQL -> protectionDate: DateTime (scalar)
        if (this.ProtectionDate == null && Exploration.Includes(parent + ".protectionDate", true))
        {
            this.ProtectionDate = new DateTime();
        }
        //      C# -> System.Int32? ReplicatedObjectCount
        // GraphQL -> replicatedObjectCount: Int! (scalar)
        if (this.ReplicatedObjectCount == null && Exploration.Includes(parent + ".replicatedObjectCount", true))
        {
            this.ReplicatedObjectCount = Int32.MinValue;
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (this.SlaPauseStatus == null && Exploration.Includes(parent + ".slaPauseStatus", true))
        {
            this.SlaPauseStatus = true;
        }
        //      C# -> System.Boolean? VmwareToolsInstalled
        // GraphQL -> vmwareToolsInstalled: Boolean! (scalar)
        if (this.VmwareToolsInstalled == null && Exploration.Includes(parent + ".vmwareToolsInstalled", true))
        {
            this.VmwareToolsInstalled = true;
        }
        //      C# -> AgentStatus? AgentStatus
        // GraphQL -> agentStatus: AgentStatus (type)
        if (this.AgentStatus == null && Exploration.Includes(parent + ".agentStatus"))
        {
            this.AgentStatus = new AgentStatus();
            this.AgentStatus.ApplyExploratoryFieldSpec(parent + ".agentStatus");
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs == null && Exploration.Includes(parent + ".allOrgs"))
        {
            this.AllOrgs = new List<Org>();
            this.AllOrgs.ApplyExploratoryFieldSpec(parent + ".allOrgs");
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(parent + ".cluster");
        }
        //      C# -> List<DuplicatedVm>? DuplicatedVms
        // GraphQL -> duplicatedVms: [DuplicatedVm!]! (type)
        if (this.DuplicatedVms == null && Exploration.Includes(parent + ".duplicatedVms"))
        {
            this.DuplicatedVms = new List<DuplicatedVm>();
            this.DuplicatedVms.ApplyExploratoryFieldSpec(parent + ".duplicatedVms");
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (this.EffectiveSlaSourceObject == null && Exploration.Includes(parent + ".effectiveSlaSourceObject"))
        {
            this.EffectiveSlaSourceObject = new PathNode();
            this.EffectiveSlaSourceObject.ApplyExploratoryFieldSpec(parent + ".effectiveSlaSourceObject");
        }
        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        if (this.LatestUserNote == null && Exploration.Includes(parent + ".latestUserNote"))
        {
            this.LatestUserNote = new LatestUserNote();
            this.LatestUserNote.ApplyExploratoryFieldSpec(parent + ".latestUserNote");
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (this.LogicalPath == null && Exploration.Includes(parent + ".logicalPath"))
        {
            this.LogicalPath = new List<PathNode>();
            this.LogicalPath.ApplyExploratoryFieldSpec(parent + ".logicalPath");
        }
        //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
        // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection (type)
        if (this.MissedSnapshotConnection == null && Exploration.Includes(parent + ".missedSnapshotConnection"))
        {
            this.MissedSnapshotConnection = new MissedSnapshotCommonConnection();
            this.MissedSnapshotConnection.ApplyExploratoryFieldSpec(parent + ".missedSnapshotConnection");
        }
        //      C# -> MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection
        // GraphQL -> missedSnapshotGroupByConnection: MissedSnapshotGroupByConnection (type)
        if (this.MissedSnapshotGroupByConnection == null && Exploration.Includes(parent + ".missedSnapshotGroupByConnection"))
        {
            this.MissedSnapshotGroupByConnection = new MissedSnapshotGroupByConnection();
            this.MissedSnapshotGroupByConnection.ApplyExploratoryFieldSpec(parent + ".missedSnapshotGroupByConnection");
        }
        //      C# -> CdmSnapshot? NewestArchivedSnapshot
        // GraphQL -> newestArchivedSnapshot: CdmSnapshot (type)
        if (this.NewestArchivedSnapshot == null && Exploration.Includes(parent + ".newestArchivedSnapshot"))
        {
            this.NewestArchivedSnapshot = new CdmSnapshot();
            this.NewestArchivedSnapshot.ApplyExploratoryFieldSpec(parent + ".newestArchivedSnapshot");
        }
        //      C# -> CdmSnapshot? NewestReplicatedSnapshot
        // GraphQL -> newestReplicatedSnapshot: CdmSnapshot (type)
        if (this.NewestReplicatedSnapshot == null && Exploration.Includes(parent + ".newestReplicatedSnapshot"))
        {
            this.NewestReplicatedSnapshot = new CdmSnapshot();
            this.NewestReplicatedSnapshot.ApplyExploratoryFieldSpec(parent + ".newestReplicatedSnapshot");
        }
        //      C# -> CdmSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: CdmSnapshot (type)
        if (this.NewestSnapshot == null && Exploration.Includes(parent + ".newestSnapshot"))
        {
            this.NewestSnapshot = new CdmSnapshot();
            this.NewestSnapshot.ApplyExploratoryFieldSpec(parent + ".newestSnapshot");
        }
        //      C# -> CdmSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: CdmSnapshot (type)
        if (this.OldestSnapshot == null && Exploration.Includes(parent + ".oldestSnapshot"))
        {
            this.OldestSnapshot = new CdmSnapshot();
            this.OldestSnapshot.ApplyExploratoryFieldSpec(parent + ".oldestSnapshot");
        }
        //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
        // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
        if (this.PendingObjectDeletionStatus == null && Exploration.Includes(parent + ".pendingObjectDeletionStatus"))
        {
            this.PendingObjectDeletionStatus = new PendingSnapshotsOfObjectDeletion();
            this.PendingObjectDeletionStatus.ApplyExploratoryFieldSpec(parent + ".pendingObjectDeletionStatus");
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (this.PhysicalPath == null && Exploration.Includes(parent + ".physicalPath"))
        {
            this.PhysicalPath = new List<PathNode>();
            this.PhysicalPath.ApplyExploratoryFieldSpec(parent + ".physicalPath");
        }
        //      C# -> PrePostScript? PostBackupScript
        // GraphQL -> postBackupScript: PrePostScript (type)
        if (this.PostBackupScript == null && Exploration.Includes(parent + ".postBackupScript"))
        {
            this.PostBackupScript = new PrePostScript();
            this.PostBackupScript.ApplyExploratoryFieldSpec(parent + ".postBackupScript");
        }
        //      C# -> PrePostScript? PostSnapScript
        // GraphQL -> postSnapScript: PrePostScript (type)
        if (this.PostSnapScript == null && Exploration.Includes(parent + ".postSnapScript"))
        {
            this.PostSnapScript = new PrePostScript();
            this.PostSnapScript.ApplyExploratoryFieldSpec(parent + ".postSnapScript");
        }
        //      C# -> PrePostScript? PreBackupScript
        // GraphQL -> preBackupScript: PrePostScript (type)
        if (this.PreBackupScript == null && Exploration.Includes(parent + ".preBackupScript"))
        {
            this.PreBackupScript = new PrePostScript();
            this.PreBackupScript.ApplyExploratoryFieldSpec(parent + ".preBackupScript");
        }
        //      C# -> DataLocation? PrimaryClusterLocation
        // GraphQL -> primaryClusterLocation: DataLocation! (type)
        if (this.PrimaryClusterLocation == null && Exploration.Includes(parent + ".primaryClusterLocation"))
        {
            this.PrimaryClusterLocation = new DataLocation();
            this.PrimaryClusterLocation.ApplyExploratoryFieldSpec(parent + ".primaryClusterLocation");
        }
        //      C# -> Snappable? ReportWorkload
        // GraphQL -> reportWorkload: Snappable (type)
        if (this.ReportWorkload == null && Exploration.Includes(parent + ".reportWorkload"))
        {
            this.ReportWorkload = new Snappable();
            this.ReportWorkload.ApplyExploratoryFieldSpec(parent + ".reportWorkload");
        }
        //      C# -> CdmSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: CdmSnapshotConnection (type)
        if (this.SnapshotConnection == null && Exploration.Includes(parent + ".snapshotConnection"))
        {
            this.SnapshotConnection = new CdmSnapshotConnection();
            this.SnapshotConnection.ApplyExploratoryFieldSpec(parent + ".snapshotConnection");
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution == null && Exploration.Includes(parent + ".snapshotDistribution"))
        {
            this.SnapshotDistribution = new SnapshotDistribution();
            this.SnapshotDistribution.ApplyExploratoryFieldSpec(parent + ".snapshotDistribution");
        }
        //      C# -> CdmSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: CdmSnapshotGroupByConnection (type)
        if (this.SnapshotGroupByConnection == null && Exploration.Includes(parent + ".snapshotGroupByConnection"))
        {
            this.SnapshotGroupByConnection = new CdmSnapshotGroupByConnection();
            this.SnapshotGroupByConnection.ApplyExploratoryFieldSpec(parent + ".snapshotGroupByConnection");
        }
        //      C# -> CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary
        // GraphQL -> snapshotGroupBySummary: CdmSnapshotGroupBySummaryConnection (type)
        if (this.SnapshotGroupBySummary == null && Exploration.Includes(parent + ".snapshotGroupBySummary"))
        {
            this.SnapshotGroupBySummary = new CdmSnapshotGroupBySummaryConnection();
            this.SnapshotGroupBySummary.ApplyExploratoryFieldSpec(parent + ".snapshotGroupBySummary");
        }
        //      C# -> VsphereLiveMountConnection? VsphereLiveMounts
        // GraphQL -> vSphereLiveMounts: VsphereLiveMountConnection! (type)
        if (this.VsphereLiveMounts == null && Exploration.Includes(parent + ".vSphereLiveMounts"))
        {
            this.VsphereLiveMounts = new VsphereLiveMountConnection();
            this.VsphereLiveMounts.ApplyExploratoryFieldSpec(parent + ".vSphereLiveMounts");
        }
        //      C# -> VsphereMountConnection? VsphereMounts
        // GraphQL -> vSphereMounts: VsphereMountConnection! (type)
        if (this.VsphereMounts == null && Exploration.Includes(parent + ".vSphereMounts"))
        {
            this.VsphereMounts = new VsphereMountConnection();
            this.VsphereMounts.ApplyExploratoryFieldSpec(parent + ".vSphereMounts");
        }
        //      C# -> List<PathNode>? VsphereTagPath
        // GraphQL -> vsphereTagPath: [PathNode!]! (type)
        if (this.VsphereTagPath == null && Exploration.Includes(parent + ".vsphereTagPath"))
        {
            this.VsphereTagPath = new List<PathNode>();
            this.VsphereTagPath.ApplyExploratoryFieldSpec(parent + ".vsphereTagPath");
        }
        //      C# -> VsphereVirtualDiskConnection? VsphereVirtualDisks
        // GraphQL -> vsphereVirtualDisks: VsphereVirtualDiskConnection! (type)
        if (this.VsphereVirtualDisks == null && Exploration.Includes(parent + ".vsphereVirtualDisks"))
        {
            this.VsphereVirtualDisks = new VsphereVirtualDiskConnection();
            this.VsphereVirtualDisks.ApplyExploratoryFieldSpec(parent + ".vsphereVirtualDisks");
        }
    }


    #endregion

    } // class VsphereVm
    
    #endregion

    public static class ListVsphereVmExtensions
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
            this List<VsphereVm> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VsphereVm> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VsphereVm());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types