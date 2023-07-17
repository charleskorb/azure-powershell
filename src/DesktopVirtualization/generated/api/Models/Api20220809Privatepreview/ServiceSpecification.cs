namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Extensions;

    /// <summary>Service specification payload</summary>
    public partial class ServiceSpecification :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IServiceSpecification,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IServiceSpecificationInternal
    {

        /// <summary>Backing field for <see cref="LogSpecification" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ILogSpecification[] _logSpecification;

        /// <summary>Specifications of the Log for Azure Monitoring</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ILogSpecification[] LogSpecification { get => this._logSpecification; set => this._logSpecification = value; }

        /// <summary>Creates an new <see cref="ServiceSpecification" /> instance.</summary>
        public ServiceSpecification()
        {

        }
    }
    /// Service specification payload
    public partial interface IServiceSpecification :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.IJsonSerializable
    {
        /// <summary>Specifications of the Log for Azure Monitoring</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifications of the Log for Azure Monitoring",
        SerializedName = @"logSpecifications",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ILogSpecification) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ILogSpecification[] LogSpecification { get; set; }

    }
    /// Service specification payload
    internal partial interface IServiceSpecificationInternal

    {
        /// <summary>Specifications of the Log for Azure Monitoring</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ILogSpecification[] LogSpecification { get; set; }

    }
}