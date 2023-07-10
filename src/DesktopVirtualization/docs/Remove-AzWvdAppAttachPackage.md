---
external help file:
Module Name: Az.DesktopVirtualization
online version: https://learn.microsoft.com/powershell/module/az.desktopvirtualization/remove-azwvdappattachpackage
schema: 2.0.0
---

# Remove-AzWvdAppAttachPackage

## SYNOPSIS
Remove an App Attach Package.

## SYNTAX

### Delete (Default)
```
Remove-AzWvdAppAttachPackage -Name <String> -ResourceGroupName <String> [-SubscriptionId <String>] [-Force]
 [-DefaultProfile <PSObject>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### DeleteViaIdentity
```
Remove-AzWvdAppAttachPackage -InputObject <IDesktopVirtualizationIdentity> [-Force]
 [-DefaultProfile <PSObject>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Improved
```
Remove-AzWvdAppAttachPackage [-PackageToRemove] <IAppAttachPackage> [-DefaultProfile <PSObject>]
 [<CommonParameters>]
```

## DESCRIPTION
Remove an App Attach Package.

## EXAMPLES

### Example 1: Delete an Azure Virtual Desktop App Attach Package by name
```powershell
Remove-AzWvdAppAttachPackage -ResourceGroupName ResourceGroupName -Name HostPoolName
```

This command deletes an Azure Virtual Desktop App Attach Package in a Resource Group.

## PARAMETERS

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

### -Force
Force flag to delete App Attach package.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: Delete, DeleteViaIdentity
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
Parameter Sets: DeleteViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
The name of the App Attach package arm object

```yaml
Type: System.String
Parameter Sets: Delete
Aliases: AppAttachPackageName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PackageToRemove
App Attach Package to be Removed
To construct, see NOTES section for PACKAGETOREMOVE properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220901Privatepreview.IAppAttachPackage
Parameter Sets: Improved
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: Delete, DeleteViaIdentity
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
Parameter Sets: Delete
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
Parameter Sets: Delete
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
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

### Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220901Privatepreview.IAppAttachPackage

### Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.IDesktopVirtualizationIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


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

PACKAGETOREMOVE <IAppAttachPackage>: App Attach Package to be Removed
  - `Location <String>`: The geo-location where the resource lives
  - `[Tag <ITrackedResourceTags>]`: Resource tags.
    - `[(Any) <String>]`: This indicates any property can be added to this object.
  - `[SystemDataCreatedAt <DateTime?>]`: The timestamp of resource creation (UTC).
  - `[SystemDataCreatedBy <String>]`: The identity that created the resource.
  - `[SystemDataCreatedByType <CreatedByType?>]`: The type of identity that created the resource.
  - `[SystemDataLastModifiedAt <DateTime?>]`: The timestamp of resource last modification (UTC)
  - `[SystemDataLastModifiedBy <String>]`: The identity that last modified the resource.
  - `[SystemDataLastModifiedByType <CreatedByType?>]`: The type of identity that last modified the resource.
  - `[FailHealthCheckOnStagingFailure <FailHealthCheckOnStagingFailure?>]`: Parameter indicating how the health check should behave if this package fails staging
  - `[HostPoolReference <String[]>]`: List of Hostpool resource Ids.
  - `[ImageCertificateExpiry <DateTime?>]`: Date certificate expires, found in the appxmanifest.xml. 
  - `[ImageCertificateName <String>]`: Certificate name found in the appxmanifest.xml. 
  - `[ImageDisplayName <String>]`: User friendly Name to be displayed in the portal. 
  - `[ImageIsActive <Boolean?>]`: Make this version of the package the active one across the hostpool. 
  - `[ImageIsRegularRegistration <Boolean?>]`: Specifies how to register Package in feed.
  - `[ImageLastUpdated <DateTime?>]`: Date Package was last updated, found in the appxmanifest.xml. 
  - `[ImagePackageAlias <String>]`: Alias of MSIX Package.
  - `[ImagePackageApplication <IMsixPackageApplications[]>]`: List of package applications. 
    - `[AppId <String>]`: Package Application Id, found in appxmanifest.xml.
    - `[AppUserModelId <String>]`: Used to activate Package Application. Consists of Package Name and ApplicationID. Found in appxmanifest.xml.
    - `[Description <String>]`: Description of Package Application.
    - `[FriendlyName <String>]`: User friendly name.
    - `[IconImageName <String>]`: User friendly name.
    - `[RawIcon <Byte[]>]`: the icon a 64 bit string as a byte array.
    - `[RawPng <Byte[]>]`: the icon a 64 bit string as a byte array.
  - `[ImagePackageDependency <IMsixPackageDependencies[]>]`: List of package dependencies. 
    - `[DependencyName <String>]`: Name of package dependency.
    - `[MinVersion <String>]`: Dependency version required.
    - `[Publisher <String>]`: Name of dependency publisher.
  - `[ImagePackageFamilyName <String>]`: Package Family Name from appxmanifest.xml. Contains Package Name and Publisher name. 
  - `[ImagePackageFullName <String>]`: Package Full Name from appxmanifest.xml. 
  - `[ImagePackageName <String>]`: Package Name from appxmanifest.xml. 
  - `[ImagePackageRelativePath <String>]`: Relative Path to the package inside the image. 
  - `[ImagePath <String>]`: VHD/CIM image path on Network Share.
  - `[ImageVersion <String>]`: Package Version found in the appxmanifest.xml. 
  - `[KeyVaultUrl <String>]`: URL of keyvault location to store certificate

## RELATED LINKS

