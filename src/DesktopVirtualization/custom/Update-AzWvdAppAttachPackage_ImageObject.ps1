function Update-AzWvdAppAttachPackage_ImageObject {
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
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.String]
        # User friendly Name to be displayed in the portal.
        ${DisplayName},

        [Parameter(Mandatory, Position = 0, ValueFromPipeline)]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220901Privatepreview.ExpandMsixImage[]]
        ${ImageObjects},

        [Parameter()]
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
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.String[]]
        #List of object ids to remove permissions for
        ${PermissionsToRemove},

        [Parameter()]
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
        
        $finalParameters = @{}

        if ($null -eq $ImageObjects -or $ImageObjects.Count -eq 0) {
            throw "No Image objects provided to create package object"
        }
        elseif ($ImageObjects.Count -eq 1) {
            $ImageObject = $ImageObjects[0]    
        }
        else {
            $x64Count = 0
            foreach($Image in $ImageObjects) {
                if ($Image.PackageFullName.Contains("_x64_")) {
                    $x64Count++
                    $ImageObject = $Image
                }
            }
            if ($x64Count -gt 1) {
                throw "More than one x64 image in provided list, please provide a specific image to create a package object"
            }
            if ($x64Count -lt 1) {
                throw "No x64 images found in provided list, please provide a specific image to create a package object"
            }
        }
        if($null -ne $ImageObject.PackageApplication) {
            $finalParameters.Add("PackageApplication", $ImageObject.PackageApplication)
        }
        if($null -ne $ImageObject.CertificateName) {
            $finalParameters.Add("CertificateName", $ImageObject.CertificateName)
        }
        if($null -ne $ImageObject.ImagePath) {
            $finalParameters.Add("ImagePath", $ImageObject.ImagePath)
        }
        if($null -ne $ImageObject.CertificateExpiry) {
            $finalParameters.Add("CertificateExpiry", $ImageObject.CertificateExpiry)
        }
        if($null -ne $ImageObject.PackageDependency) {
            $finalParameters.Add("PackageDependency", $ImageObject.PackageDependency)
        }
        if($null -ne $ImageObject.PackageFamilyName) {
            $finalParameters.Add("PackageFamilyName", $ImageObject.PackageFamilyName)
        }
        if($null -ne $ImageObject.PackageFullName) {
            $finalParameters.Add("PackageFullName", $ImageObject.PackageFullName)
        }
        if($null -ne $ImageObject.PackageName) {
            $finalParameters.Add("PackageName", $ImageObject.PackageName)
        }        
        if($null -ne $ImageObject.PackageRelativePath) {
            $finalParameters.Add("PackageRelativePath", $ImageObject.PackageRelativePath)
        }
        if($null -ne $ImageObject.Version) {
            $finalParameters.Add("Version", $ImageObject.Version)
        }
        if($null -ne $ImageObject.LastUpdated) {
            $finalParameters.Add("LastUpdated", $ImageObject.LastUpdated)
        }        
        if($null -ne $ImageObject.PackageAlias) {
            $finalParameters.Add("PackageAlias", $ImageObject.PackageAlias)
        }
        $null = $PSBoundParameters.Remove("ImageObjects")
        foreach ($key in $PSBoundParameters.Keys) {
            $finalParameters.Add($key, $PSBoundParameters[$key])
        }

        $appAttachPackage = Update-AzWvdAppAttachPackage_Improved @finalParameters
    }
}