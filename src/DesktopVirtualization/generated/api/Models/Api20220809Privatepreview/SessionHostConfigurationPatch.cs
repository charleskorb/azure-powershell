namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Extensions;

    /// <summary>Represents a SessionHostConfigurationPatch definition.</summary>
    public partial class SessionHostConfigurationPatch :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatch,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchInternal
    {

        /// <summary>The domain a virtual machine connected to a hostpool will join.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string ActiveDirectoryInfoDomainName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).ActiveDirectoryInfoDomainName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).ActiveDirectoryInfoDomainName = value ?? null; }

        /// <summary>The ou path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string ActiveDirectoryInfoOuPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).ActiveDirectoryInfoOuPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).ActiveDirectoryInfoOuPath = value ?? null; }

        /// <summary>
        /// Value for availability zones to be used by the session host. Should be from [1,2,3].
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public int[] AvailabilityZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).AvailabilityZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).AvailabilityZone = value ?? null /* arrayOf */; }

        /// <summary>The mdm guid.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string AzureActiveDirectoryInfoMdmProviderGuid { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).AzureActiveDirectoryInfoMdmProviderGuid; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).AzureActiveDirectoryInfoMdmProviderGuid = value ?? null; }

        /// <summary>Whether boot diagnostics should be enabled on the Virtual Machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public bool? BootDiagnosticInfoEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).BootDiagnosticInfoEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).BootDiagnosticInfoEnabled = value ?? default(bool); }

        /// <summary>
        /// Uri of the storage account to use for placing the console output and screenshot. <br><br>If storageUri is not specified
        /// while enabling boot diagnostics, managed storage will be used.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string BootDiagnosticInfoStorageUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).BootDiagnosticInfoStorageUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).BootDiagnosticInfoStorageUri = value ?? null; }

        /// <summary>
        /// The uri to the storage blob containing the arm template to be run on the virtual machine after provisioning.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string CustomConfigurationScriptUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).CustomConfigurationScriptUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).CustomConfigurationScriptUrl = value ?? null; }

        /// <summary>The resource id of the custom image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string CustomInfoResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).CustomInfoResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).CustomInfoResourceId = value ?? null; }

        /// <summary>The disk type used by virtual machine in hostpool session host.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.VirtualMachineDiskType? DiskInfoType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).DiskInfoType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).DiskInfoType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.VirtualMachineDiskType)""); }

        /// <summary>The uri to access the secret that the password is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string DomainCredentialsPasswordKeyVaultSecretUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).DomainCredentialsPasswordKeyVaultSecretUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).DomainCredentialsPasswordKeyVaultSecretUri = value ?? null; }

        /// <summary>The uri to access the secret that the username is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string DomainCredentialsUsernameKeyVaultSecretUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).DomainCredentialsUsernameKeyVaultSecretUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).DomainCredentialsUsernameKeyVaultSecretUri = value ?? null; }

        /// <summary>The type of domain join done by the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.DomainJoinType? DomainInfoJoinType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).DomainInfoJoinType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).DomainInfoJoinType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.DomainJoinType)""); }

        /// <summary>Friendly name to describe this version of the SessionHostConfiguration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).FriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).FriendlyName = value ?? null; }

        /// <summary>The type of image session hosts use in the hostpool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.Type? ImageInfoType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).ImageInfoType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).ImageInfoType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.Type)""); }

        /// <summary>The exact version of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string MarketplaceInfoExactVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).MarketplaceInfoExactVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).MarketplaceInfoExactVersion = value ?? null; }

        /// <summary>The offer of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string MarketplaceInfoOffer { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).MarketplaceInfoOffer; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).MarketplaceInfoOffer = value ?? null; }

        /// <summary>The publisher of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string MarketplaceInfoPublisher { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).MarketplaceInfoPublisher; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).MarketplaceInfoPublisher = value ?? null; }

        /// <summary>The sku of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string MarketplaceInfoSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).MarketplaceInfoSku; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).MarketplaceInfoSku = value ?? null; }

        /// <summary>Internal Acessors for ActiveDirectoryInfoDomainCredentials</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IKeyVaultCredentialsPatchProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchInternal.ActiveDirectoryInfoDomainCredentials { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).ActiveDirectoryInfoDomainCredentials; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).ActiveDirectoryInfoDomainCredentials = value; }

        /// <summary>Internal Acessors for BootDiagnosticsInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IBootDiagnosticsInfoPatchProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchInternal.BootDiagnosticsInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).BootDiagnosticsInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).BootDiagnosticsInfo = value; }

        /// <summary>Internal Acessors for DiskInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDiskInfoPatchProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchInternal.DiskInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).DiskInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).DiskInfo = value; }

        /// <summary>Internal Acessors for DomainInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPatchProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchInternal.DomainInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).DomainInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).DomainInfo = value; }

        /// <summary>Internal Acessors for DomainInfoActiveDirectoryInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveDirectoryInfoPatchProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchInternal.DomainInfoActiveDirectoryInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).DomainInfoActiveDirectoryInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).DomainInfoActiveDirectoryInfo = value; }

        /// <summary>Internal Acessors for DomainInfoAzureActiveDirectoryInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IAzureActiveDirectoryInfoPatchProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchInternal.DomainInfoAzureActiveDirectoryInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).DomainInfoAzureActiveDirectoryInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).DomainInfoAzureActiveDirectoryInfo = value; }

        /// <summary>Internal Acessors for ImageInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IImageInfoPatchProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchInternal.ImageInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).ImageInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).ImageInfo = value; }

        /// <summary>Internal Acessors for ImageInfoCustomInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ICustomInfoPatchProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchInternal.ImageInfoCustomInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).ImageInfoCustomInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).ImageInfoCustomInfo = value; }

        /// <summary>Internal Acessors for ImageInfoMarketplaceInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IMarketplaceInfoPatchProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchInternal.ImageInfoMarketplaceInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).ImageInfoMarketplaceInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).ImageInfoMarketplaceInfo = value; }

        /// <summary>Internal Acessors for NetworkInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.INetworkInfoProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchInternal.NetworkInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).NetworkInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).NetworkInfo = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.SessionHostConfigurationPatchProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for SecurityInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISecurityInfoPatchProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchInternal.SecurityInfo { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).SecurityInfo; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).SecurityInfo = value; }

        /// <summary>Internal Acessors for VMAdminCredentials</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IKeyVaultCredentialsPatchProperties Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchInternal.VMAdminCredentials { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).VMAdminCredentials; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).VMAdminCredentials = value; }

        /// <summary>
        /// The resource ID of the security group. Any allowable/open ports should be specified in the NSG.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string NetworkInfoSecurityGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).NetworkInfoSecurityGroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).NetworkInfoSecurityGroupId = value ?? null; }

        /// <summary>The resource ID of the subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string NetworkInfoSubnetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).NetworkInfoSubnetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).NetworkInfoSubnetId = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchProperties _property;

        /// <summary>Detailed properties for SessionHostConfigurationPatch</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.SessionHostConfigurationPatchProperties()); set => this._property = value; }

        /// <summary>Whether to use secureBoot on the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public bool? SecurityInfoSecureBootEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).SecurityInfoSecureBootEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).SecurityInfoSecureBootEnabled = value ?? default(bool); }

        /// <summary>The security type used by virtual machine in hostpool session host.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.VirtualMachineSecurityType? SecurityInfoType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).SecurityInfoType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).SecurityInfoType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.VirtualMachineSecurityType)""); }

        /// <summary>Whether to use vTPM on the virtual machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public bool? SecurityInfoVTpmEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).SecurityInfoVTpmEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).SecurityInfoVTpmEnabled = value ?? default(bool); }

        /// <summary>The uri to access the secret that the password is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string VMAdminCredentialsPasswordKeyVaultSecretUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).VMAdminCredentialsPasswordKeyVaultSecretUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).VMAdminCredentialsPasswordKeyVaultSecretUri = value ?? null; }

        /// <summary>The uri to access the secret that the username is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string VMAdminCredentialsUsernameKeyVaultSecretUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).VMAdminCredentialsUsernameKeyVaultSecretUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).VMAdminCredentialsUsernameKeyVaultSecretUri = value ?? null; }

        /// <summary>The Location for the session host to be created in</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string VMLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).VMLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).VMLocation = value ?? null; }

        /// <summary>The prefix that should be associated with session host names</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string VMNamePrefix { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).VMNamePrefix; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).VMNamePrefix = value ?? null; }

        /// <summary>
        /// The ResourceGroup for the session hosts to be created in. It will default to the ResourceGroup of the hostpool if not
        /// provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string VMResourceGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).VMResourceGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).VMResourceGroup = value ?? null; }

        /// <summary>The id of the size of a virtual machine connected to a hostpool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public string VMSizeId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).VMSizeId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).VMSizeId = value ?? null; }

        /// <summary>Hashtable that lists key/value pair tags to apply to the VMs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesVMTags VMTag { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).VMTag; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesInternal)Property).VMTag = value ?? null /* model class */; }

        /// <summary>Creates an new <see cref="SessionHostConfigurationPatch" /> instance.</summary>
        public SessionHostConfigurationPatch()
        {

        }
    }
    /// Represents a SessionHostConfigurationPatch definition.
    public partial interface ISessionHostConfigurationPatch :
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
        Required = false,
        ReadOnly = false,
        Description = @"The disk type used by virtual machine in hostpool session host.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.VirtualMachineDiskType) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.VirtualMachineDiskType? DiskInfoType { get; set; }
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
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.DomainJoinType? DomainInfoJoinType { get; set; }
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
        Required = false,
        ReadOnly = false,
        Description = @"The type of image session hosts use in the hostpool.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.Type) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.Type? ImageInfoType { get; set; }
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
        Required = false,
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
        /// <summary>The security type used by virtual machine in hostpool session host.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The security type used by virtual machine in hostpool session host.",
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
        Required = false,
        ReadOnly = false,
        Description = @"The uri to access the secret that the password is stored in.",
        SerializedName = @"passwordKeyVaultSecretUri",
        PossibleTypes = new [] { typeof(string) })]
        string VMAdminCredentialsPasswordKeyVaultSecretUri { get; set; }
        /// <summary>The uri to access the secret that the username is stored in.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The uri to access the secret that the username is stored in.",
        SerializedName = @"usernameKeyVaultSecretUri",
        PossibleTypes = new [] { typeof(string) })]
        string VMAdminCredentialsUsernameKeyVaultSecretUri { get; set; }
        /// <summary>The Location for the session host to be created in</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Location for the session host to be created in",
        SerializedName = @"vmLocation",
        PossibleTypes = new [] { typeof(string) })]
        string VMLocation { get; set; }
        /// <summary>The prefix that should be associated with session host names</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(
        Required = false,
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
        Required = false,
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
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesVMTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesVMTags VMTag { get; set; }

    }
    /// Represents a SessionHostConfigurationPatch definition.
    internal partial interface ISessionHostConfigurationPatchInternal

    {
        /// <summary>Credentials needed to create the virtual machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IKeyVaultCredentialsPatchProperties ActiveDirectoryInfoDomainCredentials { get; set; }
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
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IBootDiagnosticsInfoPatchProperties BootDiagnosticsInfo { get; set; }
        /// <summary>
        /// The uri to the storage blob containing the arm template to be run on the virtual machine after provisioning.
        /// </summary>
        string CustomConfigurationScriptUrl { get; set; }
        /// <summary>The resource id of the custom image.</summary>
        string CustomInfoResourceId { get; set; }
        /// <summary>Disk information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDiskInfoPatchProperties DiskInfo { get; set; }
        /// <summary>The disk type used by virtual machine in hostpool session host.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.VirtualMachineDiskType? DiskInfoType { get; set; }
        /// <summary>The uri to access the secret that the password is stored in.</summary>
        string DomainCredentialsPasswordKeyVaultSecretUri { get; set; }
        /// <summary>The uri to access the secret that the username is stored in.</summary>
        string DomainCredentialsUsernameKeyVaultSecretUri { get; set; }
        /// <summary>Domain configurations of session hosts.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPatchProperties DomainInfo { get; set; }
        /// <summary>Active directory info. Only one should be populated based on the join type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveDirectoryInfoPatchProperties DomainInfoActiveDirectoryInfo { get; set; }
        /// <summary>
        /// Azure active directory info. Only one should be populated based on the join type.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IAzureActiveDirectoryInfoPatchProperties DomainInfoAzureActiveDirectoryInfo { get; set; }
        /// <summary>The type of domain join done by the virtual machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.DomainJoinType? DomainInfoJoinType { get; set; }
        /// <summary>Friendly name to describe this version of the SessionHostConfiguration.</summary>
        string FriendlyName { get; set; }
        /// <summary>Image configurations of HostPool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IImageInfoPatchProperties ImageInfo { get; set; }
        /// <summary>
        /// The values to uniquely identify a custom image. Only one should be populated based on the image type.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ICustomInfoPatchProperties ImageInfoCustomInfo { get; set; }
        /// <summary>
        /// The values to uniquely identify a marketplace image. Only one should be populated based on the image type.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IMarketplaceInfoPatchProperties ImageInfoMarketplaceInfo { get; set; }
        /// <summary>The type of image session hosts use in the hostpool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.Type? ImageInfoType { get; set; }
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
        /// <summary>Detailed properties for SessionHostConfigurationPatch</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchProperties Property { get; set; }
        /// <summary>Security information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISecurityInfoPatchProperties SecurityInfo { get; set; }
        /// <summary>Whether to use secureBoot on the virtual machine.</summary>
        bool? SecurityInfoSecureBootEnabled { get; set; }
        /// <summary>The security type used by virtual machine in hostpool session host.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.VirtualMachineSecurityType? SecurityInfoType { get; set; }
        /// <summary>Whether to use vTPM on the virtual machine.</summary>
        bool? SecurityInfoVTpmEnabled { get; set; }
        /// <summary>Local Admin credentials for session hosts.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IKeyVaultCredentialsPatchProperties VMAdminCredentials { get; set; }
        /// <summary>The uri to access the secret that the password is stored in.</summary>
        string VMAdminCredentialsPasswordKeyVaultSecretUri { get; set; }
        /// <summary>The uri to access the secret that the username is stored in.</summary>
        string VMAdminCredentialsUsernameKeyVaultSecretUri { get; set; }
        /// <summary>The Location for the session host to be created in</summary>
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
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesVMTags VMTag { get; set; }

    }
}