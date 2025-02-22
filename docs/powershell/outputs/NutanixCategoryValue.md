### NutanixCategoryValue
Nutanix Category Value details.

- cdmId: System.String
  - CDM ID of the Nutanix Category Value.
- prismCentralId: System.String
  - Prism Central ID of the Category Value.
- categoryId: System.String
  - Category ID of the Category Value.
- connectionStatus: RefreshableObjectConnectionStatus
  - Connection status of the CDM Cluster. If the CDM cluster is disconnected, then the status is set to 'Disconnected'.
- descendantConnection: NutanixCategoryValueDescendantTypeConnection
  - List of descendants.
- logicalChildConnection: NutanixCategoryValueLogicalChildTypeConnection
  - List of logical children.
- nutanixVms: CdmHierarchyObjectConnection
  - Provide a list of child Nutanix virtual machine objects for the current Nutanix category value.
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
- id: System.String
  - The FID of the hierarchy object.
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
- duplicateObjectsAbsoluteCount: System.Int32
  - Determine the total count of duplicate objects for the Multi Cluster Object, regardless of the user's RBAC permissions.
- duplicateObjects: list of CdmHierarchyObjects
  - Provide a list of duplicated objects representing identical instances of the Multi Cluster Object. Each instance is located on a different Rubrik cluster.
