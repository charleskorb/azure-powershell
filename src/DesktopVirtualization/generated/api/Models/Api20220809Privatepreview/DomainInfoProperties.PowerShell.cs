namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview
{
    using Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.PowerShell;

    /// <summary>Domain configurations of session hosts.</summary>
    [System.ComponentModel.TypeConverter(typeof(DomainInfoPropertiesTypeConverter))]
    public partial class DomainInfoProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.DomainInfoProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DomainInfoProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.DomainInfoProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DomainInfoProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.DomainInfoProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DomainInfoProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).ActiveDirectoryInfo = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveDirectoryInfoProperties) content.GetValueForProperty("ActiveDirectoryInfo",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).ActiveDirectoryInfo, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ActiveDirectoryInfoPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).AzureActiveDirectoryInfo = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IAzureActiveDirectoryInfoProperties) content.GetValueForProperty("AzureActiveDirectoryInfo",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).AzureActiveDirectoryInfo, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.AzureActiveDirectoryInfoPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).JoinType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.DomainJoinType) content.GetValueForProperty("JoinType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).JoinType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.DomainJoinType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).ActiveDirectoryInfoDomainCredentials = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IKeyVaultCredentialsProperties) content.GetValueForProperty("ActiveDirectoryInfoDomainCredentials",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).ActiveDirectoryInfoDomainCredentials, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.KeyVaultCredentialsPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).ActiveDirectoryInfoOuPath = (string) content.GetValueForProperty("ActiveDirectoryInfoOuPath",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).ActiveDirectoryInfoOuPath, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).ActiveDirectoryInfoDomainName = (string) content.GetValueForProperty("ActiveDirectoryInfoDomainName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).ActiveDirectoryInfoDomainName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).AzureActiveDirectoryInfoMdmProviderGuid = (string) content.GetValueForProperty("AzureActiveDirectoryInfoMdmProviderGuid",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).AzureActiveDirectoryInfoMdmProviderGuid, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).DomainCredentialsUsernameKeyVaultSecretUri = (string) content.GetValueForProperty("DomainCredentialsUsernameKeyVaultSecretUri",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).DomainCredentialsUsernameKeyVaultSecretUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).DomainCredentialsPasswordKeyVaultSecretUri = (string) content.GetValueForProperty("DomainCredentialsPasswordKeyVaultSecretUri",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).DomainCredentialsPasswordKeyVaultSecretUri, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.DomainInfoProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DomainInfoProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).ActiveDirectoryInfo = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveDirectoryInfoProperties) content.GetValueForProperty("ActiveDirectoryInfo",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).ActiveDirectoryInfo, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ActiveDirectoryInfoPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).AzureActiveDirectoryInfo = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IAzureActiveDirectoryInfoProperties) content.GetValueForProperty("AzureActiveDirectoryInfo",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).AzureActiveDirectoryInfo, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.AzureActiveDirectoryInfoPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).JoinType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.DomainJoinType) content.GetValueForProperty("JoinType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).JoinType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.DomainJoinType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).ActiveDirectoryInfoDomainCredentials = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IKeyVaultCredentialsProperties) content.GetValueForProperty("ActiveDirectoryInfoDomainCredentials",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).ActiveDirectoryInfoDomainCredentials, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.KeyVaultCredentialsPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).ActiveDirectoryInfoOuPath = (string) content.GetValueForProperty("ActiveDirectoryInfoOuPath",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).ActiveDirectoryInfoOuPath, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).ActiveDirectoryInfoDomainName = (string) content.GetValueForProperty("ActiveDirectoryInfoDomainName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).ActiveDirectoryInfoDomainName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).AzureActiveDirectoryInfoMdmProviderGuid = (string) content.GetValueForProperty("AzureActiveDirectoryInfoMdmProviderGuid",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).AzureActiveDirectoryInfoMdmProviderGuid, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).DomainCredentialsUsernameKeyVaultSecretUri = (string) content.GetValueForProperty("DomainCredentialsUsernameKeyVaultSecretUri",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).DomainCredentialsUsernameKeyVaultSecretUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).DomainCredentialsPasswordKeyVaultSecretUri = (string) content.GetValueForProperty("DomainCredentialsPasswordKeyVaultSecretUri",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoPropertiesInternal)this).DomainCredentialsPasswordKeyVaultSecretUri, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DomainInfoProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IDomainInfoProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Domain configurations of session hosts.
    [System.ComponentModel.TypeConverter(typeof(DomainInfoPropertiesTypeConverter))]
    public partial interface IDomainInfoProperties

    {

    }
}