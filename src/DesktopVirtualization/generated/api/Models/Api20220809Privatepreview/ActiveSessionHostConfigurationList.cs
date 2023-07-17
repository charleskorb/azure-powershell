namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Extensions;

    /// <summary>List of ActiveSessionHostConfiguration definitions.</summary>
    public partial class ActiveSessionHostConfigurationList :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfigurationList,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfigurationListInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfigurationListInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>Link to the next page of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfiguration[] _value;

        /// <summary>List of ActiveSessionHostConfiguration definitions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfiguration[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ActiveSessionHostConfigurationList" /> instance.</summary>
        public ActiveSessionHostConfigurationList()
        {

        }
    }
    /// List of ActiveSessionHostConfiguration definitions.
    public partial interface IActiveSessionHostConfigurationList :
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
        /// <summary>List of ActiveSessionHostConfiguration definitions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of ActiveSessionHostConfiguration definitions.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfiguration) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfiguration[] Value { get; set; }

    }
    /// List of ActiveSessionHostConfiguration definitions.
    internal partial interface IActiveSessionHostConfigurationListInternal

    {
        /// <summary>Link to the next page of results.</summary>
        string NextLink { get; set; }
        /// <summary>List of ActiveSessionHostConfiguration definitions.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfiguration[] Value { get; set; }

    }
}