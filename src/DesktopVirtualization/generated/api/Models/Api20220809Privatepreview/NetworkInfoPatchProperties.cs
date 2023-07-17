namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Extensions;

    /// <summary>Network information.</summary>
    public partial class NetworkInfoPatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.INetworkInfoPatchProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.INetworkInfoPatchPropertiesInternal
    {

        /// <summary>Backing field for <see cref="SecurityGroupId" /> property.</summary>
        private string _securityGroupId;

        /// <summary>
        /// The resource ID of the security group. Any allowable/open ports should be specified in the NSG.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public string SecurityGroupId { get => this._securityGroupId; set => this._securityGroupId = value; }

        /// <summary>Backing field for <see cref="SubnetId" /> property.</summary>
        private string _subnetId;

        /// <summary>The resource ID of the subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public string SubnetId { get => this._subnetId; set => this._subnetId = value; }

        /// <summary>Creates an new <see cref="NetworkInfoPatchProperties" /> instance.</summary>
        public NetworkInfoPatchProperties()
        {

        }
    }
    /// Network information.
    public partial interface INetworkInfoPatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The resource ID of the security group. Any allowable/open ports should be specified in the NSG.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource ID of the security group. Any allowable/open ports should be specified in the NSG.",
        SerializedName = @"securityGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string SecurityGroupId { get; set; }
        /// <summary>The resource ID of the subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource ID of the subnet.",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string SubnetId { get; set; }

    }
    /// Network information.
    internal partial interface INetworkInfoPatchPropertiesInternal

    {
        /// <summary>
        /// The resource ID of the security group. Any allowable/open ports should be specified in the NSG.
        /// </summary>
        string SecurityGroupId { get; set; }
        /// <summary>The resource ID of the subnet.</summary>
        string SubnetId { get; set; }

    }
}