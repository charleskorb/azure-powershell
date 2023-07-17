namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Extensions;

    /// <summary>Session host configurations of HostPool.</summary>
    public partial class ActiveSessionHostConfigurationProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfigurationProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfigurationPropertiesInternal
    {

        /// <summary>The domain a virtual machine connected to a hostpool will join.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string ActiveDirectoryInfoDomainName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)DomainInfo).ActiveDirectoryInfoDomainName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)DomainInfo).ActiveDirectoryInfoDomainName = value ?? null; }

        /// <summary>The ou path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string ActiveDirectoryInfoOuPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)DomainInfo).ActiveDirectoryInfoOuPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)DomainInfo).ActiveDirectoryInfoOuPath = value ?? null; }

        /// <summary>Backing field for <see cref="AvailabilityZone" /> property.</summary>
        private int[] _availabilityZone;

        /// <summary>
        /// Value for availability zones to be used by the session host. Should be from [1,2,3].
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public int[] AvailabilityZone { get => this._availabilityZone; set => this._availabilityZone = value; }

        /// <summary>The mdm guid.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string AzureActiveDirectoryInfoMdmProviderGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)DomainInfo).AzureActiveDirectoryInfoMdmProviderGuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)DomainInfo).AzureActiveDirectoryInfoMdmProviderGuid = value ?? null; }

        /// <summary>Whether boot diagnostics should be enabled on the Virtual Machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public bool? BootDiagnosticInfoEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IBootDiagnosticsInfoPropertiesInternal)BootDiagnosticsInfo).Enabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IBootDiagnosticsInfoPropertiesInternal)BootDiagnosticsInfo).Enabled = value ?? default(bool); }

        /// <summary>
        /// Uri of the storage account to use for placing the console output and screenshot. <br><br>If storageUri is not specified
        /// while enabling boot diagnostics, managed storage will be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string BootDiagnosticInfoStorageUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IBootDiagnosticsInfoPropertiesInternal)BootDiagnosticsInfo).StorageUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IBootDiagnosticsInfoPropertiesInternal)BootDiagnosticsInfo).StorageUri = value ?? null; }

        /// <summary>Backing field for <see cref="BootDiagnosticsInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IBootDiagnosticsInfoProperties _bootDiagnosticsInfo;

        /// <summary>Boot Diagnostics information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IBootDiagnosticsInfoProperties BootDiagnosticsInfo { get => (this._bootDiagnosticsInfo = this._bootDiagnosticsInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.BootDiagnosticsInfoProperties()); set => this._bootDiagnosticsInfo = value; }

        /// <summary>Backing field for <see cref="CustomConfigurationScriptUrl" /> property.</summary>
        private string _customConfigurationScriptUrl;

        /// <summary>
        /// The uri to the storage blob containing the arm template to be run on the virtual machine after provisioning.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public string CustomConfigurationScriptUrl { get => this._customConfigurationScriptUrl; set => this._customConfigurationScriptUrl = value; }

        /// <summary>The resource id of the custom image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string CustomInfoResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IImageInfoPropertiesInternal)ImageInfo).CustomInfoResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IImageInfoPropertiesInternal)ImageInfo).CustomInfoResourceId = value ?? null; }

        /// <summary>Backing field for <see cref="DiskInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDiskInfoProperties _diskInfo;

        /// <summary>Disk information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDiskInfoProperties DiskInfo { get => (this._diskInfo = this._diskInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.DiskInfoProperties()); set => this._diskInfo = value; }

        /// <summary>The disk type used by virtual machine in hostpool session host.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.VirtualMachineDiskType DiskInfoType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDiskInfoPropertiesInternal)DiskInfo).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDiskInfoPropertiesInternal)DiskInfo).Type = value ; }

        /// <summary>The uri to access the secret that the password is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string DomainCredentialsPasswordKeyVaultSecretUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)DomainInfo).DomainCredentialsPasswordKeyVaultSecretUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)DomainInfo).DomainCredentialsPasswordKeyVaultSecretUri = value ?? null; }

        /// <summary>The uri to access the secret that the username is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string DomainCredentialsUsernameKeyVaultSecretUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)DomainInfo).DomainCredentialsUsernameKeyVaultSecretUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)DomainInfo).DomainCredentialsUsernameKeyVaultSecretUri = value ?? null; }

        /// <summary>Backing field for <see cref="DomainInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoProperties _domainInfo;

        /// <summary>Domain configurations of session hosts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoProperties DomainInfo { get => (this._domainInfo = this._domainInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.DomainInfoProperties()); set => this._domainInfo = value; }

        /// <summary>The type of domain join done by the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.DomainJoinType DomainInfoJoinType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)DomainInfo).JoinType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)DomainInfo).JoinType = value ; }

        /// <summary>Backing field for <see cref="FriendlyName" /> property.</summary>
        private string _friendlyName;

        /// <summary>Friendly name to describe this version of the SessionHostConfiguration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public string FriendlyName { get => this._friendlyName; set => this._friendlyName = value; }

        /// <summary>Backing field for <see cref="ImageInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IImageInfoProperties _imageInfo;

        /// <summary>Image configurations of HostPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IImageInfoProperties ImageInfo { get => (this._imageInfo = this._imageInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ImageInfoProperties()); set => this._imageInfo = value; }

        /// <summary>The type of image session hosts use in the hostpool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.Type ImageInfoType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IImageInfoPropertiesInternal)ImageInfo).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IImageInfoPropertiesInternal)ImageInfo).Type = value ; }

        /// <summary>The exact version of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string MarketplaceInfoExactVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IImageInfoPropertiesInternal)ImageInfo).MarketplaceInfoExactVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IImageInfoPropertiesInternal)ImageInfo).MarketplaceInfoExactVersion = value ?? null; }

        /// <summary>The offer of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string MarketplaceInfoOffer { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IImageInfoPropertiesInternal)ImageInfo).MarketplaceInfoOffer; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IImageInfoPropertiesInternal)ImageInfo).MarketplaceInfoOffer = value ?? null; }

        /// <summary>The publisher of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string MarketplaceInfoPublisher { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IImageInfoPropertiesInternal)ImageInfo).MarketplaceInfoPublisher; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IImageInfoPropertiesInternal)ImageInfo).MarketplaceInfoPublisher = value ?? null; }

        /// <summary>The sku of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string MarketplaceInfoSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IImageInfoPropertiesInternal)ImageInfo).MarketplaceInfoSku; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IImageInfoPropertiesInternal)ImageInfo).MarketplaceInfoSku = value ?? null; }

        /// <summary>Internal Acessors for ActiveDirectoryInfoDomainCredentials</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IKeyVaultCredentialsProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfigurationPropertiesInternal.ActiveDirectoryInfoDomainCredentials { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)DomainInfo).ActiveDirectoryInfoDomainCredentials; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)DomainInfo).ActiveDirectoryInfoDomainCredentials = value; }

        /// <summary>Internal Acessors for BootDiagnosticsInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IBootDiagnosticsInfoProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfigurationPropertiesInternal.BootDiagnosticsInfo { get => (this._bootDiagnosticsInfo = this._bootDiagnosticsInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.BootDiagnosticsInfoProperties()); set { {_bootDiagnosticsInfo = value;} } }

        /// <summary>Internal Acessors for DiskInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDiskInfoProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfigurationPropertiesInternal.DiskInfo { get => (this._diskInfo = this._diskInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.DiskInfoProperties()); set { {_diskInfo = value;} } }

        /// <summary>Internal Acessors for DomainInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfigurationPropertiesInternal.DomainInfo { get => (this._domainInfo = this._domainInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.DomainInfoProperties()); set { {_domainInfo = value;} } }

        /// <summary>Internal Acessors for DomainInfoActiveDirectoryInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveDirectoryInfoProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfigurationPropertiesInternal.DomainInfoActiveDirectoryInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)DomainInfo).ActiveDirectoryInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)DomainInfo).ActiveDirectoryInfo = value; }

        /// <summary>Internal Acessors for DomainInfoAzureActiveDirectoryInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IAzureActiveDirectoryInfoProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfigurationPropertiesInternal.DomainInfoAzureActiveDirectoryInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)DomainInfo).AzureActiveDirectoryInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)DomainInfo).AzureActiveDirectoryInfo = value; }

        /// <summary>Internal Acessors for ImageInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IImageInfoProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfigurationPropertiesInternal.ImageInfo { get => (this._imageInfo = this._imageInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ImageInfoProperties()); set { {_imageInfo = value;} } }

        /// <summary>Internal Acessors for ImageInfoCustomInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ICustomInfoProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfigurationPropertiesInternal.ImageInfoCustomInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IImageInfoPropertiesInternal)ImageInfo).CustomInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IImageInfoPropertiesInternal)ImageInfo).CustomInfo = value; }

        /// <summary>Internal Acessors for ImageInfoMarketplaceInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IMarketplaceInfoProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfigurationPropertiesInternal.ImageInfoMarketplaceInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IImageInfoPropertiesInternal)ImageInfo).MarketplaceInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IImageInfoPropertiesInternal)ImageInfo).MarketplaceInfo = value; }

        /// <summary>Internal Acessors for NetworkInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.INetworkInfoProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfigurationPropertiesInternal.NetworkInfo { get => (this._networkInfo = this._networkInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.NetworkInfoProperties()); set { {_networkInfo = value;} } }

        /// <summary>Internal Acessors for SecurityInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISecurityInfoProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfigurationPropertiesInternal.SecurityInfo { get => (this._securityInfo = this._securityInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.SecurityInfoProperties()); set { {_securityInfo = value;} } }

        /// <summary>Internal Acessors for VMAdminCredentials</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IKeyVaultCredentialsProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfigurationPropertiesInternal.VMAdminCredentials { get => (this._vMAdminCredentials = this._vMAdminCredentials ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.KeyVaultCredentialsProperties()); set { {_vMAdminCredentials = value;} } }

        /// <summary>Internal Acessors for Version</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfigurationPropertiesInternal.Version { get => this._version; set { {_version = value;} } }

        /// <summary>Backing field for <see cref="NetworkInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.INetworkInfoProperties _networkInfo;

        /// <summary>Network information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.INetworkInfoProperties NetworkInfo { get => (this._networkInfo = this._networkInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.NetworkInfoProperties()); set => this._networkInfo = value; }

        /// <summary>
        /// The resource ID of the security group. Any allowable/open ports should be specified in the NSG.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string NetworkInfoSecurityGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.INetworkInfoPropertiesInternal)NetworkInfo).SecurityGroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.INetworkInfoPropertiesInternal)NetworkInfo).SecurityGroupId = value ?? null; }

        /// <summary>The resource ID of the subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string NetworkInfoSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.INetworkInfoPropertiesInternal)NetworkInfo).SubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.INetworkInfoPropertiesInternal)NetworkInfo).SubnetId = value ; }

        /// <summary>Backing field for <see cref="SecurityInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISecurityInfoProperties _securityInfo;

        /// <summary>Security information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISecurityInfoProperties SecurityInfo { get => (this._securityInfo = this._securityInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.SecurityInfoProperties()); set => this._securityInfo = value; }

        /// <summary>Whether to use secureBoot on the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public bool? SecurityInfoSecureBootEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISecurityInfoPropertiesInternal)SecurityInfo).SecureBootEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISecurityInfoPropertiesInternal)SecurityInfo).SecureBootEnabled = value ?? default(bool); }

        /// <summary>
        /// The security type used by virtual machine in hostpool session host. Default is Standard.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.VirtualMachineSecurityType? SecurityInfoType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISecurityInfoPropertiesInternal)SecurityInfo).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISecurityInfoPropertiesInternal)SecurityInfo).Type = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.VirtualMachineSecurityType)""); }

        /// <summary>Whether to use vTPM on the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public bool? SecurityInfoVTpmEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISecurityInfoPropertiesInternal)SecurityInfo).VTpmEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISecurityInfoPropertiesInternal)SecurityInfo).VTpmEnabled = value ?? default(bool); }

        /// <summary>Backing field for <see cref="VMAdminCredentials" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IKeyVaultCredentialsProperties _vMAdminCredentials;

        /// <summary>Local Admin credentials for session hosts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IKeyVaultCredentialsProperties VMAdminCredentials { get => (this._vMAdminCredentials = this._vMAdminCredentials ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.KeyVaultCredentialsProperties()); set => this._vMAdminCredentials = value; }

        /// <summary>The uri to access the secret that the password is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string VMAdminCredentialsPasswordKeyVaultSecretUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IKeyVaultCredentialsPropertiesInternal)VMAdminCredentials).PasswordKeyVaultSecretUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IKeyVaultCredentialsPropertiesInternal)VMAdminCredentials).PasswordKeyVaultSecretUri = value ; }

        /// <summary>The uri to access the secret that the username is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string VMAdminCredentialsUsernameKeyVaultSecretUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IKeyVaultCredentialsPropertiesInternal)VMAdminCredentials).UsernameKeyVaultSecretUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IKeyVaultCredentialsPropertiesInternal)VMAdminCredentials).UsernameKeyVaultSecretUri = value ; }

        /// <summary>Backing field for <see cref="VMLocation" /> property.</summary>
        private string _vMLocation;

        /// <summary>
        /// The Location for the session host to be created in. It will default to the location of the hostpool if not provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public string VMLocation { get => this._vMLocation; set => this._vMLocation = value; }

        /// <summary>Backing field for <see cref="VMNamePrefix" /> property.</summary>
        private string _vMNamePrefix;

        /// <summary>The prefix that should be associated with session host names</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public string VMNamePrefix { get => this._vMNamePrefix; set => this._vMNamePrefix = value; }

        /// <summary>Backing field for <see cref="VMResourceGroup" /> property.</summary>
        private string _vMResourceGroup;

        /// <summary>
        /// The ResourceGroup for the session hosts to be created in. It will default to the ResourceGroup of the hostpool if not
        /// provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public string VMResourceGroup { get => this._vMResourceGroup; set => this._vMResourceGroup = value; }

        /// <summary>Backing field for <see cref="VMSizeId" /> property.</summary>
        private string _vMSizeId;

        /// <summary>The id of the size of a virtual machine connected to a hostpool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public string VMSizeId { get => this._vMSizeId; set => this._vMSizeId = value; }

        /// <summary>Backing field for <see cref="VMTag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfigurationPropertiesVMTags _vMTag;

        /// <summary>Hashtable that lists key/value pair tags to apply to the VMs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfigurationPropertiesVMTags VMTag { get => (this._vMTag = this._vMTag ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ActiveSessionHostConfigurationPropertiesVMTags()); set => this._vMTag = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private global::System.DateTime? _version;

        /// <summary>The timestamp of the last update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        public global::System.DateTime? Version { get => this._version; }

        /// <summary>
        /// Creates an new <see cref="ActiveSessionHostConfigurationProperties" /> instance.
        /// </summary>
        public ActiveSessionHostConfigurationProperties()
        {

        }
    }
    /// Session host configurations of HostPool.
    public partial interface IActiveSessionHostConfigurationProperties :
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
        /// <summary>
        /// Value for availability zones to be used by the session host. Should be from [1,2,3].
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Value for availability zones to be used by the session host. Should be from [1,2,3].",
        SerializedName = @"availabilityZones",
        PossibleTypes = new [] { typeof(int) })]
        int[] AvailabilityZone { get; set; }
        /// <summary>The mdm guid.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The mdm guid.",
        SerializedName = @"mdmProviderGuid",
        PossibleTypes = new [] { typeof(string) })]
        string AzureActiveDirectoryInfoMdmProviderGuid { get; set; }
        /// <summary>Whether boot diagnostics should be enabled on the Virtual Machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether boot diagnostics should be enabled on the Virtual Machine.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? BootDiagnosticInfoEnabled { get; set; }
        /// <summary>
        /// Uri of the storage account to use for placing the console output and screenshot. <br><br>If storageUri is not specified
        /// while enabling boot diagnostics, managed storage will be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Uri of the storage account to use for placing the console output and screenshot. <br><br>If storageUri is not specified while enabling boot diagnostics, managed storage will be used.",
        SerializedName = @"storageUri",
        PossibleTypes = new [] { typeof(string) })]
        string BootDiagnosticInfoStorageUri { get; set; }
        /// <summary>
        /// The uri to the storage blob containing the arm template to be run on the virtual machine after provisioning.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The uri to the storage blob containing the arm template to be run on the virtual machine after provisioning.",
        SerializedName = @"customConfigurationScriptUrl",
        PossibleTypes = new [] { typeof(string) })]
        string CustomConfigurationScriptUrl { get; set; }
        /// <summary>The resource id of the custom image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource id of the custom image.",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string CustomInfoResourceId { get; set; }
        /// <summary>The disk type used by virtual machine in hostpool session host.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The disk type used by virtual machine in hostpool session host.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.VirtualMachineDiskType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.VirtualMachineDiskType DiskInfoType { get; set; }
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
        Required = true,
        ReadOnly = false,
        Description = @"The type of domain join done by the virtual machine.",
        SerializedName = @"joinType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.DomainJoinType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.DomainJoinType DomainInfoJoinType { get; set; }
        /// <summary>Friendly name to describe this version of the SessionHostConfiguration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Friendly name to describe this version of the SessionHostConfiguration.",
        SerializedName = @"friendlyName",
        PossibleTypes = new [] { typeof(string) })]
        string FriendlyName { get; set; }
        /// <summary>The type of image session hosts use in the hostpool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The type of image session hosts use in the hostpool.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.Type) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.Type ImageInfoType { get; set; }
        /// <summary>The exact version of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The exact version of the image.",
        SerializedName = @"exactVersion",
        PossibleTypes = new [] { typeof(string) })]
        string MarketplaceInfoExactVersion { get; set; }
        /// <summary>The offer of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The offer of the image.",
        SerializedName = @"offer",
        PossibleTypes = new [] { typeof(string) })]
        string MarketplaceInfoOffer { get; set; }
        /// <summary>The publisher of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The publisher of the image.",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string MarketplaceInfoPublisher { get; set; }
        /// <summary>The sku of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The sku of the image.",
        SerializedName = @"sku",
        PossibleTypes = new [] { typeof(string) })]
        string MarketplaceInfoSku { get; set; }
        /// <summary>
        /// The resource ID of the security group. Any allowable/open ports should be specified in the NSG.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource ID of the security group. Any allowable/open ports should be specified in the NSG.",
        SerializedName = @"securityGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkInfoSecurityGroupId { get; set; }
        /// <summary>The resource ID of the subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The resource ID of the subnet.",
        SerializedName = @"subnetId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkInfoSubnetId { get; set; }
        /// <summary>Whether to use secureBoot on the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether to use secureBoot on the virtual machine.",
        SerializedName = @"secureBootEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SecurityInfoSecureBootEnabled { get; set; }
        /// <summary>
        /// The security type used by virtual machine in hostpool session host. Default is Standard.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The security type used by virtual machine in hostpool session host. Default is Standard.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.VirtualMachineSecurityType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.VirtualMachineSecurityType? SecurityInfoType { get; set; }
        /// <summary>Whether to use vTPM on the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether to use vTPM on the virtual machine.",
        SerializedName = @"vTpmEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SecurityInfoVTpmEnabled { get; set; }
        /// <summary>The uri to access the secret that the password is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The uri to access the secret that the password is stored in.",
        SerializedName = @"passwordKeyVaultSecretUri",
        PossibleTypes = new [] { typeof(string) })]
        string VMAdminCredentialsPasswordKeyVaultSecretUri { get; set; }
        /// <summary>The uri to access the secret that the username is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The uri to access the secret that the username is stored in.",
        SerializedName = @"usernameKeyVaultSecretUri",
        PossibleTypes = new [] { typeof(string) })]
        string VMAdminCredentialsUsernameKeyVaultSecretUri { get; set; }
        /// <summary>
        /// The Location for the session host to be created in. It will default to the location of the hostpool if not provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Location for the session host to be created in. It will default to the location of the hostpool if not provided.",
        SerializedName = @"vmLocation",
        PossibleTypes = new [] { typeof(string) })]
        string VMLocation { get; set; }
        /// <summary>The prefix that should be associated with session host names</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The prefix that should be associated with session host names",
        SerializedName = @"vmNamePrefix",
        PossibleTypes = new [] { typeof(string) })]
        string VMNamePrefix { get; set; }
        /// <summary>
        /// The ResourceGroup for the session hosts to be created in. It will default to the ResourceGroup of the hostpool if not
        /// provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ResourceGroup for the session hosts to be created in. It will default to the ResourceGroup of the hostpool if not provided.",
        SerializedName = @"vmResourceGroup",
        PossibleTypes = new [] { typeof(string) })]
        string VMResourceGroup { get; set; }
        /// <summary>The id of the size of a virtual machine connected to a hostpool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The id of the size of a virtual machine connected to a hostpool.",
        SerializedName = @"vmSizeId",
        PossibleTypes = new [] { typeof(string) })]
        string VMSizeId { get; set; }
        /// <summary>Hashtable that lists key/value pair tags to apply to the VMs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Hashtable that lists key/value pair tags to apply to the VMs",
        SerializedName = @"vmTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfigurationPropertiesVMTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfigurationPropertiesVMTags VMTag { get; set; }
        /// <summary>The timestamp of the last update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The timestamp of the last update.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? Version { get;  }

    }
    /// Session host configurations of HostPool.
    internal partial interface IActiveSessionHostConfigurationPropertiesInternal

    {
        /// <summary>Credentials needed to create the virtual machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IKeyVaultCredentialsProperties ActiveDirectoryInfoDomainCredentials { get; set; }
        /// <summary>The domain a virtual machine connected to a hostpool will join.</summary>
        string ActiveDirectoryInfoDomainName { get; set; }
        /// <summary>The ou path.</summary>
        string ActiveDirectoryInfoOuPath { get; set; }
        /// <summary>
        /// Value for availability zones to be used by the session host. Should be from [1,2,3].
        /// </summary>
        int[] AvailabilityZone { get; set; }
        /// <summary>The mdm guid.</summary>
        string AzureActiveDirectoryInfoMdmProviderGuid { get; set; }
        /// <summary>Whether boot diagnostics should be enabled on the Virtual Machine.</summary>
        bool? BootDiagnosticInfoEnabled { get; set; }
        /// <summary>
        /// Uri of the storage account to use for placing the console output and screenshot. <br><br>If storageUri is not specified
        /// while enabling boot diagnostics, managed storage will be used.
        /// </summary>
        string BootDiagnosticInfoStorageUri { get; set; }
        /// <summary>Boot Diagnostics information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IBootDiagnosticsInfoProperties BootDiagnosticsInfo { get; set; }
        /// <summary>
        /// The uri to the storage blob containing the arm template to be run on the virtual machine after provisioning.
        /// </summary>
        string CustomConfigurationScriptUrl { get; set; }
        /// <summary>The resource id of the custom image.</summary>
        string CustomInfoResourceId { get; set; }
        /// <summary>Disk information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDiskInfoProperties DiskInfo { get; set; }
        /// <summary>The disk type used by virtual machine in hostpool session host.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.VirtualMachineDiskType DiskInfoType { get; set; }
        /// <summary>The uri to access the secret that the password is stored in.</summary>
        string DomainCredentialsPasswordKeyVaultSecretUri { get; set; }
        /// <summary>The uri to access the secret that the username is stored in.</summary>
        string DomainCredentialsUsernameKeyVaultSecretUri { get; set; }
        /// <summary>Domain configurations of session hosts.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoProperties DomainInfo { get; set; }
        /// <summary>Active directory info. Only one should be populated based on the join type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveDirectoryInfoProperties DomainInfoActiveDirectoryInfo { get; set; }
        /// <summary>
        /// Azure active directory info. Only one should be populated based on the join type.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IAzureActiveDirectoryInfoProperties DomainInfoAzureActiveDirectoryInfo { get; set; }
        /// <summary>The type of domain join done by the virtual machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.DomainJoinType DomainInfoJoinType { get; set; }
        /// <summary>Friendly name to describe this version of the SessionHostConfiguration.</summary>
        string FriendlyName { get; set; }
        /// <summary>Image configurations of HostPool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IImageInfoProperties ImageInfo { get; set; }
        /// <summary>
        /// The values to uniquely identify a custom image. Only one should be populated based on the image type.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ICustomInfoProperties ImageInfoCustomInfo { get; set; }
        /// <summary>
        /// The values to uniquely identify a marketplace image. Only one should be populated based on the image type.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IMarketplaceInfoProperties ImageInfoMarketplaceInfo { get; set; }
        /// <summary>The type of image session hosts use in the hostpool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.Type ImageInfoType { get; set; }
        /// <summary>The exact version of the image.</summary>
        string MarketplaceInfoExactVersion { get; set; }
        /// <summary>The offer of the image.</summary>
        string MarketplaceInfoOffer { get; set; }
        /// <summary>The publisher of the image.</summary>
        string MarketplaceInfoPublisher { get; set; }
        /// <summary>The sku of the image.</summary>
        string MarketplaceInfoSku { get; set; }
        /// <summary>Network information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.INetworkInfoProperties NetworkInfo { get; set; }
        /// <summary>
        /// The resource ID of the security group. Any allowable/open ports should be specified in the NSG.
        /// </summary>
        string NetworkInfoSecurityGroupId { get; set; }
        /// <summary>The resource ID of the subnet.</summary>
        string NetworkInfoSubnetId { get; set; }
        /// <summary>Security information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISecurityInfoProperties SecurityInfo { get; set; }
        /// <summary>Whether to use secureBoot on the virtual machine.</summary>
        bool? SecurityInfoSecureBootEnabled { get; set; }
        /// <summary>
        /// The security type used by virtual machine in hostpool session host. Default is Standard.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.VirtualMachineSecurityType? SecurityInfoType { get; set; }
        /// <summary>Whether to use vTPM on the virtual machine.</summary>
        bool? SecurityInfoVTpmEnabled { get; set; }
        /// <summary>Local Admin credentials for session hosts.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IKeyVaultCredentialsProperties VMAdminCredentials { get; set; }
        /// <summary>The uri to access the secret that the password is stored in.</summary>
        string VMAdminCredentialsPasswordKeyVaultSecretUri { get; set; }
        /// <summary>The uri to access the secret that the username is stored in.</summary>
        string VMAdminCredentialsUsernameKeyVaultSecretUri { get; set; }
        /// <summary>
        /// The Location for the session host to be created in. It will default to the location of the hostpool if not provided.
        /// </summary>
        string VMLocation { get; set; }
        /// <summary>The prefix that should be associated with session host names</summary>
        string VMNamePrefix { get; set; }
        /// <summary>
        /// The ResourceGroup for the session hosts to be created in. It will default to the ResourceGroup of the hostpool if not
        /// provided.
        /// </summary>
        string VMResourceGroup { get; set; }
        /// <summary>The id of the size of a virtual machine connected to a hostpool.</summary>
        string VMSizeId { get; set; }
        /// <summary>Hashtable that lists key/value pair tags to apply to the VMs</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfigurationPropertiesVMTags VMTag { get; set; }
        /// <summary>The timestamp of the last update.</summary>
        global::System.DateTime? Version { get; set; }

    }
}