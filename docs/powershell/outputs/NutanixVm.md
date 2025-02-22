### NutanixVm
Nutanix virtual machine details.

- cdmId: System.String
  - CDM ID of the Nutanix virtual machine.
- isRelic: System.Boolean
  - Specifies whether this Nutanix virtual machine is currently present on the Nutanix cluster.
- preBackupScript: NutanixBackupScript
  - Pre backup script configuration.
- postBackupScript: NutanixBackupScript
  - Post backup script configuration.
- postSnapScript: NutanixBackupScript
  - Post snapshot script configuration.
- vmDisks: list of NutanixVmDisks
  - List of virtual disks.
- snapshotConsistencyMandate: NutanixVmSnapshotConsistencyMandate
  - Deprecated, use nutanixSnapshotConsistencyMandate instead.
- agentStatus: NutanixVmAgentStatus
  - Nutanix virtual machine agent status.
- isAgentRegistered: System.Boolean
  - Specifies if the agent is registered.
- excludedDisks: list of System.Strings
  - List of IDs of the excluded disks.
- hypervisorType: System.String
  - Hypervisor type, such as AHV. This field will be set to null if not provided by Nutanix.
- vmUuid: System.String
  - Virtual machine ID.
- currentHostId: System.String
  - ID of the AHV host where virtual machine is located. This field will be set to null if not provided by Nutanix.
- id: System.String
  - Object ID.
- reportSnappable: Snappable
  - Statistics for Nutanix virtual machine (For example, capacity).
- nutanixVmMountCount: System.Int32
  - Total number of Live Mounts on Nutanix virtual machine.
- nutanixSnapshotConsistencyMandate: CdmNutanixSnapshotConsistencyMandate
  - Nutanix snapshot consistency level.
- osType: GuestOsType
  - Guest operating system type of the virtual machine. This field will be set to null if not provided by Nutanix.
- cluster: Cluster
  - Rubrik cluster where this object originated.
- primaryClusterLocation: DataLocation
  - The source cluster of this object. Returned as a data location because there is no guarantee that Rubrik has knowledge about the source cluster.
- pendingSla: SlaDomain
  - SLA Domain assignment of the object during the process of being communicated over to Rubrik CDM.
- pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion
  - Mapping from object ID to pending object deletion status.
- replicatedObjects: list of CdmHierarchyObjects
  - Objects either replicated by this object or related to this object by replication.
- crossAccountReplicatedObjectInfos: list of CrossAccountReplicatedObjectInfos
  - Cross-account objects either replicated by this object or related to this object by replication.
- latestUserNote: LatestUserNote
  - Latest user note information.
- replicatedObjectCount: System.Int32
  - The number of objects either replicated by this object or related to this object by replication.
- authorizedOperations: list of Operations
  - The authorized operations on the object.
- name: System.String
  - The name of the hierarchy object.
- objectType: HierarchyObjectTypeEnum
  - The type of this object.
- slaAssignment: SlaAssignmentTypeEnum
  - The SLA Domain assignment type for this object.
- effectiveSlaDomain: SlaDomain
  - The effective SLA Domain of the hierarchy object.
- slaPauseStatus: System.Boolean
  - The pause status of the effective SLA Domain of the hierarchy object.
- snapshotDistribution: SnapshotDistribution
  - The distribution of the snapshots of the hierarchy object.
- effectiveRetentionSlaDomain: SlaDomain
  - The effective retention of the SLA Domain of the hierarchy object.
- configuredSlaDomain: SlaDomain
  - The SLA Domain configured for the hierarchy object.
- effectiveSlaSourceObject: PathNode
  - The path node of the effective SLA Domain source.
- logicalPath: list of PathNodes
  - A sequential list of this object's logical ancestors.
- physicalPath: list of PathNodes
  - A sequential list of this object's physical ancestors.
- numWorkloadDescendants: System.Int32
  - The number of descendant workloads of this object.
- allOrgs: list of Orgs
  - The organizations to which this hierarchy object belongs.
- cdmLink: System.String
  - A link to view the workload on the CDM cluster. For dev use only.
- missedSnapshotConnection: MissedSnapshotCommonConnection
  - The list of missed snapshots for this workload.
- missedSnapshotGroupByConnection: MissedSnapshotGroupByConnection
  - The list of missed snapshots for this workload.
- snapshotConnection: CdmSnapshotConnection
  - The list of snapshots taken for this workload.
- snapshotGroupByConnection: CdmSnapshotGroupByConnection
  - GroupBy connection for the snapshots of this workload.
- snapshotGroupBySummary: CdmSnapshotGroupBySummaryConnection
  - GroupBy connection for the snapshots of this workload.
- newestIndexedSnapshot: CdmSnapshot
  - The most recent indexed snapshot of this workload.
- newestSnapshot: CdmSnapshot
  - The most recent snapshot of this workload.
- oldestSnapshot: CdmSnapshot
  - The oldest snapshot of this workload.
- onDemandSnapshotCount: System.Int32
  - The number of on-demand snapshots.
- newestArchivedSnapshot: CdmSnapshot
  - The newest snapshot archived to AWS.
- newestReplicatedSnapshot: CdmSnapshot
  - The newest snapshot replicated to a cluster.
