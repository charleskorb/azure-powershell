namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Extensions;

    /// <summary>Hashtable that lists key/value pair tags to apply to the VMs</summary>
    public partial class ActiveSessionHostConfigurationPropertiesVMTags :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfigurationPropertiesVMTags,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IActiveSessionHostConfigurationPropertiesVMTagsInternal
    {

        /// <summary>
        /// Creates an new <see cref="ActiveSessionHostConfigurationPropertiesVMTags" /> instance.
        /// </summary>
        public ActiveSessionHostConfigurationPropertiesVMTags()
        {

        }
    }
    /// Hashtable that lists key/value pair tags to apply to the VMs
    public partial interface IActiveSessionHostConfigurationPropertiesVMTags :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.IAssociativeArray<string>
    {

    }
    /// Hashtable that lists key/value pair tags to apply to the VMs
    internal partial interface IActiveSessionHostConfigurationPropertiesVMTagsInternal

    {

    }
}