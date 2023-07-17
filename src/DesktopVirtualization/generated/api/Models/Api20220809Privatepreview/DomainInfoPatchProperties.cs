namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Extensions;

    /// <summary>Domain configurations of session hosts.</summary>
    public partial class DomainInfoPatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPatchProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPatchPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ActiveDirectoryInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveDirectoryInfoPatchProperties _activeDirectoryInfo;

        /// <summary>Active directory info. Only one should be populated based on the join type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveDirectoryInfoPatchProperties ActiveDirectoryInfo { get => (this._activeDirectoryInfo = this._activeDirectoryInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ActiveDirectoryInfoPatchProperties()); set => this._activeDirectoryInfo = value; }

        /// <summary>The domain a virtual machine connected to a hostpool will join.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string ActiveDirectoryInfoDomainName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveDirectoryInfoPatchPropertiesInternal)ActiveDirectoryInfo).DomainName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveDirectoryInfoPatchPropertiesInternal)ActiveDirectoryInfo).DomainName = value ?? null; }

        /// <summary>The ou path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string ActiveDirectoryInfoOuPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveDirectoryInfoPatchPropertiesInternal)ActiveDirectoryInfo).OuPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveDirectoryInfoPatchPropertiesInternal)ActiveDirectoryInfo).OuPath = value ?? null; }

        /// <summary>Backing field for <see cref="AzureActiveDirectoryInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IAzureActiveDirectoryInfoPatchProperties _azureActiveDirectoryInfo;

        /// <summary>
        /// Azure active directory info. Only one should be populated based on the join type.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IAzureActiveDirectoryInfoPatchProperties AzureActiveDirectoryInfo { get => (this._azureActiveDirectoryInfo = this._azureActiveDirectoryInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.AzureActiveDirectoryInfoPatchProperties()); set => this._azureActiveDirectoryInfo = value; }

        /// <summary>The mdm guid.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string AzureActiveDirectoryInfoMdmProviderGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IAzureActiveDirectoryInfoPatchPropertiesInternal)AzureActiveDirectoryInfo).MdmProviderGuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IAzureActiveDirectoryInfoPatchPropertiesInternal)AzureActiveDirectoryInfo).MdmProviderGuid = value ?? null; }

        /// <summary>The uri to access the secret that the password is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string DomainCredentialsPasswordKeyVaultSecretUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveDirectoryInfoPatchPropertiesInternal)ActiveDirectoryInfo).DomainCredentialsPasswordKeyVaultSecretUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveDirectoryInfoPatchPropertiesInternal)ActiveDirectoryInfo).DomainCredentialsPasswordKeyVaultSecretUri = value ?? null; }

        /// <summary>The uri to access the secret that the username is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string DomainCredentialsUsernameKeyVaultSecretUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveDirectoryInfoPatchPropertiesInternal)ActiveDirectoryInfo).DomainCredentialsUsernameKeyVaultSecretUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveDirectoryInfoPatchPropertiesInternal)ActiveDirectoryInfo).DomainCredentialsUsernameKeyVaultSecretUri = value ?? null; }

        /// <summary>Backing field for <see cref="JoinType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.DomainJoinType? _joinType;

        /// <summary>The type of domain join done by the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.DomainJoinType? JoinType { get => this._joinType; set => this._joinType = value; }

        /// <summary>Internal Acessors for ActiveDirectoryInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveDirectoryInfoPatchProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPatchPropertiesInternal.ActiveDirectoryInfo { get => (this._activeDirectoryInfo = this._activeDirectoryInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ActiveDirectoryInfoPatchProperties()); set { {_activeDirectoryInfo = value;} } }

        /// <summary>Internal Acessors for ActiveDirectoryInfoDomainCredentials</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IKeyVaultCredentialsPatchProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPatchPropertiesInternal.ActiveDirectoryInfoDomainCredentials { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveDirectoryInfoPatchPropertiesInternal)ActiveDirectoryInfo).DomainCredentials; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveDirectoryInfoPatchPropertiesInternal)ActiveDirectoryInfo).DomainCredentials = value; }

        /// <summary>Internal Acessors for AzureActiveDirectoryInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IAzureActiveDirectoryInfoPatchProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPatchPropertiesInternal.AzureActiveDirectoryInfo { get => (this._azureActiveDirectoryInfo = this._azureActiveDirectoryInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.AzureActiveDirectoryInfoPatchProperties()); set { {_azureActiveDirectoryInfo = value;} } }

        /// <summary>Creates an new <see cref="DomainInfoPatchProperties" /> instance.</summary>
        public DomainInfoPatchProperties()
        {

        }
    }
    /// Domain configurations of session hosts.
    public partial interface IDomainInfoPatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.IJsonSerializable
    {
        /// <summary>The domain a virtual machine connected to a hostpool will join.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The domain a virtual machine connected to a hostpool will join.",
        SerializedName = @"domainName",
        PossibleTypes = new [] { typeof(string) })]
        string ActiveDirectoryInfoDomainName { get; set; }
        /// <summary>The ou path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ou path.",
        SerializedName = @"ouPath",
        PossibleTypes = new [] { typeof(string) })]
        string ActiveDirectoryInfoOuPath { get; set; }
        /// <summary>The mdm guid.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The mdm guid.",
        SerializedName = @"mdmProviderGuid",
        PossibleTypes = new [] { typeof(string) })]
        string AzureActiveDirectoryInfoMdmProviderGuid { get; set; }
        /// <summary>The uri to access the secret that the password is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The uri to access the secret that the password is stored in.",
        SerializedName = @"passwordKeyVaultSecretUri",
        PossibleTypes = new [] { typeof(string) })]
        string DomainCredentialsPasswordKeyVaultSecretUri { get; set; }
        /// <summary>The uri to access the secret that the username is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The uri to access the secret that the username is stored in.",
        SerializedName = @"usernameKeyVaultSecretUri",
        PossibleTypes = new [] { typeof(string) })]
        string DomainCredentialsUsernameKeyVaultSecretUri { get; set; }
        /// <summary>The type of domain join done by the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of domain join done by the virtual machine.",
        SerializedName = @"joinType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.DomainJoinType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.DomainJoinType? JoinType { get; set; }

    }
    /// Domain configurations of session hosts.
    internal partial interface IDomainInfoPatchPropertiesInternal

    {
        /// <summary>Active directory info. Only one should be populated based on the join type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveDirectoryInfoPatchProperties ActiveDirectoryInfo { get; set; }
        /// <summary>Credentials needed to create the virtual machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IKeyVaultCredentialsPatchProperties ActiveDirectoryInfoDomainCredentials { get; set; }
        /// <summary>The domain a virtual machine connected to a hostpool will join.</summary>
        string ActiveDirectoryInfoDomainName { get; set; }
        /// <summary>The ou path.</summary>
        string ActiveDirectoryInfoOuPath { get; set; }
        /// <summary>
        /// Azure active directory info. Only one should be populated based on the join type.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IAzureActiveDirectoryInfoPatchProperties AzureActiveDirectoryInfo { get; set; }
        /// <summary>The mdm guid.</summary>
        string AzureActiveDirectoryInfoMdmProviderGuid { get; set; }
        /// <summary>The uri to access the secret that the password is stored in.</summary>
        string DomainCredentialsPasswordKeyVaultSecretUri { get; set; }
        /// <summary>The uri to access the secret that the username is stored in.</summary>
        string DomainCredentialsUsernameKeyVaultSecretUri { get; set; }
        /// <summary>The type of domain join done by the virtual machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.DomainJoinType? JoinType { get; set; }

    }
}