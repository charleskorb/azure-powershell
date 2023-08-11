function Expand-AzWvdMsixImage_Improved {
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220901Privatepreview.IExpandMsixImage])]
    [CmdletBinding(PositionalBinding=$false, ConfirmImpact='Medium')]
    param(
        [Parameter(Mandatory, HelpMessage = 'HostPool Name')]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Path')]
        [System.String]
        ${HostPoolName},
    
        [Parameter(Mandatory, HelpMessage = 'Resource Group Name')]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Path')]
        [System.String]
        ${ResourceGroupName},
    
        [Parameter(Mandatory, HelpMessage = 'Subscription Id')]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.DefaultInfo(Script = '(Get-AzContext).Subscription.Id')]
        [System.String]
        ${SubscriptionId},

        [Alias("Path")]
        [Parameter(Position = 0, Mandatory, HelpMessage = 'Path to image')]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.String]
        ${Uri},

        # Validate set taken from options enumerated at https://learn.microsoft.com/en-us/windows/msix/package/device-architecture
        [Parameter(HelpMessage = 'Version of image to return')]
        [ValidateSet("x86", "x64", "ARM", "ARM64", "ALL")]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.String]
        ${PackageArchitecture},

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
        $saveHostPoolName = $null
        if ($PSBoundParameters.ContainsKey("HostPoolName")) {
            $saveHostPoolName = $PSBoundParameters["HostPoolName"]
        }
        $saveResourceGroupName = $null
        if ($PSBoundParameters.ContainsKey("ResourceGroupName")) {
            $saveResourceGroupName = $PSBoundParameters["ResourceGroupName"]
        }
        $saveSubscriptionId = $null
        if ($PSBoundParameters.ContainsKey("SubscriptionId")) {
            $saveSubscriptionId = $PSBoundParameters["SubscriptionId"]
        }
        $saveImagePath = $null
        if ($PSBoundParameters.ContainsKey("Uri")) {
            $saveImagePath = $PSBoundParameters["Uri"]
        }
        $saveArchitecture = "x64"
        $saveArchitectureSpecified = $false
        if ($PSBoundParameters.ContainsKey("PackageArchitecture")) {
            $saveArchitecture = $PSBoundParameters["PackageArchitecture"]
            $saveArchitectureSpecified = $true
        }

        # clear 
        $null = $PSBoundParameters.Remove("HostPoolName")
        $null = $PSBoundParameters.Remove("ResourceGroupName")
        $null = $PSBoundParameters.Remove("SubscriptionId")
        $null = $PSBoundParameters.Remove("Uri")
        $null = $PSBoundParameters.Remove("PackageArchitecture")
       
        $ImageList = Expand-AzWvdMsixImage @PSBoundParameters -HostPoolName $saveHostPoolName `
            -ResourceGroupName  $saveResourceGroupName `
            -SubscriptionId  $saveSubscriptionId `
            -Uri $saveImagePath 
<#
            What I did here was

            1) if architecture not specified and there is only one image, return that image whatever it is
            2) if architecture is specified and there is only one image but it is not of the specified architecture throw an exception
            3) if architecture is specified and there is more than one image but none of them are of the specified architecture throw an exception
            4) if architecture is specified and there is more than one image of that architecture, return all of them
            5) if architecture is not specified and there is more than one image, return x64 image
            6) if architecture is not specified and there is more than one x64 image, return all of them
            7) if architecture is not specified and there is more than one image and none of them are x64, return all of them 
            8) if architecture is specified as "ALL", return all images
#>   
        if ($ImageList.Count -eq 1 -and !$saveArchitectureSpecified) {
            return $ImageList[0]    
        }
        elseif ($saveArchitecture.Equals("ALL")) {
            return $ImageList
        }
        else {
            $archCount = 0
            $OutputList = @()
            foreach($Image in $ImageList) {
                if ($Image.PackageFullName.Contains("_" + $saveArchitecture + "_")) {
                    $archCount++
                    $OutputList += $Image
                }
            }
            if ($archCount -eq 0 -and $saveArchitectureSpecified) {
                Write-Error "No " + $saveArchitecture + " images found in virtual disk"
            } elseif ($archCount -eq 0 -and !$saveArchitectureSpecified) {
                return $ImageList
            }
            return $OutputList
        }
    }
}