
# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Validates a session host update operation for validation errors.
When Session Host Configuration and Session Host Management values are not provided the ones saved in the Host Pool will be used.
.Description
Validates a session host update operation for validation errors.
When Session Host Configuration and Session Host Management values are not provided the ones saved in the Host Pool will be used.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBody
.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IDesktopVirtualizationIdentity
.Outputs
System.Boolean
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IDesktopVirtualizationIdentity>: Identity Parameter
  [ApplicationGroupName <String>]: The name of the application group
  [ApplicationName <String>]: The name of the application within the specified application group
  [DesktopName <String>]: The name of the desktop within the specified desktop group
  [HostPoolName <String>]: The name of the host pool within the specified resource group
  [Id <String>]: Resource identity path
  [MsixPackageFullName <String>]: The version specific package full name of the MSIX package within specified hostpool
  [OperationId <String>]: The Guid of the operation.
  [PrivateEndpointConnectionName <String>]: The name of the private endpoint connection associated with the Azure resource
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScalingPlanName <String>]: The name of the scaling plan.
  [ScalingPlanScheduleName <String>]: The name of the ScalingPlanSchedule
  [SessionHostName <String>]: The name of the session host within the specified host pool
  [SubscriptionId <String>]: The ID of the target subscription.
  [UserSessionId <String>]: The name of the user session within the specified session host
  [WorkspaceName <String>]: The name of the workspace

SESSIONHOSTCONFIGURATION <ISessionHostConfiguration>: Object containing the definition for the SessionHostConfiguration to be validated. If none is provided the update will use the SessionHostConfiguration settings associated with the HostPool.
  DiskInfoType <VirtualMachineDiskType>: The disk type used by virtual machine in hostpool session host.
  DomainInfoJoinType <DomainJoinType>: The type of domain join done by the virtual machine.
  ImageInfoType <Type>: The type of image session hosts use in the hostpool.
  NetworkInfoSubnetId <String>: The resource ID of the subnet.
  VMAdminCredentialsPasswordKeyVaultSecretUri <String>: The uri to access the secret that the password is stored in.
  VMAdminCredentialsUsernameKeyVaultSecretUri <String>: The uri to access the secret that the username is stored in.
  VMNamePrefix <String>: The prefix that should be associated with session host names
  VMSizeId <String>: The id of the size of a virtual machine connected to a hostpool.
  [SystemDataCreatedAt <DateTime?>]: The timestamp of resource creation (UTC).
  [SystemDataCreatedBy <String>]: The identity that created the resource.
  [SystemDataCreatedByType <CreatedByType?>]: The type of identity that created the resource.
  [SystemDataLastModifiedAt <DateTime?>]: The timestamp of resource last modification (UTC)
  [SystemDataLastModifiedBy <String>]: The identity that last modified the resource.
  [SystemDataLastModifiedByType <CreatedByType?>]: The type of identity that last modified the resource.
  [ActiveDirectoryInfoDomainName <String>]: The domain a virtual machine connected to a hostpool will join.
  [ActiveDirectoryInfoOuPath <String>]: The ou path.
  [AvailabilityZone <Int32[]>]: Value for availability zones to be used by the session host. Should be from [1,2,3].
  [AzureActiveDirectoryInfoMdmProviderGuid <String>]: The mdm guid.
  [AzureAsyncOperation <String>]: 
  [BootDiagnosticInfoEnabled <Boolean?>]: Whether boot diagnostics should be enabled on the Virtual Machine.
  [BootDiagnosticInfoStorageUri <String>]: Uri of the storage account to use for placing the console output and screenshot.   If storageUri is not specified while enabling boot diagnostics, managed storage will be used.
  [CustomConfigurationScriptUrl <String>]: The uri to the storage blob containing the arm template to be run on the virtual machine after provisioning.
  [CustomInfoResourceId <String>]: The resource id of the custom image.
  [DomainCredentialsPasswordKeyVaultSecretUri <String>]: The uri to access the secret that the password is stored in.
  [DomainCredentialsUsernameKeyVaultSecretUri <String>]: The uri to access the secret that the username is stored in.
  [FriendlyName <String>]: Friendly name to describe this version of the SessionHostConfiguration.
  [MarketplaceInfoExactVersion <String>]: The exact version of the image.
  [MarketplaceInfoOffer <String>]: The offer of the image.
  [MarketplaceInfoPublisher <String>]: The publisher of the image.
  [MarketplaceInfoSku <String>]: The sku of the image.
  [NetworkInfoSecurityGroupId <String>]: The resource ID of the security group. Any allowable/open ports should be specified in the NSG.
  [SecurityInfoSecureBootEnabled <Boolean?>]: Whether to use secureBoot on the virtual machine.
  [SecurityInfoType <VirtualMachineSecurityType?>]: The security type used by virtual machine in hostpool session host. Default is Standard.
  [SecurityInfoVTpmEnabled <Boolean?>]: Whether to use vTPM on the virtual machine.
  [VMLocation <String>]: The Location for the session host to be created in. It will default to the location of the hostpool if not provided.
  [VMResourceGroup <String>]: The ResourceGroup for the session hosts to be created in. It will default to the ResourceGroup of the hostpool if not provided.
  [VMTag <ISessionHostConfigurationPropertiesVMTags>]: Hashtable that lists key/value pair tags to apply to the VMs
    [(Any) <String>]: This indicates any property can be added to this object.

