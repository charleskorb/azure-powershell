---
external help file:
Module Name: Az.DesktopVirtualization
online version: https://learn.microsoft.com/powershell/module/az.desktopvirtualization/new-azwvdapplication
schema: 2.0.0
---

# New-AzWvdApplication

## SYNOPSIS
Create or update an application.

## SYNTAX

### CreateExpanded (Default)
```
New-AzWvdApplication -CommandLineSetting <CommandLineSetting> -GroupName <String> -Name <String>
 -ResourceGroupName <String> [-Description <String>] [-FriendlyName <String>] [-ShowInPortal]
 [-SubscriptionId <String>] [-ApplicationType <RemoteApplicationType>] [-CommandLineArgument <String>]
 [-FilePath <String>] [-IconIndex <Int32>] [-IconPath <String>] [-MsixPackageApplicationId <String>]
 [-MsixPackageFamilyName <String>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AppAlias
```
New-AzWvdApplication -AppAlias <String> -CommandLineSetting <CommandLineSetting> -GroupName <String>
 -Name <String> -ResourceGroupName <String> [-Description <String>] [-FriendlyName <String>] [-ShowInPortal]
 [-SubscriptionId <String>] [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AppAttachPackage
```
New-AzWvdApplication [-AppAttachPackage] <IAppAttachPackage> -GroupName <String> -Name <String>
 -ResourceGroupName <String> [-Description <String>] [-FriendlyName <String>] [-ShowInPortal]
 [-SubscriptionId <String>] [-IconIndex <Int32>] [-IconPath <String>] [-MsixPackageApplicationId <String>]
 [-DefaultProfile <PSObject>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create or update an application.

## EXAMPLES

### Example 1: Create a Windows Virtual Desktop Application
```powershell
New-AzWvdApplication -ResourceGroupName ResourceGroupName `
                             -GroupName ApplicationGroupName `
                             -Name ApplicationName `
                             -FilePath 'C:\windows\system32\mspaint.exe' `
                             -FriendlyName 'Friendly name' `
                             -Description 'Description' `
                             -IconIndex 0 `
                             -IconPath 'C:\windows\system32\mspaint.exe' `
                             -CommandLineSetting 'Allow' `
                             -ShowInPortal:$true
```

```output
Name                                 Type
----                                 ----
ApplicationGroupName/ApplicationName Microsoft.DesktopVirtualization/applicationgroups/applications
```

This command creates a Windows Virtual Desktop Application in an applicaton Group.

## PARAMETERS

### -AppAlias
App Alias from start menu item

```yaml
Type: System.String
Parameter Sets: AppAlias
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppAttachPackage
To construct, see NOTES section for APPATTACHPACKAGE properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220901Privatepreview.IAppAttachPackage
Parameter Sets: AppAttachPackage
Aliases:

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ApplicationType
Resource Type of Application.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.RemoteApplicationType
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CommandLineArgument
Command Line Arguments for Application.

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

### -CommandLineSetting
Specifies whether this published application can be launched with command line arguments provided by the client, command line arguments specified at publish time, or no command line arguments at all.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Support.CommandLineSetting
Parameter Sets: AppAlias, CreateExpanded
Aliases:

Required: True
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

### -Description
Description of Application.

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

### -FilePath
Specifies a path for the executable file for the application.

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

### -FriendlyName
Friendly name of Application.

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

### -GroupName
The name of the application group

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: ApplicationGroupName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IconIndex
Index of the icon.

```yaml
Type: System.Int32
Parameter Sets: AppAttachPackage, CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IconPath
Path to icon.

```yaml
Type: System.String
Parameter Sets: AppAttachPackage, CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MsixPackageApplicationId
Specifies the package application Id for MSIX applications

```yaml
Type: System.String
Parameter Sets: AppAttachPackage, CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MsixPackageFamilyName
Specifies the package family name for MSIX applications

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

### -Name
The name of the application within the specified application group

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: ApplicationName

Required: True
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

### -ShowInPortal
Specifies whether to show the RemoteApp program in the RD Web Access server.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
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

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220901Privatepreview.IApplication

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


APPATTACHPACKAGE <IAppAttachPackage>: 
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
  - `[ImageIsPackageTimestamped <Boolean?>]`: Is package timestamped so it can ignore the certificate expiry date
  - `[ImageIsRegularRegistration <Boolean?>]`: Specifies how to register Package in feed.
  - `[ImageLastUpdated <DateTime?>]`: Date Package was last updated, found in the appxmanifest.xml. 
  - `[ImagePackageAlias <String>]`: Alias of MSIX Package.
  - `[ImagePackageApplication <IMsixPackageApplications[]>]`: List of package applications. 
    - `[AppId <String>]`: Package Application Id, found in appxmanifest.xml.
    - `[AppUserModelId <String>]`: Used to activate Package Application. Consists of Package Name and ApplicationID. Found in appxmanifest.xml.
    - `[Description <String>]`: Description of Package Application.
    - `[FriendlyName <String>]`: User friendly name.
    - `[IconImageName <String>]`: User friendly name.
    - `[IconIndexMaxValue <Int32?>]`: Maximum index of icons in the executable in the image
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

