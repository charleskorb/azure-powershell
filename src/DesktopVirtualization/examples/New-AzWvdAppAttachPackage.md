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

This command creates or updates an Azure Virtual Desktop App attach package in a resource group, adding permissions to it from the object ids specified

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

This command creates or updates an Azure Virtual Desktop App Attach Package in a resource group using the output of the Expand-AzWvdMsixImage command, adding permissions to it from the object ids specified


### Example 4: Create an Azure Virtual Desktop app attach package by an image which is expanded as part of the creation process. Requires the package alias to indicate which package in the image you want to expand. If it is not provided, if there is only one package in the image it will add that, if there are more than one it will add the x64 one, and if there is more than one x64 package it will throw an exception
```powershell
New-AzWvdAppAttachPackage -Name PackageArmObjectName `
                         -ResourceGroupName ResourceGroupName `
                         -SubscriptionId SubscriptionId `
                         -ExpandingHostpoolSubscriptionId hpsubscriptionid `
                         -ExpandingHostpoolResourceGroupName hpresourcegroupname `
                         -ExpandingHostpoolName hostpoolname `
                         -PackageAlias alias `
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

This command expands the image of an Azure Virtual Desktop App Attach Package and then creates that object in a resource group, adding permissions to it from the object ids specified 

### Example 5: Create an Azure Virtual Desktop app attach package from the output of expand api 
```powershell
$image = Expand-AzWvdMsixImage -HostPoolName HostpoolName`
                        -ResourceGroupName ResourceGroupName `
                        -SubscriptionId SubscriptionId `
                        -Uri ImagePath

$image | New-AzWvdAppAttachPackage -Name PackageArmObjectName `
                         -ResourceGroupName ResourceGroupName `
                         -SubscriptionId SubscriptionId `
                         -Location location `
                         -DisplayName displayname `
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

This command creates or updates an Azure Virtual Desktop App Attach Package in a resource group using the output of the Expand-AzWvdMsixImage command, adding permissions to it from the object ids specified