namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Extensions;

    /// <summary>A list of private link resources</summary>
    public partial class PrivateLinkResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IPrivateLinkResourceListResult,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IPrivateLinkResourceListResultInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IPrivateLinkResourceListResultInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>Link to the next page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IPrivateLinkResource[] _value;

        /// <summary>Array of private link resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IPrivateLinkResource[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="PrivateLinkResourceListResult" /> instance.</summary>
        public PrivateLinkResourceListResult()
        {

        }
    }
    /// A list of private link resources
    public partial interface IPrivateLinkResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.IJsonSerializable
    {
        /// <summary>Link to the next page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Link to the next page of results.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>Array of private link resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Array of private link resources",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IPrivateLinkResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IPrivateLinkResource[] Value { get; set; }

    }
    /// A list of private link resources
    internal partial interface IPrivateLinkResourceListResultInternal

    {
        /// <summary>Link to the next page of results.</summary>
        string NextLink { get; set; }
        /// <summary>Array of private link resources</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IPrivateLinkResource[] Value { get; set; }

    }
}