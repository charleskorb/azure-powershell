namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Extensions;

    /// <summary>The current status of an async operation.</summary>
    public partial class SessionHostManagementOperationStatus :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationStatus,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationStatusInternal
    {

        /// <summary>Backing field for <see cref="Action" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.OperationActionShm? _action;

        /// <summary>Action type of the current sessionHostManagement operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.OperationActionShm? Action { get => this._action; }

        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorAdditionalInfo[] AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorDetailInternal)Error).AdditionalInfo; }

        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorDetailInternal)Error).Code; }

        /// <summary>Backing field for <see cref="CorrelationId" /> property.</summary>
        private string _correlationId;

        /// <summary>The Log Analytics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public string CorrelationId { get => this._correlationId; set => this._correlationId = value; }

        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorDetail[] Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorDetailInternal)Error).Detail; }

        /// <summary>Backing field for <see cref="EndTime" /> property.</summary>
        private global::System.DateTime? _endTime;

        /// <summary>The end time of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public global::System.DateTime? EndTime { get => this._endTime; set => this._endTime = value; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorDetail _error;

        /// <summary>If present, details of the operation error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorDetail Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.ErrorDetail()); set => this._error = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Fully qualified ID for the async operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorDetailInternal)Error).Message; }

        /// <summary>Internal Acessors for Action</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.OperationActionShm? Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationStatusInternal.Action { get => this._action; set { {_action = value;} } }

        /// <summary>Internal Acessors for AdditionalInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorAdditionalInfo[] Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationStatusInternal.AdditionalInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorDetailInternal)Error).AdditionalInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorDetailInternal)Error).AdditionalInfo = value; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationStatusInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorDetailInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorDetailInternal)Error).Code = value; }

        /// <summary>Internal Acessors for Detail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorDetail[] Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationStatusInternal.Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorDetailInternal)Error).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorDetailInternal)Error).Detail = value; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorDetail Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationStatusInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.ErrorDetail()); set { {_error = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationStatusInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorDetailInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorDetailInternal)Error).Message = value; }

        /// <summary>Internal Acessors for Progress</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationProgress Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationStatusInternal.Progress { get => (this._progress = this._progress ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.SessionHostManagementOperationProgress()); set { {_progress = value;} } }

        /// <summary>Internal Acessors for SessionHostManagement</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagement Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationStatusInternal.SessionHostManagement { get => (this._sessionHostManagement = this._sessionHostManagement ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.SessionHostManagement()); set { {_sessionHostManagement = value;} } }

        /// <summary>Internal Acessors for SessionHostManagementId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationStatusInternal.SessionHostManagementId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)SessionHostManagement).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)SessionHostManagement).Id = value; }

        /// <summary>Internal Acessors for SessionHostManagementName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationStatusInternal.SessionHostManagementName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)SessionHostManagement).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)SessionHostManagement).Name = value; }

        /// <summary>Internal Acessors for SessionHostManagementProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationStatusInternal.SessionHostManagementProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementInternal)SessionHostManagement).Property; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementInternal)SessionHostManagement).Property = value; }

        /// <summary>Internal Acessors for SessionHostManagementSystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20.ISystemData Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationStatusInternal.SessionHostManagementSystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)SessionHostManagement).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)SessionHostManagement).SystemData = value; }

        /// <summary>Internal Acessors for SessionHostManagementType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationStatusInternal.SessionHostManagementType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)SessionHostManagement).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)SessionHostManagement).Type = value; }

        /// <summary>Internal Acessors for Target</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationStatusInternal.Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorDetailInternal)Error).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorDetailInternal)Error).Target = value; }

        /// <summary>Internal Acessors for Update</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IHostPoolUpdateConfigurationProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationStatusInternal.Update { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementInternal)SessionHostManagement).Update; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementInternal)SessionHostManagement).Update = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the async operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Operation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationStatus[] _operation;

        /// <summary>The operations list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationStatus[] Operation { get => this._operation; set => this._operation = value; }

        /// <summary>Backing field for <see cref="ParentId" /> property.</summary>
        private string _parentId;

        /// <summary>The resource ID of the operation that started this process.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public string ParentId { get => this._parentId; set => this._parentId = value; }

        /// <summary>Backing field for <see cref="PercentComplete" /> property.</summary>
        private float? _percentComplete;

        /// <summary>Percent of the operation that is complete.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public float? PercentComplete { get => this._percentComplete; set => this._percentComplete = value; }

        /// <summary>Backing field for <see cref="Progress" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationProgress _progress;

        /// <summary>Progress information on the sessionHostManagement operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationProgress Progress { get => (this._progress = this._progress ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.SessionHostManagementOperationProgress()); set => this._progress = value; }

        /// <summary>Time that the sessionHostManagement operation was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public global::System.DateTime? ProgressExecutionStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationProgressInternal)Progress).ExecutionStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationProgressInternal)Progress).ExecutionStartTime = value ?? default(global::System.DateTime); }

        /// <summary>The number of sessionHosts completed in the sessionHostManagement operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public int? ProgressSessionHostsCompleted { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationProgressInternal)Progress).SessionHostsCompleted; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationProgressInternal)Progress).SessionHostsCompleted = value ?? default(int); }

        /// <summary>The number of sessionHosts in progress in the sessionHostManagement operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public int? ProgressSessionHostsInProgress { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationProgressInternal)Progress).SessionHostsInProgress; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationProgressInternal)Progress).SessionHostsInProgress = value ?? default(int); }

        /// <summary>
        /// The number of sessionHosts rollback failed in the sessionHostManagement operation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public int? ProgressSessionHostsRollbackFailed { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationProgressInternal)Progress).SessionHostsRollbackFailed; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationProgressInternal)Progress).SessionHostsRollbackFailed = value ?? default(int); }

        /// <summary>
        /// The number of sessionHosts to be started in the sessionHostManagement operation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public int? ProgressTotalSessionHost { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationProgressInternal)Progress).TotalSessionHost; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationProgressInternal)Progress).TotalSessionHost = value ?? default(int); }

        /// <summary>Backing field for <see cref="ScheduledDateTime" /> property.</summary>
        private global::System.DateTime? _scheduledDateTime;

        /// <summary>The timestamp that the update is scheduled for.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public global::System.DateTime? ScheduledDateTime { get => this._scheduledDateTime; set => this._scheduledDateTime = value; }

        /// <summary>
        /// Time zone for sessionHostManagement operations as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0.
        /// Must be set if useLocalTime is true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string ScheduledDateTimeZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementInternal)SessionHostManagement).ScheduledDateTimeZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementInternal)SessionHostManagement).ScheduledDateTimeZone = value ?? null; }

        /// <summary>Backing field for <see cref="SessionHostManagement" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagement _sessionHostManagement;

        /// <summary>SessionHostManagement properties used for the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagement SessionHostManagement { get => (this._sessionHostManagement = this._sessionHostManagement ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.SessionHostManagement()); set => this._sessionHostManagement = value; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string SessionHostManagementId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)SessionHostManagement).Id; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string SessionHostManagementName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)SessionHostManagement).Name; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public global::System.DateTime? SessionHostManagementSystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)SessionHostManagement).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)SessionHostManagement).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string SessionHostManagementSystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)SessionHostManagement).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)SessionHostManagement).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType? SessionHostManagementSystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)SessionHostManagement).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)SessionHostManagement).SystemDataCreatedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType)""); }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public global::System.DateTime? SessionHostManagementSystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)SessionHostManagement).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)SessionHostManagement).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string SessionHostManagementSystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)SessionHostManagement).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)SessionHostManagement).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType? SessionHostManagementSystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)SessionHostManagement).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)SessionHostManagement).SystemDataLastModifiedByType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType)""); }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string SessionHostManagementType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)SessionHostManagement).Type; }

        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private global::System.DateTime? _startTime;

        /// <summary>The start time of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public global::System.DateTime? StartTime { get => this._startTime; set => this._startTime = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>
        /// Operation status. Current defined values are < Scheduled | UpdatingSessionHosts | ValidatingSessionHostUpdate | Paused
        /// | Pausing | Cancelling | Resuming | Starting > | Succeeded | Failed | Canceled
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorDetailInternal)Error).Target; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.OperationTypeShm? _type;

        /// <summary>Type of sessionHostManagement operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.OperationTypeShm? Type { get => this._type; set => this._type = value; }

        /// <summary>Whether not to save original disk. False by default.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public bool? UpdateDeleteOriginalVM { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementInternal)SessionHostManagement).UpdateDeleteOriginalVM; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementInternal)SessionHostManagement).UpdateDeleteOriginalVM = value ?? default(bool); }

        /// <summary>Grace period before logging off users in minutes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public int? UpdateLogOffDelayMinute { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementInternal)SessionHostManagement).UpdateLogOffDelayMinute; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementInternal)SessionHostManagement).UpdateLogOffDelayMinute = value ?? default(int); }

        /// <summary>Log off message sent to user for logoff.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string UpdateLogOffMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementInternal)SessionHostManagement).UpdateLogOffMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementInternal)SessionHostManagement).UpdateLogOffMessage = value ?? null; }

        /// <summary>The maximum number of virtual machines to be removed during hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public int? UpdateMaxVmsRemoved { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementInternal)SessionHostManagement).UpdateMaxVmsRemoved; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementInternal)SessionHostManagement).UpdateMaxVmsRemoved = value ?? default(int); }

        /// <summary>Creates an new <see cref="SessionHostManagementOperationStatus" /> instance.</summary>
        public SessionHostManagementOperationStatus()
        {

        }
    }
    /// The current status of an async operation.
    public partial interface ISessionHostManagementOperationStatus :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.IJsonSerializable
    {
        /// <summary>Action type of the current sessionHostManagement operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Action type of the current sessionHostManagement operation.",
        SerializedName = @"action",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.OperationActionShm) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.OperationActionShm? Action { get;  }
        /// <summary>The error additional info.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error additional info.",
        SerializedName = @"additionalInfo",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorAdditionalInfo) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorAdditionalInfo[] AdditionalInfo { get;  }
        /// <summary>The error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>The Log Analytics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Log Analytics.",
        SerializedName = @"correlationId",
        PossibleTypes = new [] { typeof(string) })]
        string CorrelationId { get; set; }
        /// <summary>The error details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error details.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorDetail) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorDetail[] Detail { get;  }
        /// <summary>The end time of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The end time of the operation.",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EndTime { get; set; }
        /// <summary>Fully qualified ID for the async operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Fully qualified ID for the async operation.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The error message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error message.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>Name of the async operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the async operation.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The operations list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The operations list.",
        SerializedName = @"operations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationStatus[] Operation { get; set; }
        /// <summary>The resource ID of the operation that started this process.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource ID of the operation that started this process.",
        SerializedName = @"parentId",
        PossibleTypes = new [] { typeof(string) })]
        string ParentId { get; set; }
        /// <summary>Percent of the operation that is complete.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Percent of the operation that is complete.",
        SerializedName = @"percentComplete",
        PossibleTypes = new [] { typeof(float) })]
        float? PercentComplete { get; set; }
        /// <summary>Time that the sessionHostManagement operation was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Time that the sessionHostManagement operation was created.",
        SerializedName = @"executionStartTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ProgressExecutionStartTime { get; set; }
        /// <summary>The number of sessionHosts completed in the sessionHostManagement operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of sessionHosts completed in the sessionHostManagement operation.",
        SerializedName = @"sessionHostsCompleted",
        PossibleTypes = new [] { typeof(int) })]
        int? ProgressSessionHostsCompleted { get; set; }
        /// <summary>The number of sessionHosts in progress in the sessionHostManagement operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of sessionHosts in progress in the sessionHostManagement operation.",
        SerializedName = @"sessionHostsInProgress",
        PossibleTypes = new [] { typeof(int) })]
        int? ProgressSessionHostsInProgress { get; set; }
        /// <summary>
        /// The number of sessionHosts rollback failed in the sessionHostManagement operation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of sessionHosts rollback failed in the sessionHostManagement operation.",
        SerializedName = @"sessionHostsRollbackFailed",
        PossibleTypes = new [] { typeof(int) })]
        int? ProgressSessionHostsRollbackFailed { get; set; }
        /// <summary>
        /// The number of sessionHosts to be started in the sessionHostManagement operation.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of sessionHosts to be started in the sessionHostManagement operation.",
        SerializedName = @"totalSessionHosts",
        PossibleTypes = new [] { typeof(int) })]
        int? ProgressTotalSessionHost { get; set; }
        /// <summary>The timestamp that the update is scheduled for.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp that the update is scheduled for.",
        SerializedName = @"scheduledDateTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ScheduledDateTime { get; set; }
        /// <summary>
        /// Time zone for sessionHostManagement operations as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0.
        /// Must be set if useLocalTime is true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Time zone for sessionHostManagement operations as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0. Must be set if useLocalTime is true.",
        SerializedName = @"scheduledDateTimeZone",
        PossibleTypes = new [] { typeof(string) })]
        string ScheduledDateTimeZone { get; set; }
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string SessionHostManagementId { get;  }
        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The name of the resource",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string SessionHostManagementName { get;  }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SessionHostManagementSystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SessionHostManagementSystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType? SessionHostManagementSystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SessionHostManagementSystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SessionHostManagementSystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType? SessionHostManagementSystemDataLastModifiedByType { get; set; }
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of the resource. E.g. ""Microsoft.Compute/virtualMachines"" or ""Microsoft.Storage/storageAccounts""",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string SessionHostManagementType { get;  }
        /// <summary>The start time of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The start time of the operation.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartTime { get; set; }
        /// <summary>
        /// Operation status. Current defined values are < Scheduled | UpdatingSessionHosts | ValidatingSessionHostUpdate | Paused
        /// | Pausing | Cancelling | Resuming | Starting > | Succeeded | Failed | Canceled
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Operation status. Current defined values are < Scheduled | UpdatingSessionHosts | ValidatingSessionHostUpdate | Paused | Pausing | Cancelling | Resuming | Starting > | Succeeded | Failed | Canceled",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }
        /// <summary>The error target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The error target.",
        SerializedName = @"target",
        PossibleTypes = new [] { typeof(string) })]
        string Target { get;  }
        /// <summary>Type of sessionHostManagement operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of sessionHostManagement operation.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.OperationTypeShm) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.OperationTypeShm? Type { get; set; }
        /// <summary>Whether not to save original disk. False by default.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether not to save original disk. False by default.",
        SerializedName = @"deleteOriginalVm",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UpdateDeleteOriginalVM { get; set; }
        /// <summary>Grace period before logging off users in minutes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Grace period before logging off users in minutes.",
        SerializedName = @"logOffDelayMinutes",
        PossibleTypes = new [] { typeof(int) })]
        int? UpdateLogOffDelayMinute { get; set; }
        /// <summary>Log off message sent to user for logoff.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Log off message sent to user for logoff.",
        SerializedName = @"logOffMessage",
        PossibleTypes = new [] { typeof(string) })]
        string UpdateLogOffMessage { get; set; }
        /// <summary>The maximum number of virtual machines to be removed during hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The maximum number of virtual machines to be removed during hostpool update.",
        SerializedName = @"maxVmsRemoved",
        PossibleTypes = new [] { typeof(int) })]
        int? UpdateMaxVmsRemoved { get; set; }

    }
    /// The current status of an async operation.
    internal partial interface ISessionHostManagementOperationStatusInternal

    {
        /// <summary>Action type of the current sessionHostManagement operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.OperationActionShm? Action { get; set; }
        /// <summary>The error additional info.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorAdditionalInfo[] AdditionalInfo { get; set; }
        /// <summary>The error code.</summary>
        string Code { get; set; }
        /// <summary>The Log Analytics.</summary>
        string CorrelationId { get; set; }
        /// <summary>The error details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorDetail[] Detail { get; set; }
        /// <summary>The end time of the operation.</summary>
        global::System.DateTime? EndTime { get; set; }
        /// <summary>If present, details of the operation error.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IErrorDetail Error { get; set; }
        /// <summary>Fully qualified ID for the async operation.</summary>
        string Id { get; set; }
        /// <summary>The error message.</summary>
        string Message { get; set; }
        /// <summary>Name of the async operation.</summary>
        string Name { get; set; }
        /// <summary>The operations list.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationStatus[] Operation { get; set; }
        /// <summary>The resource ID of the operation that started this process.</summary>
        string ParentId { get; set; }
        /// <summary>Percent of the operation that is complete.</summary>
        float? PercentComplete { get; set; }
        /// <summary>Progress information on the sessionHostManagement operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementOperationProgress Progress { get; set; }
        /// <summary>Time that the sessionHostManagement operation was created.</summary>
        global::System.DateTime? ProgressExecutionStartTime { get; set; }
        /// <summary>The number of sessionHosts completed in the sessionHostManagement operation.</summary>
        int? ProgressSessionHostsCompleted { get; set; }
        /// <summary>The number of sessionHosts in progress in the sessionHostManagement operation.</summary>
        int? ProgressSessionHostsInProgress { get; set; }
        /// <summary>
        /// The number of sessionHosts rollback failed in the sessionHostManagement operation.
        /// </summary>
        int? ProgressSessionHostsRollbackFailed { get; set; }
        /// <summary>
        /// The number of sessionHosts to be started in the sessionHostManagement operation.
        /// </summary>
        int? ProgressTotalSessionHost { get; set; }
        /// <summary>The timestamp that the update is scheduled for.</summary>
        global::System.DateTime? ScheduledDateTime { get; set; }
        /// <summary>
        /// Time zone for sessionHostManagement operations as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0.
        /// Must be set if useLocalTime is true.
        /// </summary>
        string ScheduledDateTimeZone { get; set; }
        /// <summary>SessionHostManagement properties used for the operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagement SessionHostManagement { get; set; }
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        string SessionHostManagementId { get; set; }
        /// <summary>The name of the resource</summary>
        string SessionHostManagementName { get; set; }
        /// <summary>Detailed properties for SessionHostManagement</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementProperties SessionHostManagementProperty { get; set; }
        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20.ISystemData SessionHostManagementSystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SessionHostManagementSystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SessionHostManagementSystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType? SessionHostManagementSystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? SessionHostManagementSystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SessionHostManagementSystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType? SessionHostManagementSystemDataLastModifiedByType { get; set; }
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        string SessionHostManagementType { get; set; }
        /// <summary>The start time of the operation.</summary>
        global::System.DateTime? StartTime { get; set; }
        /// <summary>
        /// Operation status. Current defined values are < Scheduled | UpdatingSessionHosts | ValidatingSessionHostUpdate | Paused
        /// | Pausing | Cancelling | Resuming | Starting > | Succeeded | Failed | Canceled
        /// </summary>
        string Status { get; set; }
        /// <summary>The error target.</summary>
        string Target { get; set; }
        /// <summary>Type of sessionHostManagement operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.OperationTypeShm? Type { get; set; }
        /// <summary>Parameters for a hostpool update.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IHostPoolUpdateConfigurationProperties Update { get; set; }
        /// <summary>Whether not to save original disk. False by default.</summary>
        bool? UpdateDeleteOriginalVM { get; set; }
        /// <summary>Grace period before logging off users in minutes.</summary>
        int? UpdateLogOffDelayMinute { get; set; }
        /// <summary>Log off message sent to user for logoff.</summary>
        string UpdateLogOffMessage { get; set; }
        /// <summary>The maximum number of virtual machines to be removed during hostpool update.</summary>
        int? UpdateMaxVmsRemoved { get; set; }

    }
}