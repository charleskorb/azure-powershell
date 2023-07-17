namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview
{
    using Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.PowerShell;

    /// <summary>
    /// Object containing the definition for properties to be used in the sessionHostUpdate validation.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(ValidateSessionHostUpdateRequestBodyTypeConverter))]
    public partial class ValidateSessionHostUpdateRequestBody
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ValidateSessionHostUpdateRequestBody"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBody"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBody DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ValidateSessionHostUpdateRequestBody(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ValidateSessionHostUpdateRequestBody"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBody"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBody DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ValidateSessionHostUpdateRequestBody(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ValidateSessionHostUpdateRequestBody" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBody FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ValidateSessionHostUpdateRequestBody"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ValidateSessionHostUpdateRequestBody(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagement = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagement) content.GetValueForProperty("SessionHostManagement",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagement, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.SessionHostManagementTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).ScheduledDateTime = (global::System.DateTime?) content.GetValueForProperty("ScheduledDateTime",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).ScheduledDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfiguration) content.GetValueForProperty("SessionHostConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostConfiguration, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.SessionHostConfigurationTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemData = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20.ISystemData) content.GetValueForProperty("SessionHostManagementSystemData",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemData, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20.SystemDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementProperty = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementProperties) content.GetValueForProperty("SessionHostManagementProperty",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementProperty, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.SessionHostManagementPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemDataCreatedBy = (string) content.GetValueForProperty("SessionHostManagementSystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SessionHostManagementSystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementId = (string) content.GetValueForProperty("SessionHostManagementId",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementName = (string) content.GetValueForProperty("SessionHostManagementName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementType = (string) content.GetValueForProperty("SessionHostManagementType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType?) content.GetValueForProperty("SessionHostManagementSystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemDataLastModifiedBy = (string) content.GetValueForProperty("SessionHostManagementSystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType?) content.GetValueForProperty("SessionHostManagementSystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SessionHostManagementSystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).Update = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IHostPoolUpdateConfigurationProperties) content.GetValueForProperty("Update",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).Update, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.HostPoolUpdateConfigurationPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).ScheduledDateTimeZone = (string) content.GetValueForProperty("ScheduledDateTimeZone",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).ScheduledDateTimeZone, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).UpdateDeleteOriginalVM = (bool?) content.GetValueForProperty("UpdateDeleteOriginalVM",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).UpdateDeleteOriginalVM, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).UpdateMaxVmsRemoved = (int) content.GetValueForProperty("UpdateMaxVmsRemoved",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).UpdateMaxVmsRemoved, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).UpdateLogOffDelayMinute = (int) content.GetValueForProperty("UpdateLogOffDelayMinute",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).UpdateLogOffDelayMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).UpdateLogOffMessage = (string) content.GetValueForProperty("UpdateLogOffMessage",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).UpdateLogOffMessage, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ValidateSessionHostUpdateRequestBody"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ValidateSessionHostUpdateRequestBody(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagement = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagement) content.GetValueForProperty("SessionHostManagement",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagement, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.SessionHostManagementTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).ScheduledDateTime = (global::System.DateTime?) content.GetValueForProperty("ScheduledDateTime",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).ScheduledDateTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfiguration) content.GetValueForProperty("SessionHostConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostConfiguration, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.SessionHostConfigurationTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemData = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20.ISystemData) content.GetValueForProperty("SessionHostManagementSystemData",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemData, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20.SystemDataTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementProperty = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostManagementProperties) content.GetValueForProperty("SessionHostManagementProperty",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementProperty, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.SessionHostManagementPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemDataCreatedBy = (string) content.GetValueForProperty("SessionHostManagementSystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemDataCreatedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SessionHostManagementSystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementId = (string) content.GetValueForProperty("SessionHostManagementId",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementName = (string) content.GetValueForProperty("SessionHostManagementName",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementType = (string) content.GetValueForProperty("SessionHostManagementType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementType, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType?) content.GetValueForProperty("SessionHostManagementSystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemDataLastModifiedBy = (string) content.GetValueForProperty("SessionHostManagementSystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemDataLastModifiedBy, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType?) content.GetValueForProperty("SessionHostManagementSystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SessionHostManagementSystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).SessionHostManagementSystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).Update = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IHostPoolUpdateConfigurationProperties) content.GetValueForProperty("Update",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).Update, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.HostPoolUpdateConfigurationPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).ScheduledDateTimeZone = (string) content.GetValueForProperty("ScheduledDateTimeZone",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).ScheduledDateTimeZone, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).UpdateDeleteOriginalVM = (bool?) content.GetValueForProperty("UpdateDeleteOriginalVM",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).UpdateDeleteOriginalVM, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).UpdateMaxVmsRemoved = (int) content.GetValueForProperty("UpdateMaxVmsRemoved",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).UpdateMaxVmsRemoved, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).UpdateLogOffDelayMinute = (int) content.GetValueForProperty("UpdateLogOffDelayMinute",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).UpdateLogOffDelayMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).UpdateLogOffMessage = (string) content.GetValueForProperty("UpdateLogOffMessage",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBodyInternal)this).UpdateLogOffMessage, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }
    }
    /// Object containing the definition for properties to be used in the sessionHostUpdate validation.
    [System.ComponentModel.TypeConverter(typeof(ValidateSessionHostUpdateRequestBodyTypeConverter))]
    public partial interface IValidateSessionHostUpdateRequestBody

    {

    }
}