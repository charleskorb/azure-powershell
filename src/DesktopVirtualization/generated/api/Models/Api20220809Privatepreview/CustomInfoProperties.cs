namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Extensions;

    /// <summary>Custom image information.</summary>
    public partial class CustomInfoProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ICustomInfoProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ICustomInfoPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private string _resourceId;

        /// <summary>The resource id of the custom image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public string ResourceId { get => this._resourceId; set => this._resourceId = value; }

        /// <summary>Creates an new <see cref="CustomInfoProperties" /> instance.</summary>
        public CustomInfoProperties()
        {

        }
    }
    /// Custom image information.
    public partial interface ICustomInfoProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.IJsonSerializable
    {
        /// <summary>The resource id of the custom image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The resource id of the custom image.",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceId { get; set; }

    }
    /// Custom image information.
    internal partial interface ICustomInfoPropertiesInternal

    {
        /// <summary>The resource id of the custom image.</summary>
        string ResourceId { get; set; }

    }
}