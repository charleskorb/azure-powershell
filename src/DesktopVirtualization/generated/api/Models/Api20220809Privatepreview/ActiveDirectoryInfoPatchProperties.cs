namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Extensions;

    /// <summary>Active directory info. Only one should be populated based on the join type.</summary>
    public partial class ActiveDirectoryInfoPatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveDirectoryInfoPatchProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveDirectoryInfoPatchPropertiesInternal
    {

        /// <summary>Backing field for <see cref="DomainCredentials" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IKeyVaultCredentialsPatchProperties _domainCredentials;

        /// <summary>Credentials needed to create the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IKeyVaultCredentialsPatchProperties DomainCredentials { get => (this._domainCredentials = this._domainCredentials ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.KeyVaultCredentialsPatchProperties()); set => this._domainCredentials = value; }

        /// <summary>The uri to access the secret that the password is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string DomainCredentialsPasswordKeyVaultSecretUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IKeyVaultCredentialsPatchPropertiesInternal)DomainCredentials).PasswordKeyVaultSecretUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IKeyVaultCredentialsPatchPropertiesInternal)DomainCredentials).PasswordKeyVaultSecretUri = value ?? null; }

        /// <summary>The uri to access the secret that the username is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string DomainCredentialsUsernameKeyVaultSecretUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IKeyVaultCredentialsPatchPropertiesInternal)DomainCredentials).UsernameKeyVaultSecretUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IKeyVaultCredentialsPatchPropertiesInternal)DomainCredentials).UsernameKeyVaultSecretUri = value ?? null; }

        /// <summary>Backing field for <see cref="DomainName" /> property.</summary>
        private string _domainName;

        /// <summary>The domain a virtual machine connected to a hostpool will join.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public string DomainName { get => this._domainName; set => this._domainName = value; }

        /// <summary>Internal Acessors for DomainCredentials</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IKeyVaultCredentialsPatchProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveDirectoryInfoPatchPropertiesInternal.DomainCredentials { get => (this._domainCredentials = this._domainCredentials ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.KeyVaultCredentialsPatchProperties()); set { {_domainCredentials = value;} } }

        /// <summary>Backing field for <see cref="OuPath" /> property.</summary>
        private string _ouPath;

        /// <summary>The ou path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public string OuPath { get => this._ouPath; set => this._ouPath = value; }

        /// <summary>Creates an new <see cref="ActiveDirectoryInfoPatchProperties" /> instance.</summary>
        public ActiveDirectoryInfoPatchProperties()
        {

        }
    }
    /// Active directory info. Only one should be populated based on the join type.
    public partial interface IActiveDirectoryInfoPatchProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.IJsonSerializable
    {
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
        /// <summary>The domain a virtual machine connected to a hostpool will join.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The domain a virtual machine connected to a hostpool will join.",
        SerializedName = @"domainName",
        PossibleTypes = new [] { typeof(string) })]
        string DomainName { get; set; }
        /// <summary>The ou path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ou path.",
        SerializedName = @"ouPath",
        PossibleTypes = new [] { typeof(string) })]
        string OuPath { get; set; }

    }
    /// Active directory info. Only one should be populated based on the join type.
    internal partial interface IActiveDirectoryInfoPatchPropertiesInternal

    {
        /// <summary>Credentials needed to create the virtual machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IKeyVaultCredentialsPatchProperties DomainCredentials { get; set; }
        /// <summary>The uri to access the secret that the password is stored in.</summary>
        string DomainCredentialsPasswordKeyVaultSecretUri { get; set; }
        /// <summary>The uri to access the secret that the username is stored in.</summary>
        string DomainCredentialsUsernameKeyVaultSecretUri { get; set; }
        /// <summary>The domain a virtual machine connected to a hostpool will join.</summary>
        string DomainName { get; set; }
        /// <summary>The ou path.</summary>
        string OuPath { get; set; }

    }
}