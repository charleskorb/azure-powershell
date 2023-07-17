namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview
{
    using Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.PowerShell;

    /// <summary>Represents a Workspace definition.</summary>
    [System.ComponentModel.TypeConverter(typeof(WorkspaceTypeConverter))]
    public partial class Workspace
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.Workspace"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspace"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspace DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Workspace(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.Workspace"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspace"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspace DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Workspace(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Workspace" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspace FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.Workspace"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Workspace(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.WorkspacePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20.SystemDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.TrackedResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).IdentityTenantId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).SkuName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).SkuTier = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SkuTier?) content.GetValueForProperty("SkuTier",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).SkuTier, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SkuTier.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).SkuSize = (string) content.GetValueForProperty("SkuSize",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).SkuSize, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).SkuFamily = (string) content.GetValueForProperty("SkuFamily",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).SkuFamily, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).PlanName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).PlanPublisher = (string) content.GetValueForProperty("PlanPublisher",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).PlanPublisher, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).PlanProduct = (string) content.GetValueForProperty("PlanProduct",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).PlanProduct, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).PlanPromotionCode = (string) content.GetValueForProperty("PlanPromotionCode",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).PlanPromotionCode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).PlanVersion = (string) content.GetValueForProperty("PlanVersion",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).PlanVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).IdentityType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.ResourceIdentityType?) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).IdentityType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.ResourceIdentityType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).SkuCapacity = (int?) content.GetValueForProperty("SkuCapacity",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).SkuCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IdentityTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.SkuTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).Plan = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IPlan) content.GetValueForProperty("Plan",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).Plan, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.PlanTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).ManagedBy = (string) content.GetValueForProperty("ManagedBy",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).ManagedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).Kind, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).Etag, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).ObjectId = (string) content.GetValueForProperty("ObjectId",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).ObjectId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).Description, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).FriendlyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).ApplicationGroupReference = (string[]) content.GetValueForProperty("ApplicationGroupReference",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).ApplicationGroupReference, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).CloudPcResource = (bool?) content.GetValueForProperty("CloudPcResource",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).CloudPcResource, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).PublicNetworkAccess = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.PublicNetworkAccess?) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).PublicNetworkAccess, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.PublicNetworkAccess.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).PrivateEndpointConnection = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20.IPrivateEndpointConnection[]) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20.IPrivateEndpointConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20.PrivateEndpointConnectionTypeConverter.ConvertFrom));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.Workspace"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Workspace(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.WorkspacePropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20.SystemDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceAutoGeneratedInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.TrackedResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).IdentityTenantId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).SkuName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).SkuTier = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SkuTier?) content.GetValueForProperty("SkuTier",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).SkuTier, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SkuTier.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).SkuSize = (string) content.GetValueForProperty("SkuSize",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).SkuSize, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).SkuFamily = (string) content.GetValueForProperty("SkuFamily",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).SkuFamily, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).PlanName = (string) content.GetValueForProperty("PlanName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).PlanName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).PlanPublisher = (string) content.GetValueForProperty("PlanPublisher",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).PlanPublisher, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).PlanProduct = (string) content.GetValueForProperty("PlanProduct",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).PlanProduct, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).PlanPromotionCode = (string) content.GetValueForProperty("PlanPromotionCode",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).PlanPromotionCode, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).PlanVersion = (string) content.GetValueForProperty("PlanVersion",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).PlanVersion, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).IdentityType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.ResourceIdentityType?) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).IdentityType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.ResourceIdentityType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).SkuCapacity = (int?) content.GetValueForProperty("SkuCapacity",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).SkuCapacity, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IIdentity) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IdentityTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.ISku) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.SkuTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).Plan = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IPlan) content.GetValueForProperty("Plan",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).Plan, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.PlanTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).ManagedBy = (string) content.GetValueForProperty("ManagedBy",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).ManagedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).Kind = (string) content.GetValueForProperty("Kind",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).Kind, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).Etag = (string) content.GetValueForProperty("Etag",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetInternal)this).Etag, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).ObjectId = (string) content.GetValueForProperty("ObjectId",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).ObjectId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).Description, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).FriendlyName = (string) content.GetValueForProperty("FriendlyName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).FriendlyName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).ApplicationGroupReference = (string[]) content.GetValueForProperty("ApplicationGroupReference",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).ApplicationGroupReference, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).CloudPcResource = (bool?) content.GetValueForProperty("CloudPcResource",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).CloudPcResource, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).PublicNetworkAccess = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.PublicNetworkAccess?) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).PublicNetworkAccess, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.PublicNetworkAccess.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).PrivateEndpointConnection = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20.IPrivateEndpointConnection[]) content.GetValueForProperty("PrivateEndpointConnection",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IWorkspaceInternal)this).PrivateEndpointConnection, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20.IPrivateEndpointConnection>(__y, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20.PrivateEndpointConnectionTypeConverter.ConvertFrom));
            AfterDeserializePSObject(content);
        }
    }
    /// Represents a Workspace definition.
    [System.ComponentModel.TypeConverter(typeof(WorkspaceTypeConverter))]
    public partial interface IWorkspace

    {

    }
}