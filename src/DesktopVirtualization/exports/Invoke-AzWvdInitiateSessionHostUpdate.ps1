
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
Initiates a hostpool update or schedule an update for the future.
.Description
Initiates a hostpool update or schedule an update for the future.
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}
.Example
PS C:\> {{ Add code here }}

{{ Add output here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IUpdateSessionHostsRequestBody
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

UPDATESESSIONHOSTSREQUESTBODY <IUpdateSessionHostsRequestBody>: Object containing the definition for properties to be used for a sessionHostUpdate operation.
  [ScheduledDateTime <DateTime?>]: The timestamp that the update validation is scheduled for. If none is provided, the update will be executed immediately
  [ScheduledDateTimeZone <String>]: The timeZone as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyid?view=net-5.0.
  [UpdateDeleteOriginalVM <Boolean?>]: Whether not to save original disk. False by default.
  [UpdateLogOffDelayMinute <Int32?>]: Grace period before logging off users in minutes.
  [UpdateLogOffMessage <String>]: Log off message sent to user for logoff.
  [UpdateMaxVmsRemoved <Int32?>]: The maximum number of virtual machines to be removed during hostpool update.
.Link
https://learn.microsoft.com/powershell/module/az.desktopvirtualization/invoke-azwvdinitiatesessionhostupdate
#>
function Invoke-AzWvdInitiateSessionHostUpdate {
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
    [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220809Privatepreview.IUpdateSessionHostsRequestBody]
    # Object containing the definition for properties to be used for a sessionHostUpdate operation.
    # To construct, see NOTES section for UPDATESESSIONHOSTSREQUESTBODY properties and create a hash table.
    ${UpdateSessionHostsRequestBody},

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
    # The timeZone as defined in https://docs.microsoft.com/en-us/dotnet/api/system.timezoneinfo.findsystemtimezonebyidview=net-5.0.
    ${ScheduledDateTimeZone},

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
            Post = 'Az.DesktopVirtualization.private\Invoke-AzWvdInitiateSessionHostUpdate_Post';
            PostExpanded = 'Az.DesktopVirtualization.private\Invoke-AzWvdInitiateSessionHostUpdate_PostExpanded';
            PostViaIdentity = 'Az.DesktopVirtualization.private\Invoke-AzWvdInitiateSessionHostUpdate_PostViaIdentity';
            PostViaIdentityExpanded = 'Az.DesktopVirtualization.private\Invoke-AzWvdInitiateSessionHostUpdate_PostViaIdentityExpanded';
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
