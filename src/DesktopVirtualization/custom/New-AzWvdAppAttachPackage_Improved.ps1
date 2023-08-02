function New-AzWvdAppAttachPackage_Improved {
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
    
        [Parameter(HelpMessage = 'Date certificate expires, extracted from p7x file in package.')]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.DateTime]
        # Date certificate expires, found in the appxmanifest.xml.
        ${CertificateExpiry},
    
        [Parameter(HelpMessage = 'Name of certificate, extracted from p7x file in package.')]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.String]
        # Certificate name found in the appxmanifest.xml.
        ${CertificateName},
    
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.String]
        # User friendly Name to be displayed in the portal.
        ${DisplayName},
    
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
    
        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.String]
        # VHD/CIM image path on Network Share.
        ${ImagePath},
    
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
    
        [Parameter(Mandatory, HelpMessage = 'Date Package was last updated, found in the appxmanifest.xml.')]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.DateTime]
        # Date Package was last updated, found in the appxmanifest.xml.
        ${LastUpdated},
    
        [Parameter(HelpMessage = 'Alias of MSIX Package.')]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.String]
        # Alias of MSIX Package.
        ${PackageAlias},
    
        [Parameter(HelpMessage = 'List of package applications.')]
        [AllowEmptyCollection()]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220901Privatepreview.IMsixPackageApplications[]]
        # List of package applications.
        # 
        # To construct, see NOTES section for PACKAGEAPPLICATION properties and create a hash table.
        ${PackageApplication},
    
        [Parameter(HelpMessage = 'List of package dependencies.')]
        [AllowEmptyCollection()]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220901Privatepreview.IMsixPackageDependencies[]]
        # List of package dependencies.
        # 
        # To construct, see NOTES section for PACKAGEDEPENDENCY properties and create a hash table.
        ${PackageDependency},
    
        [Parameter(Mandatory, HelpMessage = 'Package Family Name from appxmanifest.xml; contains package name and publisher name')]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.String]
        # Package Family Name from appxmanifest.xml.
        # Contains Package Name and Publisher name.
        ${PackageFamilyName},
    
        [Parameter(Mandatory, HelpMessage = 'Package Full Name from appxmanifest.xml.')]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.String]
        # Package Full Name from appxmanifest.xml.
        ${PackageFullName},
    
        [Parameter(Mandatory, HelpMessage = 'Package Name from appxmanifest.xml.')]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.String]
        # Package Name from appxmanifest.xml.
        ${PackageName},
    
        [Parameter(Mandatory, HelpMessage = 'Relative Path to the package inside the image.')]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.String]
        # Relative Path to the package inside the image.
        ${PackageRelativePath},

        [Parameter(HelpMessage = 'List of object ids to remove permissions from the package')]
        [AllowEmptyCollection()]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.String[]]
        #List of object ids to remove permissions for
        ${PermissionsToRemove},

        [Parameter(HelpMessage = 'List of object ids to add permissions to the package')]
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
    
        [Parameter(Mandatory, HelpMessage = 'Package Version found in the appxmanifest.xml.')]
        [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Category('Body')]
        [System.String]
        # Package Version found in the appxmanifest.xml.
        ${Version},
    
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

        $savePermissionsToRemove = $null
        if($PSBoundParameters.ContainsKey("PermissionsToRemove")) {
            $savePermissionsToRemove = $PSBoundParameters["PermissionsToRemove"]
        }
        $savePermissionsToAdd = $null
        if($PSBoundParameters.ContainsKey("PermissionsToAdd")) {
            $savePermissionsToAdd = $PSBoundParameters["PermissionsToAdd"]
        }

        $finalParameters = @{}
        
        if($PSBoundParameters.ContainsKey("CertificateExpiry")) {
            $finalParameters.Add("ImageCertificateExpiry", $PSBoundParameters["CertificateExpiry"])
        }
        if($PSBoundParameters.ContainsKey("CertificateName")) {
            $finalParameters.Add("ImageCertificateName", $PSBoundParameters["CertificateName"])
        }
        if($PSBoundParameters.ContainsKey("DisplayName")) {
            $finalParameters.Add("ImageDisplayName", $PSBoundParameters["DisplayName"])
        }
        if($PSBoundParameters.ContainsKey("IsActive")) {
            $finalParameters.Add("ImageIsActive", $PSBoundParameters["IsActive"])
        }
        if($PSBoundParameters.ContainsKey("LastUpdated")) {
            $finalParameters.Add("ImageLastUpdated", $PSBoundParameters["LastUpdated"])
        }
        if($PSBoundParameters.ContainsKey("PackageAlias")) {
            $finalParameters.Add("ImagePackageAlias", $PSBoundParameters["PackageAlias"])
        }
        if($PSBoundParameters.ContainsKey("PackageApplication")) {
            $finalParameters.Add("ImagePackageApplication", $PSBoundParameters["PackageApplication"])
        }
        if($PSBoundParameters.ContainsKey("PackageDependency")) {
            $finalParameters.Add("ImagePackageDependency", $PSBoundParameters["PackageDependency"])
        }
        if($PSBoundParameters.ContainsKey("PackageFamilyName")) {
            $finalParameters.Add("ImagePackageFamilyName", $PSBoundParameters["PackageFamilyName"])
        }
        if($PSBoundParameters.ContainsKey("PackageFullName")) {
            $finalParameters.Add("ImagePackageFullName", $PSBoundParameters["PackageFullName"])
        }
        if($PSBoundParameters.ContainsKey("PackageName")) {
            $finalParameters.Add("ImagePackageName", $PSBoundParameters["PackageName"])
        }
        if($PSBoundParameters.ContainsKey("PackageRelativePath")) {
            $finalParameters.Add("ImagePackageRelativePath" , $PSBoundParameters["PackageRelativePath"])
        }
        if($PSBoundParameters.ContainsKey("Version")) {
            $finalParameters.Add("ImageVersion", $PSBoundParameters["Version"])
        }
        if($PSBoundParameters.ContainsKey("IsLogonBlocking")) {
            $finalParameters.Add("ImageIsRegularRegistration", $PSBoundParameters["IsLogonBlocking"])
        }
        
        # Default health check failure action to Needs assistance
        if (!($PSBoundParameters.ContainsKey("FailHealthCheckOnStagingFailure"))) {
            $finalParameters.Add("FailHealthCheckOnStagingFailure", "NeedsAssistance")
        }

        $null = $PSBoundParameters.Remove("PermissionsToRemove")
        $null = $PSBoundParameters.Remove("PermissionsToAdd")
        $null = $PSBoundParameters.Remove("CertificateExpiry")
        $null = $PSBoundParameters.Remove("CertificateName")
        $null = $PSBoundParameters.Remove("DisplayName")
        $null = $PSBoundParameters.Remove("IsActive")
        $null = $PSBoundParameters.Remove("LastUpdated")
        $null = $PSBoundParameters.Remove("PackageAlias")
        $null = $PSBoundParameters.Remove("PackageApplication")
        $null = $PSBoundParameters.Remove("PackageDependency")
        $null = $PSBoundParameters.Remove("PackageFamilyName")
        $null = $PSBoundParameters.Remove("PackageFullName")
        $null = $PSBoundParameters.Remove("PackageName")
        $null = $PSBoundParameters.Remove("PackageRelativePath")
        $null = $PSBoundParameters.Remove("Version")
        $null = $PSBoundParameters.Remove("IsLogonBlocking")

        foreach ($key in $PSBoundParameters.Keys) {
            $finalParameters.Add($key, $PSBoundParameters[$key])
        }
        $appAttachPackage = New-AzWvdAppAttachPackage @finalParameters

        try {
            [regex]$guidRegex = '(?im)^[{(]?[0-9A-F]{8}[-]?(?:[0-9A-F]{4}[-]?){3}[0-9A-F]{12}[)}]?$'
            [regex]$emailRegex = '^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$'
            if($null -ne $savePermissionsToRemove) {
                foreach ($item in $savePermissionsToRemove) {
                    if ($item -match $guidRegex) {
                        Remove-AzRoleAssignment -ObjectId $item -RoleDefinitionName "Desktop Virtualization User" -Scope $appAttachPackage.Id
                    } 
                    elseif ($item -match $emailRegex) {
                        Remove-AzRoleAssignment -SignInName $item -RoleDefinitionName "Desktop Virtualization User" -Scope $appAttachPackage.Id
                    }
                    # if not email or guid, assume group
                    else {
                        $group = Get-MgGroup -Filter "DisplayName eq '$item'"
                        Remove-AzRoleAssignment -ObjectId $group.Id -RoleDefinitionName "Desktop Virtualization User" -Scope $appAttachPackage.Id
                    }
                }
            }
            if($null -ne $savePermissionsToAdd) {
                foreach ($item in $savePermissionsToAdd) {
                    if ($item -match $guidRegex) {
                        New-AzRoleAssignment -ObjectId $item -RoleDefinitionName "Desktop Virtualization User" -Scope $appAttachPackage.Id
                    } 
                    elseif ($item -match $emailRegex) {
                        New-AzRoleAssignment -SignInName $item -RoleDefinitionName "Desktop Virtualization User" -Scope $appAttachPackage.Id
                    }
                    # if not email or guid, assume group
                    else {
                        $group = Get-MgGroup -Filter "DisplayName eq '$item'"
                        New-AzRoleAssignment -ObjectId $group.Id -RoleDefinitionName "Desktop Virtualization User" -Scope $appAttachPackage.Id
                    }                
                }
            }
        }
        catch {
            Write-Host "An exception occured adjusting permissions, please manually check permissions: " + $_
        }
        $appAttachPackage
    }
}