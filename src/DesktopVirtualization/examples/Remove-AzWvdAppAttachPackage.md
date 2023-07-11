### Example 1: Delete an Azure Virtual Desktop App Attach Package by name
```powershell
Remove-AzWvdAppAttachPackage -ResourceGroupName ResourceGroupName -Name HostPoolName
```

This command deletes an Azure Virtual Desktop App Attach Package in a Resource Group.


### Example 2: Delete an Azure Virtual Desktop App Attach Package by object
```powershell
Remove-AzWvdAppAttachPackage $packageThatYouGotFromCallingGet
```

This command deletes an Azure Virtual Desktop App Attach Package in a Resource Group.