VALIDATESESSIONHOSTUPDATEREQUESTBODY <IValidateSessionHostUpdateRequestBody>: Object containing the definition for properties to be used in the sessionHostUpdate validation.
  [ScheduledDateTime <DateTime?>]: The timestamp that the update validation is scheduled for. If none is provided, the update will be executed immediately
  [ScheduledDateTimeZone <String>]: Time zone for sessionHostManagement operations as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0. Must be set if useLocalTime is true.
  [SessionHostConfiguration <ISessionHostConfiguration>]: Object containing the definition for the SessionHostConfiguration to be validated.  If none is provided the update will use the SessionHostConfiguration settings associated with the HostPool.
    DiskInfoType <VirtualMachineDiskType>: The disk type used by virtual machine in hostpool session host.
    DomainInfoJoinType <DomainJoinType>: The type of domain join done by the virtual machine.
    ImageInfoType <Type>: The type of image session hosts use in the hostpool.
    NetworkInfoSubnetId <String>: The resource ID of the subnet.
    VMAdminCredentialsPasswordKeyVaultSecretUri <String>: The uri to access the secret that the password is stored in.
    VMAdminCredentialsUsernameKeyVaultSecretUri <String>: The uri to access the secret that the username is stored in.
    VMNamePrefix <String>: The prefix that should be associated with session host names
    VMSizeId <String>: The id of the size of a virtual machine connected to a hostpool.
    [SystemDataCreatedAt <DateTime?>]: The timestamp of resource creation (UTC).
    [SystemDataCreatedBy <String>]: The identity that created the resource.
    [SystemDataCreatedByType <CreatedByType?>]: The type of identity that created the resource.
    [SystemDataLastModifiedAt <DateTime?>]: The timestamp of resource last modification (UTC)
    [SystemDataLastModifiedBy <String>]: The identity that last modified the resource.
    [SystemDataLastModifiedByType <CreatedByType?>]: The type of identity that last modified the resource.
    [ActiveDirectoryInfoDomainName <String>]: The domain a virtual machine connected to a hostpool will join.
    [ActiveDirectoryInfoOuPath <String>]: The ou path.
    [AvailabilityZone <Int32[]>]: Value for availability zones to be used by the session host. Should be from [1,2,3].
    [AzureActiveDirectoryInfoMdmProviderGuid <String>]: The mdm guid.
    [AzureAsyncOperation <String>]: 
    [BootDiagnosticInfoEnabled <Boolean?>]: Whether boot diagnostics should be enabled on the Virtual Machine.
    [BootDiagnosticInfoStorageUri <String>]: Uri of the storage account to use for placing the console output and screenshot.   If storageUri is not specified while enabling boot diagnostics, managed storage will be used.
    [CustomConfigurationScriptUrl <String>]: The uri to the storage blob containing the arm template to be run on the virtual machine after provisioning.
    [CustomInfoResourceId <String>]: The resource id of the custom image.
    [DomainCredentialsPasswordKeyVaultSecretUri <String>]: The uri to access the secret that the password is stored in.
    [DomainCredentialsUsernameKeyVaultSecretUri <String>]: The uri to access the secret that the username is stored in.
    [FriendlyName <String>]: Friendly name to describe this version of the SessionHostConfiguration.
    [MarketplaceInfoExactVersion <String>]: The exact version of the image.
    [MarketplaceInfoOffer <String>]: The offer of the image.
    [MarketplaceInfoPublisher <String>]: The publisher of the image.
    [MarketplaceInfoSku <String>]: The sku of the image.
    [NetworkInfoSecurityGroupId <String>]: The resource ID of the security group. Any allowable/open ports should be specified in the NSG.
    [SecurityInfoSecureBootEnabled <Boolean?>]: Whether to use secureBoot on the virtual machine.
    [SecurityInfoType <VirtualMachineSecurityType?>]: The security type used by virtual machine in hostpool session host. Default is Standard.
    [SecurityInfoVTpmEnabled <Boolean?>]: Whether to use vTPM on the virtual machine.
    [VMLocation <String>]: The Location for the session host to be created in. It will default to the location of the hostpool if not provided.
    [VMResourceGroup <String>]: The ResourceGroup for the session hosts to be created in. It will default to the ResourceGroup of the hostpool if not provided.
    [VMTag <ISessionHostConfigurationPropertiesVMTags>]: Hashtable that lists key/value pair tags to apply to the VMs
      [(Any) <String>]: This indicates any property can be added to this object.
  [SessionHostManagementSystemDataCreatedAt <DateTime?>]: The timestamp of resource creation (UTC).
  [SessionHostManagementSystemDataCreatedBy <String>]: The identity that created the resource.
  [SessionHostManagementSystemDataCreatedByType <CreatedByType?>]: The type of identity that created the resource.
  [SessionHostManagementSystemDataLastModifiedAt <DateTime?>]: The timestamp of resource last modification (UTC)
  [SessionHostManagementSystemDataLastModifiedBy <String>]: The identity that last modified the resource.
  [SessionHostManagementSystemDataLastModifiedByType <CreatedByType?>]: The type of identity that last modified the resource.
  [UpdateDeleteOriginalVM <Boolean?>]: Whether not to save original disk. False by default.
  [UpdateLogOffDelayMinute <Int32?>]: Grace period before logging off users in minutes.
  [UpdateLogOffMessage <String>]: Log off message sent to user for logoff.
  [UpdateMaxVmsRemoved <Int32?>]: The maximum number of virtual machines to be removed during hostpool update.
