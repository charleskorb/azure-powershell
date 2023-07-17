namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Extensions;

    /// <summary>Hashtable that lists key/value pair tags to apply to the VMs</summary>
    public partial class SessionHostConfigurationPatchPropertiesVMTags :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesVMTags,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPatchPropertiesVMTagsInternal
    {

        /// <summary>
        /// Creates an new <see cref="SessionHostConfigurationPatchPropertiesVMTags" /> instance.
        /// </summary>
        public SessionHostConfigurationPatchPropertiesVMTags()
        {

        }
    }
    /// Hashtable that lists key/value pair tags to apply to the VMs
    public partial interface ISessionHostConfigurationPatchPropertiesVMTags :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.IAssociativeArray<string>
    {

    }
    /// Hashtable that lists key/value pair tags to apply to the VMs
    internal partial interface ISessionHostConfigurationPatchPropertiesVMTagsInternal

    {

    }
}