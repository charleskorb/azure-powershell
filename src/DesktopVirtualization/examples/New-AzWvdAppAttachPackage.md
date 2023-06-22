### Example 1: Create an Azure Virtual Desktop app attach package by name
```powershell
    $apps = "<PackagedApplication>"
    $deps = "<PackageDependencies>"
    New-AzWvdAppAttachPackage -Name PackageArmObjectName `
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

This command creates or updates an Azure Virtual Desktop App attach package in a resource group

### Example 2: Create an Azure Virtual Desktop app attach package by name
```powershell
    $apps = "<PackagedApplication>"
    $deps = "<PackageDependencies>"
    New-AzWvdAppAttachPackage -Name PackageArmObjectName `
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

Location   Name                 Type
--------   ----                 ----
eastus     PackageArmObjectName Microsoft.DesktopVirtualization/appattachpackages
```

This command creates or updates an Azure Virtual Desktop App attach package in a resource group, adding permissions to it from the object ids specifed

### Example 3: Create an Azure Virtual Desktop app attach package by image object
```powershell
New-AzWvdAppAttachPackage -Name PackageArmObjectName `
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

Location   Name                 Type
--------   ----                 ----
eastus     PackageArmObjectName Microsoft.DesktopVirtualization/appattachpackages
```

This command creates or updates an Azure Virtual Desktop App Attach Package in a resource group using the output of the Expand-AzWvdMsixImage command, adding permissions to it from the object ids specifed


### Example 4: Create an Azure Virtual Desktop app attach package by an image which is expanded as part of the creation process
```powershell
New-AzWvdAppAttachPackage -Name PackageArmObjectName `
                         -ResourceGroupName ResourceGroupName `
                         -SubscriptionId SubscriptionId `
                         -ExpandingHostpoolSubscriptionId hpsubscriptionid `
                         -ExpandingHostpoolResourceGroupName hpresourcegroupname `
                         -ExpandingHostpoolName hostpoolname `
                         -Location location `
                         -DisplayName displayname `
                         -ImagePath imageURI `
                         -IsActive:$false `
                         -IsLogonBlocking:$false `
                         -KeyVaultUrl keyvaultUrl `
                         -FailHealthCheckOnStagingFailure 'Unhealthy' `
                         -HostpoolReference hostpoolReference `
                         -PermissionsToAdd permissionsToAdd

Location   Name                 Type
--------   ----                 ----
eastus     PackageArmObjectName Microsoft.DesktopVirtualization/appattachpackages
```

This command expands the image of an Azure Virtual Desktop App Attach Package and then creates that object in a resource group, adding permissions to it from the object ids specifed 