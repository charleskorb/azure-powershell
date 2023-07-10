---
external help file:
Module Name: Az.DesktopVirtualization
online version: https://learn.microsoft.com/powershell/module/az.desktopvirtualization/new-azwvdappattachpackage
schema: 2.0.0
---

# New-AzWvdAppAttachPackage

## SYNOPSIS
Create or update an App Attach package.

## SYNTAX

### CreateExpanded (Default)
```
New-AzWvdAppAttachPackage -Name <String> -ResourceGroupName <String> -Location <String>
 [-SubscriptionId <String>] [-FailHealthCheckOnStagingFailure <FailHealthCheckOnStagingFailure>]
 [-HostPoolReference <String[]>] [-ImageCertificateExpiry <DateTime>] [-ImageCertificateName <String>]
 [-ImageDisplayName <String>] [-ImageIsActive] [-ImageIsRegularRegistration] [-ImageLastUpdated <DateTime>]
 [-ImagePackageAlias <String>] [-ImagePackageApplication <IMsixPackageApplications[]>]
 [-ImagePackageDependency <IMsixPackageDependencies[]>] [-ImagePackageFamilyName <String>]
 [-ImagePackageFullName <String>] [-ImagePackageName <String>] [-ImagePackageRelativePath <String>]
 [-ImagePath <String>] [-ImageVersion <String>] [-KeyVaultUrl <String>] [-SystemDataCreatedAt <DateTime>]
 [-SystemDataCreatedBy <String>] [-SystemDataCreatedByType <CreatedByType>]
 [-SystemDataLastModifiedAt <DateTime>] [-SystemDataLastModifiedBy <String>]
 [-SystemDataLastModifiedByType <CreatedByType>] [-Tag <Hashtable>] [-DefaultProfile <PSObject>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### ExpandImage
```
New-AzWvdAppAttachPackage -Name <String> -ResourceGroupName <String> -ExpandingHostpoolName <String>
 -ExpandingHostpoolResourceGroupName <String> -ExpandingHostpoolSubscriptionId <String>
 -FailHealthCheckOnStagingFailure <FailHealthCheckOnStagingFailure> -ImagePath <String> -Location <String>
 [-SubscriptionId <String>] [-DisplayName <String>] [-HostPoolReference <String[]>] [-IsActive]
 [-IsLogonBlocking] [-KeyVaultUrl <String>] [-PackageAlias <String>] [-PermissionsToAdd <String[]>]
 [-PermissionsToRemove <String[]>] [-Tag <Hashtable>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### ImageObject
```
New-AzWvdAppAttachPackage [-ImageObjects] <ExpandMsixImage[]> -Name <String> -ResourceGroupName <String>
 -Location <String> [-SubscriptionId <String>] [-DisplayName <String>]
 [-FailHealthCheckOnStagingFailure <FailHealthCheckOnStagingFailure>] [-HostPoolReference <String[]>]
 [-IsActive] [-IsLogonBlocking] [-KeyVaultUrl <String>] [-PermissionsToAdd <String[]>]
 [-PermissionsToRemove <String[]>] [-Tag <Hashtable>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Improved
```
New-AzWvdAppAttachPackage -Name <String> -ResourceGroupName <String> -ImagePath <String>
 -LastUpdated <DateTime> -Location <String> -PackageFamilyName <String> -PackageFullName <String>
 -PackageName <String> -PackageRelativePath <String> -Version <String> [-SubscriptionId <String>]
 [-CertificateExpiry <DateTime>] [-CertificateName <String>] [-DisplayName <String>]
 [-FailHealthCheckOnStagingFailure <FailHealthCheckOnStagingFailure>] [-HostPoolReference <String[]>]
 [-IsActive] [-IsLogonBlocking] [-KeyVaultUrl <String>] [-PackageAlias <String>]
 [-PackageApplication <IMsixPackageApplications[]>] [-PackageDependency <IMsixPackageDependencies[]>]
 [-PermissionsToAdd <String[]>] [-PermissionsToRemove <String[]>] [-Tag <Hashtable>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION
Create or update an App Attach package.

## EXAMPLES

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

This command expands the image of an Azure Virtual Desktop App Attach Package and then creates that object in a resource group, adding permissions to it from the object ids specifed

## PARAMETERS

### -CertificateExpiry
Date certificate expires, extracted from p7x file in package.

```yaml
Type: System.DateTime
Parameter Sets: Improved
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CertificateName
Name of certificate, extracted from p7x file in package.

```yaml
Type: System.String
Parameter Sets: Improved
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
User friendly Name to be displayed in the portal

```yaml
Type: System.String
Parameter Sets: ExpandImage, ImageObject, Improved
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpandingHostpoolName
Name of hostpool doing the package expansion

```yaml
Type: System.String
Parameter Sets: ExpandImage
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpandingHostpoolResourceGroupName
Resource Group name for hostpool doing the package expansion

```yaml
Type: System.String
Parameter Sets: ExpandImage
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpandingHostpoolSubscriptionId
Subscription id for hostpool doing the package expansion

```yaml
Type: System.String
Parameter Sets: ExpandImage
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FailHealthCheckOnStagingFailure
Parameter indicating how the health check should behave if this package fails staging

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.FailHealthCheckOnStagingFailure
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HostPoolReference
List of Hostpool resource Ids.

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImageCertificateExpiry
Date certificate expires, found in the appxmanifest.xml.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImageCertificateName
Certificate name found in the appxmanifest.xml.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImageDisplayName
User friendly Name to be displayed in the portal.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImageIsActive
Make this version of the package the active one across the hostpool.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImageIsRegularRegistration
Specifies how to register Package in feed.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImageLastUpdated
Date Package was last updated, found in the appxmanifest.xml.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImageObjects
To construct, see NOTES section for IMAGEOBJECTS properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220901Privatepreview.ExpandMsixImage[]
Parameter Sets: ImageObject
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ImagePackageAlias
Alias of MSIX Package.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImagePackageApplication
List of package applications.

To construct, see NOTES section for IMAGEPACKAGEAPPLICATION properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220901Privatepreview.IMsixPackageApplications[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImagePackageDependency
List of package dependencies.

To construct, see NOTES section for IMAGEPACKAGEDEPENDENCY properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220901Privatepreview.IMsixPackageDependencies[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImagePackageFamilyName
Package Family Name from appxmanifest.xml.
Contains Package Name and Publisher name.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImagePackageFullName
Package Full Name from appxmanifest.xml.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImagePackageName
Package Name from appxmanifest.xml.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImagePackageRelativePath
Relative Path to the package inside the image.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImagePath
VHD/CIM image path on Network Share.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, ExpandImage, Improved
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImageVersion
Package Version found in the appxmanifest.xml.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsActive
Make this version of the package the active one across the hostpools it is associated with.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ExpandImage, ImageObject, Improved
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsLogonBlocking
Specifies if the package should be registered during logon or on click

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ExpandImage, ImageObject, Improved
Aliases: IsRegularRegistration

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -KeyVaultUrl
URL of keyvault location to store certificate

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastUpdated
Date Package was last updated, found in the appxmanifest.xml.

```yaml
Type: System.DateTime
Parameter Sets: Improved
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Location
The geo-location where the resource lives

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
The name of the App Attach package arm object

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: AppAttachPackageName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PackageAlias
Package Alias from extract MSIX Image

```yaml
Type: System.String
Parameter Sets: ExpandImage, Improved
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PackageApplication
List of package applications.
To construct, see NOTES section for PACKAGEAPPLICATION properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220901Privatepreview.IMsixPackageApplications[]
Parameter Sets: Improved
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PackageDependency
List of package dependencies.
To construct, see NOTES section for PACKAGEDEPENDENCY properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220901Privatepreview.IMsixPackageDependencies[]
Parameter Sets: Improved
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PackageFamilyName
Package Family Name from appxmanifest.xml; contains package name and publisher name

```yaml
Type: System.String
Parameter Sets: Improved
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PackageFullName
Package Full Name from appxmanifest.xml.

```yaml
Type: System.String
Parameter Sets: Improved
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PackageName
Package Name from appxmanifest.xml.

```yaml
Type: System.String
Parameter Sets: Improved
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PackageRelativePath
Relative Path to the package inside the image.

```yaml
Type: System.String
Parameter Sets: Improved
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PermissionsToAdd
List of object ids to add permissions to the package

```yaml
Type: System.String[]
Parameter Sets: ExpandImage, ImageObject, Improved
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PermissionsToRemove
List of object ids to remove permissions from the package

```yaml
Type: System.String[]
Parameter Sets: ExpandImage, ImageObject, Improved
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -SystemDataCreatedAt
The timestamp of resource creation (UTC).

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SystemDataCreatedBy
The identity that created the resource.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SystemDataCreatedByType
The type of identity that created the resource.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SystemDataLastModifiedAt
The timestamp of resource last modification (UTC)

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SystemDataLastModifiedBy
The identity that last modified the resource.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SystemDataLastModifiedByType
The type of identity that last modified the resource.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CreatedByType
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tag
Resource tags.

```yaml
Type: System.Collections.Hashtable
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Version
Package Version found in the appxmanifest.xml.

```yaml
Type: System.String
Parameter Sets: Improved
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220901Privatepreview.ExpandMsixImage[]

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220901Privatepreview.IAppAttachPackage

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


IMAGEOBJECTS <ExpandMsixImage[]>: 
  - `[CertificateExpiry <DateTime?>]`: Date certificate expires, found in the appxmanifest.xml. 
  - `[CertificateName <String>]`: Certificate name found in the appxmanifest.xml. 
  - `[DisplayName <String>]`: User friendly Name to be displayed in the portal. 
  - `[ImagePath <String>]`: VHD/CIM image path on Network Share.
  - `[IsActive <Boolean?>]`: Make this version of the package the active one across the hostpool. 
  - `[IsRegularRegistration <Boolean?>]`: Specifies how to register Package in feed.
  - `[LastUpdated <DateTime?>]`: Date Package was last updated, found in the appxmanifest.xml. 
  - `[PackageAlias <String>]`: Alias of MSIX Package.
  - `[PackageApplication <IMsixPackageApplications[]>]`: List of package applications. 
    - `[AppId <String>]`: Package Application Id, found in appxmanifest.xml.
    - `[AppUserModelId <String>]`: Used to activate Package Application. Consists of Package Name and ApplicationID. Found in appxmanifest.xml.
    - `[Description <String>]`: Description of Package Application.
    - `[FriendlyName <String>]`: User friendly name.
    - `[IconImageName <String>]`: User friendly name.
    - `[RawIcon <Byte[]>]`: the icon a 64 bit string as a byte array.
    - `[RawPng <Byte[]>]`: the icon a 64 bit string as a byte array.
  - `[PackageDependency <IMsixPackageDependencies[]>]`: List of package dependencies. 
    - `[DependencyName <String>]`: Name of package dependency.
    - `[MinVersion <String>]`: Dependency version required.
    - `[Publisher <String>]`: Name of dependency publisher.
  - `[PackageFamilyName <String>]`: Package Family Name from appxmanifest.xml. Contains Package Name and Publisher name. 
  - `[PackageFullName <String>]`: Package Full Name from appxmanifest.xml. 
  - `[PackageName <String>]`: Package Name from appxmanifest.xml. 
  - `[PackageRelativePath <String>]`: Relative Path to the package inside the image. 
  - `[Version <String>]`: Package Version found in the appxmanifest.xml. 

IMAGEPACKAGEAPPLICATION <IMsixPackageApplications[]>: List of package applications. 
  - `[AppId <String>]`: Package Application Id, found in appxmanifest.xml.
  - `[AppUserModelId <String>]`: Used to activate Package Application. Consists of Package Name and ApplicationID. Found in appxmanifest.xml.
  - `[Description <String>]`: Description of Package Application.
  - `[FriendlyName <String>]`: User friendly name.
  - `[IconImageName <String>]`: User friendly name.
  - `[RawIcon <Byte[]>]`: the icon a 64 bit string as a byte array.
  - `[RawPng <Byte[]>]`: the icon a 64 bit string as a byte array.

IMAGEPACKAGEDEPENDENCY <IMsixPackageDependencies[]>: List of package dependencies. 
  - `[DependencyName <String>]`: Name of package dependency.
  - `[MinVersion <String>]`: Dependency version required.
  - `[Publisher <String>]`: Name of dependency publisher.

PACKAGEAPPLICATION <IMsixPackageApplications[]>: List of package applications.
  - `[AppId <String>]`: Package Application Id, found in appxmanifest.xml.
  - `[AppUserModelId <String>]`: Used to activate Package Application. Consists of Package Name and ApplicationID. Found in appxmanifest.xml.
  - `[Description <String>]`: Description of Package Application.
  - `[FriendlyName <String>]`: User friendly name.
  - `[IconImageName <String>]`: User friendly name.
  - `[RawIcon <Byte[]>]`: the icon a 64 bit string as a byte array.
  - `[RawPng <Byte[]>]`: the icon a 64 bit string as a byte array.

PACKAGEDEPENDENCY <IMsixPackageDependencies[]>: List of package dependencies.
  - `[DependencyName <String>]`: Name of package dependency.
  - `[MinVersion <String>]`: Dependency version required.
  - `[Publisher <String>]`: Name of dependency publisher.

## RELATED LINKS

