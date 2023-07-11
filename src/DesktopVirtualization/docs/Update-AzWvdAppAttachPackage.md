---
external help file:
Module Name: Az.DesktopVirtualization
online version: https://learn.microsoft.com/powershell/module/az.desktopvirtualization/update-azwvdappattachpackage
schema: 2.0.0
---

# Update-AzWvdAppAttachPackage

## SYNOPSIS
Update an App Attach Package

## SYNTAX

### UpdateExpanded (Default)
```
Update-AzWvdAppAttachPackage -Name <String> -ResourceGroupName <String> -Location <String>
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

### ImageObject
```
Update-AzWvdAppAttachPackage [-ImageObjects] <ExpandMsixImage[]> -Name <String> -ResourceGroupName <String>
 -Location <String> [-SubscriptionId <String>] [-DisplayName <String>]
 [-FailHealthCheckOnStagingFailure <FailHealthCheckOnStagingFailure>] [-HostPoolReference <String[]>]
 [-IsActive] [-IsLogonBlocking] [-KeyVaultUrl <String>] [-PermissionsToAdd <String[]>]
 [-PermissionsToRemove <String[]>] [-Tag <Hashtable>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Improved
```
Update-AzWvdAppAttachPackage -Name <String> -ResourceGroupName <String> -Location <String>
 [-SubscriptionId <String>] [-CertificateExpiry <DateTime>] [-CertificateName <String>]
 [-DisplayName <String>] [-FailHealthCheckOnStagingFailure <FailHealthCheckOnStagingFailure>]
 [-HostPoolReference <String[]>] [-ImagePath <String>] [-IsActive] [-IsLogonBlocking] [-KeyVaultUrl <String>]
 [-LastUpdated <DateTime>] [-PackageAlias <String>] [-PackageApplication <IMsixPackageApplications[]>]
 [-PackageDependency <IMsixPackageDependencies[]>] [-PackageFamilyName <String>] [-PackageFullName <String>]
 [-PackageName <String>] [-PackageRelativePath <String>] [-PermissionsToAdd <String[]>]
 [-PermissionsToRemove <String[]>] [-Tag <Hashtable>] [-Version <String>] [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-AzWvdAppAttachPackage -InputObject <IDesktopVirtualizationIdentity> -Location <String>
 [-FailHealthCheckOnStagingFailure <FailHealthCheckOnStagingFailure>] [-HostPoolReference <String[]>]
 [-ImageCertificateExpiry <DateTime>] [-ImageCertificateName <String>] [-ImageDisplayName <String>]
 [-ImageIsActive] [-ImageIsRegularRegistration] [-ImageLastUpdated <DateTime>] [-ImagePackageAlias <String>]
 [-ImagePackageApplication <IMsixPackageApplications[]>]
 [-ImagePackageDependency <IMsixPackageDependencies[]>] [-ImagePackageFamilyName <String>]
 [-ImagePackageFullName <String>] [-ImagePackageName <String>] [-ImagePackageRelativePath <String>]
 [-ImagePath <String>] [-ImageVersion <String>] [-KeyVaultUrl <String>] [-SystemDataCreatedAt <DateTime>]
 [-SystemDataCreatedBy <String>] [-SystemDataCreatedByType <CreatedByType>]
 [-SystemDataLastModifiedAt <DateTime>] [-SystemDataLastModifiedBy <String>]
 [-SystemDataLastModifiedByType <CreatedByType>] [-Tag <Hashtable>] [-DefaultProfile <PSObject>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update an App Attach Package

## EXAMPLES

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
User friendly Name to be displayed in the portal.

```yaml
Type: System.String
Parameter Sets: ImageObject, Improved
Aliases:

Required: False
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

Required: False
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: Improved, UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImageVersion
Package Version found in the appxmanifest.xml.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IDesktopVirtualizationIdentity
Parameter Sets: UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsActive
Make this version of the package the active one across the hostpool.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ImageObject, Improved
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsLogonBlocking
Specifies how to register Package in feed.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: ImageObject, Improved
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

Required: False
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
Parameter Sets: ImageObject, Improved, UpdateExpanded
Aliases: AppAttachPackageName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PackageAlias
Alias of MSIX Package.

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

Required: False
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

Required: False
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

Required: False
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

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PermissionsToAdd
List of object ids to add permissions to the package

```yaml
Type: System.String[]
Parameter Sets: ImageObject, Improved
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
Parameter Sets: ImageObject, Improved
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
Parameter Sets: ImageObject, Improved, UpdateExpanded
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
Parameter Sets: ImageObject, Improved, UpdateExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

Required: False
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

### Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IDesktopVirtualizationIdentity

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

INPUTOBJECT <IDesktopVirtualizationIdentity>: Identity Parameter
  - `[AppAttachPackageName <String>]`: The name of the App Attach package arm object
  - `[ApplicationGroupName <String>]`: The name of the application group
  - `[ApplicationName <String>]`: The name of the application within the specified application group
  - `[DesktopName <String>]`: The name of the desktop within the specified desktop group
  - `[HostPoolName <String>]`: The name of the host pool within the specified resource group
  - `[Id <String>]`: Resource identity path
  - `[MsixPackageFullName <String>]`: The version specific package full name of the MSIX package within specified hostpool
  - `[PrivateEndpointConnectionName <String>]`: The name of the private endpoint connection associated with the Azure resource
  - `[ResourceGroupName <String>]`: The name of the resource group. The name is case insensitive.
  - `[ScalingPlanName <String>]`: The name of the scaling plan.
  - `[ScalingPlanScheduleName <String>]`: The name of the ScalingPlanSchedule
  - `[SessionHostName <String>]`: The name of the session host within the specified host pool
  - `[SubscriptionId <String>]`: The ID of the target subscription.
  - `[UserSessionId <String>]`: The name of the user session within the specified session host
  - `[WorkspaceName <String>]`: The name of the workspace

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

