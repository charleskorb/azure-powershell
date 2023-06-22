### Example 1: Update an Azure Virtual Desktop app attach package by name
```powershell
    $apps = "<PackagedApplication>"
    $deps = "<PackageDependencies>"
    Update-AzWvdAppAttachPackage -Name PackageArmObjectName `
                         -ResourceGroupName ResourceGroupName `
                         -SubscriptionId SubscriptionId `
                         -Location location
                         -ImageDisplayName displayname `
                         -ImagePath imageURI `
                         -ImageIsActive:$false `
                         -ImageIsRegularRegistration:$false `
                         -ImageLastUpdated datelastupdated `
                         -ImagePackageApplication $apps `
                         -ImagePackageDependency $deps `
                         -ImagePackageFamilyName packagefamilyname `
                         -ImagePackageName packagename `
                         -ImagePackageFullName packagefullname `
                         -ImagePackageRelativePath packagerelativepath `
                         -ImageVersion packageversion `
                         -ImageCertificateExpiry certificateExpiry `
                         -ImageCertificateName certificateName `
                         -KeyVaultUrl keyvaultUrl `
                         -FailHealthCheckOnStagingFailure 'Unhealthy'

Location   Name                 Type
--------   ----                 ----
eastus     PackageArmObjectName Microsoft.DesktopVirtualization/appattachpackages
```

This command updates an Azure Virtual Desktop App attach package in a resource group

### Example 2: Update an Azure Virtual Desktop app attach package by name
```powershell
    $apps = "<PackagedApplication>"
    $deps = "<PackageDependencies>"
    Update-AzWvdAppAttachPackage -Name PackageArmObjectName `
                         -ResourceGroupName ResourceGroupName `
                         -SubscriptionId SubscriptionId `
                         -Location location `
                         -DisplayName displayname `
                         -ImagePath imageURI `
                         -IsActive:$false `
                         -IsLogonBlocking:$false `
                         -LastUpdated datelastupdated `
                         -PackageApplication $apps `
                         -PackageDependency $deps `
                         -PackageFamilyName packagefamilyname `
                         -PackageName packagename `
                         -PackageFullName packagefullname
                         -PackageRelativePath packagerelativepath `
                         -Version packageversion `
                         -CertificateExpiry certificateExpiry `
                         -CertificateName certificateName `
                         -KeyVaultUrl keyvaultUrl `
                         -FailHealthCheckOnStagingFailure 'Unhealthy' `
                         -HostpoolReference hostpoolReference `
                         -PermissionsToAdd permissionsToAdd
                         -PermissionsToRemove permissionsToRemove

Location   Name                 Type
--------   ----                 ----
eastus     PackageArmObjectName Microsoft.DesktopVirtualization/appattachpackages
```

This command updates an Azure Virtual Desktop App attach package in a resource group, adding permissions to it from the object ids specifed

### Example 3: Update an Azure Virtual Desktop app attach package by image object
```powershell
Update-AzWvdAppAttachPackage -Name PackageArmObjectName `
                         -ResourceGroupName ResourceGroupName `
                         -SubscriptionId SubscriptionId `
                         -Location location `
                         -DisplayName displayname `
                         -ImageObject imageObject `
                         -IsActive:$false `
                         -IsLogonBlocking:$false `
                         -KeyVaultUrl keyvaultUrl `
                         -FailHealthCheckOnStagingFailure 'Unhealthy' `
                         -HostpoolReference hostpoolReference `
                         -PermissionsToAdd permissionsToAdd
                         -PermissionsToRemove permissionsToRemove

Location   Name                 Type
--------   ----                 ----
eastus     PackageArmObjectName Microsoft.DesktopVirtualization/appattachpackages
```

This command updates an Azure Virtual Desktop App Attach Package in a resource group using the output of the Expand-AzWvdMsixImage command, adding permissions to it from the object ids specifed


### Example 3: Update only the permissions of an Azure Virtual Desktop app attach package
```powershell
Update-AzWvdAppAttachPackage -Name PackageArmObjectName `
                         -ResourceGroupName ResourceGroupName `
                         -SubscriptionId SubscriptionId `
                         -Location location `
                         -PermissionsToAdd permissionsToAdd
                         -PermissionsToRemove permissionsToRemove

Location   Name                 Type
--------   ----                 ----
eastus     PackageArmObjectName Microsoft.DesktopVirtualization/appattachpackages
```

This command updates the permissions to an Azure Virtual Desktop App Attach Package in a resource group; adding the permissions in the permissionsToAdd list and removing the ones in the permissions to remove list

