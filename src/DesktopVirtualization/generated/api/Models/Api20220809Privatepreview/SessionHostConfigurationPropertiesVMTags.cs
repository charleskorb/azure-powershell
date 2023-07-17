namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Extensions;

    /// <summary>Hashtable that lists key/value pair tags to apply to the VMs</summary>
    public partial class SessionHostConfigurationPropertiesVMTags :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPropertiesVMTags,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPropertiesVMTagsInternal
    {

        /// <summary>
        /// Creates an new <see cref="SessionHostConfigurationPropertiesVMTags" /> instance.
        /// </summary>
        public SessionHostConfigurationPropertiesVMTags()
        {

        }
    }
    /// Hashtable that lists key/value pair tags to apply to the VMs
    public partial interface ISessionHostConfigurationPropertiesVMTags :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.IAssociativeArray<string>
    {

    }
    /// Hashtable that lists key/value pair tags to apply to the VMs
    internal partial interface ISessionHostConfigurationPropertiesVMTagsInternal

    {

    }
}