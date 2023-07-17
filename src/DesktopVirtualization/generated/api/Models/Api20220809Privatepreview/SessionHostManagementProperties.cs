namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Extensions;

    /// <summary>Session host Managements of HostPool.</summary>
    public partial class SessionHostManagementProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementPropertiesInternal
    {

        /// <summary>Internal Acessors for Update</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IHostPoolUpdateConfigurationProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementPropertiesInternal.Update { get => (this._update = this._update ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.HostPoolUpdateConfigurationProperties()); set { {_update = value;} } }

        /// <summary>Backing field for <see cref="ScheduledDateTimeZone" /> property.</summary>
        private string _scheduledDateTimeZone;

        /// <summary>
        /// Time zone for sessionHostManagement operations as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0.
        /// Must be set if useLocalTime is true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public string ScheduledDateTimeZone { get => this._scheduledDateTimeZone; set => this._scheduledDateTimeZone = value; }

        /// <summary>Backing field for <see cref="Update" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IHostPoolUpdateConfigurationProperties _update;

        /// <summary>Parameters for a hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IHostPoolUpdateConfigurationProperties Update { get => (this._update = this._update ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.HostPoolUpdateConfigurationProperties()); set => this._update = value; }

        /// <summary>Whether not to save original disk. False by default.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public bool? UpdateDeleteOriginalVM { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IHostPoolUpdateConfigurationPropertiesInternal)Update).DeleteOriginalVM; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IHostPoolUpdateConfigurationPropertiesInternal)Update).DeleteOriginalVM = value ?? default(bool); }

        /// <summary>Grace period before logging off users in minutes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public int UpdateLogOffDelayMinute { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IHostPoolUpdateConfigurationPropertiesInternal)Update).LogOffDelayMinute; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IHostPoolUpdateConfigurationPropertiesInternal)Update).LogOffDelayMinute = value ; }

        /// <summary>Log off message sent to user for logoff.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string UpdateLogOffMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IHostPoolUpdateConfigurationPropertiesInternal)Update).LogOffMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IHostPoolUpdateConfigurationPropertiesInternal)Update).LogOffMessage = value ; }

        /// <summary>The maximum number of virtual machines to be removed during hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public int UpdateMaxVmsRemoved { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IHostPoolUpdateConfigurationPropertiesInternal)Update).MaxVmsRemoved; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IHostPoolUpdateConfigurationPropertiesInternal)Update).MaxVmsRemoved = value ; }

        /// <summary>Creates an new <see cref="SessionHostManagementProperties" /> instance.</summary>
        public SessionHostManagementProperties()
        {

        }
    }
    /// Session host Managements of HostPool.
    public partial interface ISessionHostManagementProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Time zone for sessionHostManagement operations as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0.
        /// Must be set if useLocalTime is true.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Time zone for sessionHostManagement operations as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0. Must be set if useLocalTime is true.",
        SerializedName = @"scheduledDateTimeZone",
        PossibleTypes = new [] { typeof(string) })]
        string ScheduledDateTimeZone { get; set; }
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
        Required = true,
        ReadOnly = false,
        Description = @"Grace period before logging off users in minutes.",
        SerializedName = @"logOffDelayMinutes",
        PossibleTypes = new [] { typeof(int) })]
        int UpdateLogOffDelayMinute { get; set; }
        /// <summary>Log off message sent to user for logoff.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Log off message sent to user for logoff.",
        SerializedName = @"logOffMessage",
        PossibleTypes = new [] { typeof(string) })]
        string UpdateLogOffMessage { get; set; }
        /// <summary>The maximum number of virtual machines to be removed during hostpool update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The maximum number of virtual machines to be removed during hostpool update.",
        SerializedName = @"maxVmsRemoved",
        PossibleTypes = new [] { typeof(int) })]
        int UpdateMaxVmsRemoved { get; set; }

    }
    /// Session host Managements of HostPool.
    internal partial interface ISessionHostManagementPropertiesInternal

    {
        /// <summary>
        /// Time zone for sessionHostManagement operations as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0.
        /// Must be set if useLocalTime is true.
        /// </summary>
        string ScheduledDateTimeZone { get; set; }
        /// <summary>Parameters for a hostpool update.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IHostPoolUpdateConfigurationProperties Update { get; set; }
        /// <summary>Whether not to save original disk. False by default.</summary>
        bool? UpdateDeleteOriginalVM { get; set; }
        /// <summary>Grace period before logging off users in minutes.</summary>
        int UpdateLogOffDelayMinute { get; set; }
        /// <summary>Log off message sent to user for logoff.</summary>
        string UpdateLogOffMessage { get; set; }
        /// <summary>The maximum number of virtual machines to be removed during hostpool update.</summary>
        int UpdateMaxVmsRemoved { get; set; }

    }
}