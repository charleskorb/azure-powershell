namespace Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Extensions;

    public partial class ResourceModelWithAllowedPropertySetIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IResourceModelWithAllowedPropertySetIdentityInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IIdentity"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IIdentity __identity = new Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.Identity();

        /// <summary>Internal Acessors for PrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IIdentityInternal.PrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IIdentityInternal)__identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IIdentityInternal)__identity).PrincipalId = value; }

        /// <summary>Internal Acessors for TenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IIdentityInternal.TenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IIdentityInternal)__identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IIdentityInternal)__identity).TenantId = value; }

        /// <summary>The principal ID of resource identity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inherited)]
        public string PrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IIdentityInternal)__identity).PrincipalId; }

        /// <summary>The tenant ID of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inherited)]
        public string TenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IIdentityInternal)__identity).TenantId; }

        /// <summary>The identity type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Origin(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.ResourceIdentityType? Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IIdentityInternal)__identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IIdentityInternal)__identity).Type = value; }

        /// <summary>
        /// Creates an new <see cref="ResourceModelWithAllowedPropertySetIdentity" /> instance.
        /// </summary>
        public ResourceModelWithAllowedPropertySetIdentity()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__identity), __identity);
            await eventListener.AssertObjectIsValid(nameof(__identity), __identity);
        }
    }
    public partial interface IResourceModelWithAllowedPropertySetIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IIdentity
    {

    }
    internal partial interface IResourceModelWithAllowedPropertySetIdentityInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.IIdentityInternal
    {

    }
}