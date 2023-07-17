namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview
{
    using Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.PowerShell;

    /// <summary>A ScalingPlanPooledSchedule.</summary>
    [System.ComponentModel.TypeConverter(typeof(ScalingPlanPooledSchedulePropertiesTypeConverter))]
    public partial class ScalingPlanPooledScheduleProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ScalingPlanPooledScheduleProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledScheduleProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledScheduleProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ScalingPlanPooledScheduleProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ScalingPlanPooledScheduleProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledScheduleProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledScheduleProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ScalingPlanPooledScheduleProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ScalingPlanPooledScheduleProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledScheduleProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ScalingPlanPooledScheduleProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ScalingPlanPooledScheduleProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampUpStartTime = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ITime) content.GetValueForProperty("RampUpStartTime",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampUpStartTime, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.TimeTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).PeakStartTime = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ITime) content.GetValueForProperty("PeakStartTime",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).PeakStartTime, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.TimeTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownStartTime = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ITime) content.GetValueForProperty("RampDownStartTime",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownStartTime, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.TimeTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).OffPeakStartTime = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ITime) content.GetValueForProperty("OffPeakStartTime",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).OffPeakStartTime, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.TimeTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).DaysOfWeek = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.DayOfWeek[]) content.GetValueForProperty("DaysOfWeek",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).DaysOfWeek, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.DayOfWeek>(__y, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.DayOfWeek.CreateFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampUpLoadBalancingAlgorithm = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionHostLoadBalancingAlgorithm?) content.GetValueForProperty("RampUpLoadBalancingAlgorithm",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampUpLoadBalancingAlgorithm, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionHostLoadBalancingAlgorithm.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampUpMinimumHostsPct = (int?) content.GetValueForProperty("RampUpMinimumHostsPct",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampUpMinimumHostsPct, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampUpCapacityThresholdPct = (int?) content.GetValueForProperty("RampUpCapacityThresholdPct",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampUpCapacityThresholdPct, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).PeakLoadBalancingAlgorithm = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionHostLoadBalancingAlgorithm?) content.GetValueForProperty("PeakLoadBalancingAlgorithm",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).PeakLoadBalancingAlgorithm, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionHostLoadBalancingAlgorithm.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownLoadBalancingAlgorithm = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionHostLoadBalancingAlgorithm?) content.GetValueForProperty("RampDownLoadBalancingAlgorithm",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownLoadBalancingAlgorithm, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionHostLoadBalancingAlgorithm.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownMinimumHostsPct = (int?) content.GetValueForProperty("RampDownMinimumHostsPct",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownMinimumHostsPct, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownCapacityThresholdPct = (int?) content.GetValueForProperty("RampDownCapacityThresholdPct",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownCapacityThresholdPct, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownForceLogoffUser = (bool?) content.GetValueForProperty("RampDownForceLogoffUser",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownForceLogoffUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownStopHostsWhen = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.StopHostsWhen?) content.GetValueForProperty("RampDownStopHostsWhen",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownStopHostsWhen, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.StopHostsWhen.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownWaitTimeMinute = (int?) content.GetValueForProperty("RampDownWaitTimeMinute",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownWaitTimeMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownNotificationMessage = (string) content.GetValueForProperty("RampDownNotificationMessage",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownNotificationMessage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).OffPeakLoadBalancingAlgorithm = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionHostLoadBalancingAlgorithm?) content.GetValueForProperty("OffPeakLoadBalancingAlgorithm",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).OffPeakLoadBalancingAlgorithm, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionHostLoadBalancingAlgorithm.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampUpStartTimeHour = (int) content.GetValueForProperty("RampUpStartTimeHour",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampUpStartTimeHour, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampUpStartTimeMinute = (int) content.GetValueForProperty("RampUpStartTimeMinute",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampUpStartTimeMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).PeakStartTimeHour = (int) content.GetValueForProperty("PeakStartTimeHour",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).PeakStartTimeHour, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).PeakStartTimeMinute = (int) content.GetValueForProperty("PeakStartTimeMinute",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).PeakStartTimeMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownStartTimeHour = (int) content.GetValueForProperty("RampDownStartTimeHour",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownStartTimeHour, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownStartTimeMinute = (int) content.GetValueForProperty("RampDownStartTimeMinute",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownStartTimeMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).OffPeakStartTimeHour = (int) content.GetValueForProperty("OffPeakStartTimeHour",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).OffPeakStartTimeHour, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).OffPeakStartTimeMinute = (int) content.GetValueForProperty("OffPeakStartTimeMinute",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).OffPeakStartTimeMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ScalingPlanPooledScheduleProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ScalingPlanPooledScheduleProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampUpStartTime = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ITime) content.GetValueForProperty("RampUpStartTime",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampUpStartTime, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.TimeTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).PeakStartTime = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ITime) content.GetValueForProperty("PeakStartTime",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).PeakStartTime, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.TimeTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownStartTime = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ITime) content.GetValueForProperty("RampDownStartTime",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownStartTime, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.TimeTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).OffPeakStartTime = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ITime) content.GetValueForProperty("OffPeakStartTime",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).OffPeakStartTime, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.TimeTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).DaysOfWeek = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.DayOfWeek[]) content.GetValueForProperty("DaysOfWeek",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).DaysOfWeek, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.DayOfWeek>(__y, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.DayOfWeek.CreateFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampUpLoadBalancingAlgorithm = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionHostLoadBalancingAlgorithm?) content.GetValueForProperty("RampUpLoadBalancingAlgorithm",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampUpLoadBalancingAlgorithm, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionHostLoadBalancingAlgorithm.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampUpMinimumHostsPct = (int?) content.GetValueForProperty("RampUpMinimumHostsPct",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampUpMinimumHostsPct, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampUpCapacityThresholdPct = (int?) content.GetValueForProperty("RampUpCapacityThresholdPct",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampUpCapacityThresholdPct, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).PeakLoadBalancingAlgorithm = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionHostLoadBalancingAlgorithm?) content.GetValueForProperty("PeakLoadBalancingAlgorithm",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).PeakLoadBalancingAlgorithm, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionHostLoadBalancingAlgorithm.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownLoadBalancingAlgorithm = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionHostLoadBalancingAlgorithm?) content.GetValueForProperty("RampDownLoadBalancingAlgorithm",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownLoadBalancingAlgorithm, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionHostLoadBalancingAlgorithm.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownMinimumHostsPct = (int?) content.GetValueForProperty("RampDownMinimumHostsPct",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownMinimumHostsPct, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownCapacityThresholdPct = (int?) content.GetValueForProperty("RampDownCapacityThresholdPct",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownCapacityThresholdPct, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownForceLogoffUser = (bool?) content.GetValueForProperty("RampDownForceLogoffUser",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownForceLogoffUser, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownStopHostsWhen = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.StopHostsWhen?) content.GetValueForProperty("RampDownStopHostsWhen",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownStopHostsWhen, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.StopHostsWhen.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownWaitTimeMinute = (int?) content.GetValueForProperty("RampDownWaitTimeMinute",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownWaitTimeMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownNotificationMessage = (string) content.GetValueForProperty("RampDownNotificationMessage",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownNotificationMessage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).OffPeakLoadBalancingAlgorithm = (Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionHostLoadBalancingAlgorithm?) content.GetValueForProperty("OffPeakLoadBalancingAlgorithm",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).OffPeakLoadBalancingAlgorithm, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.SessionHostLoadBalancingAlgorithm.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampUpStartTimeHour = (int) content.GetValueForProperty("RampUpStartTimeHour",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampUpStartTimeHour, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampUpStartTimeMinute = (int) content.GetValueForProperty("RampUpStartTimeMinute",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampUpStartTimeMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).PeakStartTimeHour = (int) content.GetValueForProperty("PeakStartTimeHour",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).PeakStartTimeHour, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).PeakStartTimeMinute = (int) content.GetValueForProperty("PeakStartTimeMinute",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).PeakStartTimeMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownStartTimeHour = (int) content.GetValueForProperty("RampDownStartTimeHour",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownStartTimeHour, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownStartTimeMinute = (int) content.GetValueForProperty("RampDownStartTimeMinute",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).RampDownStartTimeMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).OffPeakStartTimeHour = (int) content.GetValueForProperty("OffPeakStartTimeHour",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).OffPeakStartTimeHour, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).OffPeakStartTimeMinute = (int) content.GetValueForProperty("OffPeakStartTimeMinute",((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IScalingPlanPooledSchedulePropertiesInternal)this).OffPeakStartTimeMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// A ScalingPlanPooledSchedule.
    [System.ComponentModel.TypeConverter(typeof(ScalingPlanPooledSchedulePropertiesTypeConverter))]
    public partial interface IScalingPlanPooledScheduleProperties

    {

    }
}