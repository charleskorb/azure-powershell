### Example 1: Expands specified Image Path and retrieves Package metadata found in AppxManifest.xml
```powershell
Expand-AzWvdMsixImage -HostPoolName HostPoolName `
          -ResourceGroupName resourceGroupName `
          -SubscriptionId SubscriptionId `
          -Uri ImagePathURI

Name                          Type
----                          ----
HostPoolName/extractmsiximage Microsoft.DesktopVirtualization/hostpools/extractmsiximage
```

This command returns Metadata of MSIX Package found in the given Image Path.

### Example 2: Expands specified Image Path as a positional parameter and retrieves Package metadata found in AppxManifest.xml. If package archtecture is not specified, it defaults to x64. If package architecture is specified to all, return all images in the virtual disk regardless architecture
```powershell
Expand-AzWvdMsixImage ImagePathUri `
          -HostPoolName HostPoolName `
          -ResourceGroupName resourceGroupName `
          -SubscriptionId SubscriptionId 
          -PackageArchitecture architecture

Name                          Type
----                          ----
HostPoolName/extractmsiximage Microsoft.DesktopVirtualization/hostpools/extractmsiximage
```

This command returns Metadata of MSIX Package found in the given Image Path.