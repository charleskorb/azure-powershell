namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Extensions;

    /// <summary>Properties of the operation</summary>
    public partial class OperationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IOperationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IOperationPropertiesInternal
    {

        /// <summary>Internal Acessors for ServiceSpecification</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IServiceSpecification Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IOperationPropertiesInternal.ServiceSpecification { get => (this._serviceSpecification = this._serviceSpecification ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ServiceSpecification()); set { {_serviceSpecification = value;} } }

        /// <summary>Backing field for <see cref="ServiceSpecification" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IServiceSpecification _serviceSpecification;

        /// <summary>Service specification payload</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IServiceSpecification ServiceSpecification { get => (this._serviceSpecification = this._serviceSpecification ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ServiceSpecification()); set => this._serviceSpecification = value; }

        /// <summary>Specifications of the Log for Azure Monitoring</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ILogSpecification[] ServiceSpecificationLogSpecification { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IServiceSpecificationInternal)ServiceSpecification).LogSpecification; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IServiceSpecificationInternal)ServiceSpecification).LogSpecification = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="OperationProperties" /> instance.</summary>
        public OperationProperties()
        {

        }
    }
    /// Properties of the operation
    public partial interface IOperationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.IJsonSerializable
    {
        /// <summary>Specifications of the Log for Azure Monitoring</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Specifications of the Log for Azure Monitoring",
        SerializedName = @"logSpecifications",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ILogSpecification) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ILogSpecification[] ServiceSpecificationLogSpecification { get; set; }

    }
    /// Properties of the operation
    internal partial interface IOperationPropertiesInternal

    {
        /// <summary>Service specification payload</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IServiceSpecification ServiceSpecification { get; set; }
        /// <summary>Specifications of the Log for Azure Monitoring</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ILogSpecification[] ServiceSpecificationLogSpecification { get; set; }

    }
}