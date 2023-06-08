### CustomReport
Metadata for rendering a custom report.

- id: System.Int32
  - ID of the custom report.
- name: System.String
  - Name of the custom report.
- focus: ReportFocusEnum
  - The metrics focus of the custom report.
- isHidden: System.Boolean
  - True if report should be hidden from gallery view.
- isReadOnly: System.Boolean
  - True if report is auto-generated and not allowed to be edited.
- filters: CustomReportFilters
  - The filters applied to the data in the report.
- createdAt: DateTime
  - Time the report was created.
- updatedAt: DateTime
  - Time the report was last updated (i.e., saved).
- viewedAt: DateTime
  - Time the report was last viewed / opened by the user.
- charts: list of ReportChartTypes
  - The list of charts in the custom report.
- tables: list of ReportTableTypes
  - The list of tables in the custom report.
- owner: User
  - The creator of the custom report.
- oldestSyncDate: DateTime
- newestSyncDate: DateTime
- scheduledReports: ScheduledReportConnection