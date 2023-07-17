namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Extensions;

    /// <summary>
    /// Azure Active directory info. Only one should be populated based on the join type.
    /// </summary>
    public partial class AzureActiveDirectoryInfoPatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IAzureActiveDirectoryInfoPatchProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IAzureActiveDirectoryInfoPatchPropertiesInternal
    {

        /// <summary>Backing field for <see cref="MdmProviderGuid" /> property.</summary>
        private string _mdmProviderGuid;

        /// <summary>The mdm guid.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public string MdmProviderGuid { get => this._mdmProviderGuid; set => this._mdmProviderGuid = value; }

        /// <summary>Creates an new <see cref="AzureActiveDirectoryInfoPatchProperties" /> instance.</summary>
        public AzureActiveDirectoryInfoPatchProperties()
        {

        }
    }
    /// Azure Active directory info. Only one should be populated based on the join type.
    public partial interface IAzureActiveDirectoryInfoPatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.IJsonSerializable
    {
        /// <summary>The mdm guid.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The mdm guid.",
        SerializedName = @"mdmProviderGuid",
        PossibleTypes = new [] { typeof(string) })]
        string MdmProviderGuid { get; set; }

    }
    /// Azure Active directory info. Only one should be populated based on the join type.
    internal partial interface IAzureActiveDirectoryInfoPatchPropertiesInternal

    {
        /// <summary>The mdm guid.</summary>
        string MdmProviderGuid { get; set; }

    }
}