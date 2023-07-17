namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Extensions;

    /// <summary>Properties for arm migration.</summary>
    public partial class MigrationRequestProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IMigrationRequestProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IMigrationRequestPropertiesInternal
    {

        /// <summary>Backing field for <see cref="MigrationPath" /> property.</summary>
        private string _migrationPath;

        /// <summary>The path to the legacy object to migrate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public string MigrationPath { get => this._migrationPath; set => this._migrationPath = value; }

        /// <summary>Backing field for <see cref="Operation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.Operation? _operation;

        /// <summary>The type of operation for migration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.Operation? Operation { get => this._operation; set => this._operation = value; }

        /// <summary>Creates an new <see cref="MigrationRequestProperties" /> instance.</summary>
        public MigrationRequestProperties()
        {

        }
    }
    /// Properties for arm migration.
    public partial interface IMigrationRequestProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.IJsonSerializable
    {
        /// <summary>The path to the legacy object to migrate.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The path to the legacy object to migrate.",
        SerializedName = @"migrationPath",
        PossibleTypes = new [] { typeof(string) })]
        string MigrationPath { get; set; }
        /// <summary>The type of operation for migration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of operation for migration.",
        SerializedName = @"operation",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.Operation) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.Operation? Operation { get; set; }

    }
    /// Properties for arm migration.
    internal partial interface IMigrationRequestPropertiesInternal

    {
        /// <summary>The path to the legacy object to migrate.</summary>
        string MigrationPath { get; set; }
        /// <summary>The type of operation for migration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.Operation? Operation { get; set; }

    }
}