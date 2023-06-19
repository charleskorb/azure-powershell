function New-AzWvdAppAttachPackage_ExpandImage {
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220901Privatepreview.IAppAttachPackage])]
    [CmdletBinding(PositionalBinding=$false, ConfirmImpact='Medium')]
    param(
        [Parameter(Mandatory)]
        [Alias('AppAttachPackageName')]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Path')]
        [System.String]
        # The name of the App Attach package arm object
        ${Name},
    
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
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.String]
        # The geo-location where the resource lives
        ${Location},
    
        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.String]
        ${ExpandingHostpoolSubscriptionId},

        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.String]
        ${ExpandingHostpoolResourceGroupName},

        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.String]
        ${ExpandingHostpoolName},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.String]
        # User friendly Name to be displayed in the portal.
        ${DisplayName},

        [Parameter(Mandatory, HelpMessage = 'Image Path to CIM/VHD')]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.String]
        ${ImagePath},

        [Parameter(Mandatory, HelpMessage = 'Package Alias from extract MSIX Image')]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Path')]
        [System.String]
        ${PackageAlias},

        [Parameter(Mandatory)]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.FailHealthCheckOnStagingFailure])]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.FailHealthCheckOnStagingFailure]
        # Parameter indicating how the health check should behave if this package fails staging
        ${FailHealthCheckOnStagingFailure},
    
        [Parameter()]
        [AllowEmptyCollection()]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.String[]]
        # List of Hostpool resource Ids.
        ${HostPoolReference},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.Management.Automation.SwitchParameter]
        # Make this version of the package the active one across the hostpool.
        ${IsActive},
    
        [Parameter()]
        [Alias("IsRegularRegistration")]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.Management.Automation.SwitchParameter]
        # Specifies how to register Package in feed.
        ${IsLogonBlocking},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.String]
        # URL of keyvault location to store certificate
        ${KeyVaultUrl},

        [Parameter()]
        [AllowEmptyCollection()]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.String[]]
        #List of object ids to remove permissions for
        ${PermissionsToRemove},

        [Parameter()]
        [AllowEmptyCollection()]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.String[]]
        #List of object ids to Add permissions for
        ${PermissionsToAdd},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api30.ITrackedResourceTags]))]
        [System.Collections.Hashtable]
        # Resource tags.
        ${Tag},
    
        [Parameter()]
        [Alias('AzureRMContext', 'AzureCredential')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Azure')]
        [System.Management.Automation.PSObject]
        # The DefaultProfile parameter is not functional.
        # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
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

        $createParameters = @{}

        $expandParams = @{}
        #fill out expand
        if($null -ne $ExpandingHostpoolSubscriptionId) {
            $expandSubscription = $ExpandingHostpoolSubscriptionId
            $null = $PSBoundParameters.Remove("ExpandingHostpoolSubscriptionId")
        }
        if($null -ne $ExpandingHostpoolResourceGroupName) {
            $expandResourceGroup = $ExpandingHostpoolResourceGroupName
            $null = $PSBoundParameters.Remove("ExpandingHostpoolResourceGroupName")
        }
        if($null -ne $ExpandingHostpoolName) {
            $expandHostpoolName = $ExpandingHostpoolName
            $null = $PSBoundParameters.Remove("ExpandingHostpoolName")
        }
        if($null -ne $ImagePath) {
            $null = $PSBoundParameters.Remove("ImagePath")
        }
        if ($null -ne $PackageAlias) {
            $null = $PSBoundParameters.Remove("PackageAlias")
        }

        #fill out create params
        if($null -ne $Name) {
            $createParameters.Add("Name", $Name)
            $null = $PSBoundParameters.Remove("Name")
        }        
        if($null -ne $ResourceGroupName) {
            $createParameters.Add("ResourceGroupName", $ResourceGroupName)
            $null = $PSBoundParameters.Remove("ResourceGroupName")
        }        
        if($null -ne $SubscriptionId) {
            $createParameters.Add("SubscriptionId", $SubscriptionId)
            $null = $PSBoundParameters.Remove("SubscriptionId")
        }
        if($null -ne $Location) {
            $createParameters.Add("Location", $Location)
            $null = $PSBoundParameters.Remove("Location")
        }
        if($null -ne $DisplayName) {
            $createParameters.Add("DisplayName", $DisplayName)
            $null = $PSBoundParameters.Remove("DisplayName")
        }
        if($null -ne $FailHealthCheckOnStagingFailure) {
            $createParameters.Add("FailHealthCheckOnStagingFailure", $FailHealthCheckOnStagingFailure)
            $null = $PSBoundParameters.Remove("FailHealthCheckOnStagingFailure")
        }
        if($null -ne $HostPoolReference) {
            $createParameters.Add("HostPoolReference", $HostPoolReference)
            $null = $PSBoundParameters.Remove("HostPoolReference")
        }
        if($null -ne $IsActive) {
            $createParameters.Add("IsActive", $IsActive)
            $null = $PSBoundParameters.Remove("IsActive")
        }
        if($null -ne $IsLogonBlocking) {
            $createParameters.Add("IsLogonBlocking", $IsLogonBlocking)
            $null = $PSBoundParameters.Remove("IsLogonBlocking")
        }
        if($null -ne $KeyVaultUrl) {
            $createParameters.Add("KeyVaultUrl", $KeyVaultUrl)
            $null = $PSBoundParameters.Remove("KeyVaultUrl")
        }        
        if($null -ne $PermissionsToRemove) {
            $createParameters.Add("PermissionsToRemove", $PermissionsToRemove)
            $null = $PSBoundParameters.Remove("PermissionsToRemove")
        }
        if($null -ne $PermissionsToAdd) {
            $createParameters.Add("PermissionsToAdd", $PermissionsToAdd)
            $null = $PSBoundParameters.Remove("PermissionsToAdd")
        }
        
        foreach ($key in $PSBoundParameters.Keys) {
            $expandParams.Add($key, $PSBoundParameters[$key])
        }

        foreach ($key in $PSBoundParameters.Keys) {
            $createParameters.Add($key, $PSBoundParameters[$key])
        }

        $ImageObject = Expand-AzWvdMsixImage @expandParams -SubscriptionId $expandSubscription `
            -ResourceGroupName $expandResourceGroup -HostPoolName $expandHostpoolName `
            -Uri $ImagePath
        | Where-Object { $_.PackageAlias -eq $PackageAlias }

        $createParameters.Add("ImageObject", $ImageObject)

        $appAttachPackage = New-AzWvdAppAttachPackage_ImageObject @createParameters

    }
}