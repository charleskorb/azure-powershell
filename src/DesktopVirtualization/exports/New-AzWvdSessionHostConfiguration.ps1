
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
Create or update a SessionHostConfiguration.
.Description
Create or update a SessionHostConfiguration.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfiguration
.Link
https://learn.microsoft.com/powershell/module/az.desktopvirtualization/new-azwvdsessionhostconfiguration
#>
function New-AzWvdSessionHostConfiguration {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfiguration])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Path')]
    [System.String]
    # The name of the host pool within the specified resource group
    ${HostPoolName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.VirtualMachineDiskType])]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.VirtualMachineDiskType]
    # The disk type used by virtual machine in hostpool session host.
    ${DiskInfoType},

    [Parameter(Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.DomainJoinType])]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.DomainJoinType]
    # The type of domain join done by the virtual machine.
    ${DomainInfoJoinType},

    [Parameter(Mandatory)]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.Type])]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.Type]
    # The type of image session hosts use in the hostpool.
    ${ImageInfoType},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # The resource ID of the subnet.
    ${NetworkInfoSubnetId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # The uri to access the secret that the password is stored in.
    ${VMAdminCredentialsPasswordKeyVaultSecretUri},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # The uri to access the secret that the username is stored in.
    ${VMAdminCredentialsUsernameKeyVaultSecretUri},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # The prefix that should be associated with session host names
    ${VMNamePrefix},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # The id of the size of a virtual machine connected to a hostpool.
    ${VMSizeId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # The domain a virtual machine connected to a hostpool will join.
    ${ActiveDirectoryInfoDomainName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # The ou path.
    ${ActiveDirectoryInfoOuPath},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.Int32[]]
    # Value for availability zones to be used by the session host.
    # Should be from [1,2,3].
    ${AvailabilityZone},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # The mdm guid.
    ${AzureActiveDirectoryInfoMdmProviderGuid},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Whether boot diagnostics should be enabled on the Virtual Machine.
    ${BootDiagnosticInfoEnabled},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # Uri of the storage account to use for placing the console output and screenshot.
    # 
    # 
    # If storageUri is not specified while enabling boot diagnostics, managed storage will be used.
    ${BootDiagnosticInfoStorageUri},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # The uri to the storage blob containing the arm template to be run on the virtual machine after provisioning.
    ${CustomConfigurationScriptUrl},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # The resource id of the custom image.
    ${CustomInfoResourceId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # The uri to access the secret that the password is stored in.
    ${DomainCredentialsPasswordKeyVaultSecretUri},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # The uri to access the secret that the username is stored in.
    ${DomainCredentialsUsernameKeyVaultSecretUri},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # Friendly name to describe this version of the SessionHostConfiguration.
    ${FriendlyName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # The exact version of the image.
    ${MarketplaceInfoExactVersion},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # The offer of the image.
    ${MarketplaceInfoOffer},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # The publisher of the image.
    ${MarketplaceInfoPublisher},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # The sku of the image.
    ${MarketplaceInfoSku},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # The resource ID of the security group.
    # Any allowable/open ports should be specified in the NSG.
    ${NetworkInfoSecurityGroupId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Whether to use secureBoot on the virtual machine.
    ${SecurityInfoSecureBootEnabled},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.VirtualMachineSecurityType])]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.VirtualMachineSecurityType]
    # The security type used by virtual machine in hostpool session host.
    # Default is Standard.
    ${SecurityInfoType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Whether to use vTPM on the virtual machine.
    ${SecurityInfoVTpmEnabled},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.DateTime]
    # The timestamp of resource creation (UTC).
    ${SystemDataCreatedAt},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # The identity that created the resource.
    ${SystemDataCreatedBy},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType])]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType]
    # The type of identity that created the resource.
    ${SystemDataCreatedByType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.DateTime]
    # The timestamp of resource last modification (UTC)
    ${SystemDataLastModifiedAt},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # The identity that last modified the resource.
    ${SystemDataLastModifiedBy},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType])]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType]
    # The type of identity that last modified the resource.
    ${SystemDataLastModifiedByType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # The Location for the session host to be created in.
    # It will default to the location of the hostpool if not provided.
    ${VMLocation},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [System.String]
    # The ResourceGroup for the session hosts to be created in.
    # It will default to the ResourceGroup of the hostpool if not provided.
    ${VMResourceGroup},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.ISessionHostConfigurationPropertiesVMTags]))]
    [System.Collections.Hashtable]
    # Hashtable that lists key/value pair tags to apply to the VMs
    ${VMTag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

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
            CreateExpanded = 'Az.DesktopVirtualization.private\New-AzWvdSessionHostConfiguration_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
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