.Link
https://learn.microsoft.com/powershell/module/az.desktopvirtualization/invoke-azwvdvalidatesessionhostupdate
#>
function Invoke-AzWvdValidateSessionHostUpdate {
[OutputType([System.Boolean])]
[CmdletBinding(DefaultParameterSetName='PostExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='Post', Mandatory)]
    [Parameter(ParameterSetName='PostExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Path')]
    [System.String]
    # The name of the host pool within the specified resource group
    ${HostPoolName},

    [Parameter(ParameterSetName='Post', Mandatory)]
    [Parameter(ParameterSetName='PostExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Post')]
    [Parameter(ParameterSetName='PostExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='PostViaIdentity', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PostViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IDesktopVirtualizationIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter(ParameterSetName='Post', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='PostViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IValidateSessionHostUpdateRequestBody]
    # Object containing the definition for properties to be used in the sessionHostUpdate validation.
    # To construct, see NOTES section for VALIDATESESSIONHOSTUPDATEREQUESTBODY properties and create a hash table.
    ${ValidateSessionHostUpdateRequestBody},

    [Parameter(ParameterSetName='PostExpanded')]
    [Parameter(ParameterSetName='PostViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.DateTime]
    # The timestamp that the update validation is scheduled for.
    # If none is provided, the update will be executed immediately
    ${ScheduledDateTime},

    [Parameter(ParameterSetName='PostExpanded')]
    [Parameter(ParameterSetName='PostViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # Time zone for sessionHostManagement operations as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyidview=net-5.0.
    # Must be set if useLocalTime is true.
    ${ScheduledDateTimeZone},

    [Parameter(ParameterSetName='PostExpanded')]
    [Parameter(ParameterSetName='PostViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfiguration]
    # Object containing the definition for the SessionHostConfiguration to be validated.
    # If none is provided the update will use the SessionHostConfiguration settings associated with the HostPool.
    # To construct, see NOTES section for SESSIONHOSTCONFIGURATION properties and create a hash table.
    ${SessionHostConfiguration},

    [Parameter(ParameterSetName='PostExpanded')]
    [Parameter(ParameterSetName='PostViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.DateTime]
    # The timestamp of resource creation (UTC).
    ${SessionHostManagementSystemDataCreatedAt},

    [Parameter(ParameterSetName='PostExpanded')]
    [Parameter(ParameterSetName='PostViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # The identity that created the resource.
    ${SessionHostManagementSystemDataCreatedBy},

    [Parameter(ParameterSetName='PostExpanded')]
    [Parameter(ParameterSetName='PostViaIdentityExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType])]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType]
    # The type of identity that created the resource.
    ${SessionHostManagementSystemDataCreatedByType},

    [Parameter(ParameterSetName='PostExpanded')]
    [Parameter(ParameterSetName='PostViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.DateTime]
    # The timestamp of resource last modification (UTC)
    ${SessionHostManagementSystemDataLastModifiedAt},

    [Parameter(ParameterSetName='PostExpanded')]
    [Parameter(ParameterSetName='PostViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # The identity that last modified the resource.
    ${SessionHostManagementSystemDataLastModifiedBy},

    [Parameter(ParameterSetName='PostExpanded')]
    [Parameter(ParameterSetName='PostViaIdentityExpanded')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType])]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType]
    # The type of identity that last modified the resource.
    ${SessionHostManagementSystemDataLastModifiedByType},

    [Parameter(ParameterSetName='PostExpanded')]
    [Parameter(ParameterSetName='PostViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Whether not to save original disk.
    # False by default.
    ${UpdateDeleteOriginalVM},

    [Parameter(ParameterSetName='PostExpanded')]
    [Parameter(ParameterSetName='PostViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.Int32]
    # Grace period before logging off users in minutes.
    ${UpdateLogOffDelayMinute},

    [Parameter(ParameterSetName='PostExpanded')]
    [Parameter(ParameterSetName='PostViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # Log off message sent to user for logoff.
    ${UpdateLogOffMessage},

    [Parameter(ParameterSetName='PostExpanded')]
    [Parameter(ParameterSetName='PostViaIdentityExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.Int32]
    # The maximum number of virtual machines to be removed during hostpool update.
    ${UpdateMaxVmsRemoved},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Returns true when the command succeeds
    ${PassThru},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName
        $mapping = @{
            Post = 'Az.DesktopVirtualization.private\Invoke-AzWvdValidateSessionHostUpdate_Post';
            PostExpanded = 'Az.DesktopVirtualization.private\Invoke-AzWvdValidateSessionHostUpdate_PostExpanded';
            PostViaIdentity = 'Az.DesktopVirtualization.private\Invoke-AzWvdValidateSessionHostUpdate_PostViaIdentity';
            PostViaIdentityExpanded = 'Az.DesktopVirtualization.private\Invoke-AzWvdValidateSessionHostUpdate_PostViaIdentityExpanded';
        }
        if (('Post', 'PostExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
}
