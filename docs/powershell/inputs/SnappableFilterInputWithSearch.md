### SnappableFilterInputWithSearch
Filter workload data, including search capability.

- protectionStatus: list of ProtectionStatusEnums
  - The protection status of the workload.
- slaDomain: SnappableSlaDomainFilterInput
  - The SLA Domain of the workload.
- complianceStatus: list of ComplianceStatusEnums
  - The compliance status of the workload.
- objectType: list of ObjectTypeEnums
  - The object type of the workload.
- excludedObjectTypes: list of ObjectTypeEnums
  - List of workload types to exclude. This should NOT be specified along with objectType.
- cluster: CommonClusterFilterInput
  - The cluster UUID of the workload.
- timeRange: TimeRangeInput
- searchTerm: System.String
  - The search term applied to the workload.
- slaTimeRange: SlaComplianceTimeRange
  - The SLA Domain time range applied to the workload.
- orgId: list of System.Strings
  - The organization ID of the workload.
- objectState: list of ObjectStates
  - The state of the workload.
