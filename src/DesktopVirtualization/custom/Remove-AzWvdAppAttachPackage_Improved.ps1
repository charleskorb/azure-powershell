function Remove-AzWvdAppAttachPackage_Improved {
    [OutputType([System.Boolean])]
    [CmdletBinding(PositionalBinding=$false, ConfirmImpact='Medium')]
    param(
        [Parameter(Mandatory, Position = 0, ValueFromPipeline = $true, HelpMessage = 'App Attach Package to be Removed')]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220901Privatepreview.AppAttachPackage]
        ${PackageToRemove},
    
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

    process {
        $saveAppAttachPackage = $null
        if ($PSBoundParameters.ContainsKey("PackageToRemove")) {
            $saveAppAttachPackage = $PSBoundParameters["PackageToRemove"]
        }
        # clear 
        $null = $PSBoundParameters.Remove("PackageToRemove")

        $finalParameters = @{}
        $idArray = $saveAppAttachPackage.Id.Split("/")
        $finalParameters.Add("SubscriptionId", $idArray[2])
        $finalParameters.Add("ResourceGroupName", $idArray[4])
        $finalParameters.Add("Name", $idArray[8])

        foreach ($key in $PSBoundParameters.Keys) {
            $finalParameters.Add($key, $PSBoundParameters[$key])
        }
        Remove-AzWvdAppAttachPackage @finalParameters

    }
}