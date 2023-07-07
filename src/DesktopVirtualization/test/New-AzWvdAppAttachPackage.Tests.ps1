$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-AzWvdAppAttachPackage.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-AzWvdAppAttachPackage' {
    It 'CreateExpanded' {
        try {
            $enc = [system.Text.Encoding]::UTF8
            $string1 = "some image"
            $data1 = $enc.GetBytes($string1) 

            $apps = @( [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220901Privatepreview.IMsixPackageApplications]@{appId = 'MsixTest_Application_Id'; description = 'testing from ps'; appUserModelID = 'MsixTest_Application_ModelID'; friendlyName = 'some name'; iconImageName = 'Apptile'; rawIcon = $data1; rawPng = $data1 })
            $deps = @( [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220901Privatepreview.IMsixPackageDependencies]@{dependencyName = 'MsixTest_Dependency_Name'; publisher = 'MsixTest_Dependency_Publisher'; minVersion = '0.0.0.42' })   

            $package_created_1 = New-AzWvdAppAttachPackage -Name "TestPackage" `
                -ImagePackageFullName 'AATest_FullName_UnitTest' `
                -ResourceGroupName $env.ResourceGroup `
                -SubscriptionId $env.SubscriptionId `
                -Location $env.Location `
                -ImageDisplayName 'UnitTest-MSIXPackage' `
                -ImagePath 'C:\\msix\SingleMsix.vhd' `
                -ImageIsActive `
                -ImageIsRegularRegistration `
                -ImageLastUpdated '0001-01-01T00:00:00' `
                -ImagePackageApplication $apps `
                -ImagePackageDependency $deps `
                -ImagePackageFamilyName 'MsixUnitTest_FamilyName' `
                -ImagePackageName 'MsixUnitTest_Name' `
                -ImagePackageRelativePath 'MsixUnitTest_RelativePackageRoot' `
                -FailHealthCheckOnStagingFailure 'Unhealthy' `
                -ImageVersion '0.0.18838.722' 

            $packages = Get-AzWvdAppAttachPackage -Name "TestPackage"`
                -ResourceGroupName $env.ResourceGroup `
                -SubscriptionId $env.SubscriptionId  

            $packages[0].ImagePackageFamilyName | Should -Be  'MsixUnitTest_FamilyName'
            $packages[0].ImagePath | Should -Be 'C:\\msix\SingleMsix.vhd'
            ($packages[0].ImagePackageApplication | ConvertTo-Json) | Should -Be ($apps | ConvertTo-Json)
            ($packages[0].ImagePackageDependency | ConvertTo-Json) | Should -Be ($deps | ConvertTo-Json)
            $packages[0].ImagePackageName | Should -Be 'MsixUnitTest_Name'
            $packages[0].ImagePackageRelativePath | Should -Be 'MsixUnitTest_RelativePackageRoot'
        } 
        finally{
            $package = Remove-AzWvdAppAttachPackage -Name 'TestPackage' `
                -ResourceGroupName $env.ResourceGroup `
                -SubscriptionId $env.SubscriptionId 
        }
    }    
    It 'Improved' {
        try { 
            $enc = [system.Text.Encoding]::UTF8
            $string1 = "some image"
            $data1 = $enc.GetBytes($string1) 

            $apps = @( [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220901Privatepreview.IMsixPackageApplications]@{appId = 'MsixTest_Application_Id'; description = 'testing from ps'; appUserModelID = 'MsixTest_Application_ModelID'; friendlyName = 'some name'; iconImageName = 'Apptile'; rawIcon = $data1; rawPng = $data1 })
            $deps = @( [Microsoft.Azure.PowerShell.Cmdlets.DesktopVirtualization.Models.Api20220901Privatepreview.IMsixPackageDependencies]@{dependencyName = 'MsixTest_Dependency_Name'; publisher = 'MsixTest_Dependency_Publisher'; minVersion = '0.0.0.42' })   

            $package_created_1 = New-AzWvdAppAttachPackage -Name "TestPackage" `
                -PackageFullName 'AATest_FullName_UnitTest' `
                -ResourceGroupName $env.ResourceGroup `
                -SubscriptionId $env.SubscriptionId `
                -Location $env.Location `
                -DisplayName 'UnitTest-MSIXPackage' `
                -ImagePath 'C:\\msix\SingleMsix.vhd' `
                -IsActive `
                -IsRegularRegistration `
                -LastUpdated '0001-01-01T00:00:00' `
                -PackageApplication $apps `
                -PackageDependency $deps `
                -PackageFamilyName 'MsixUnitTest_FamilyName' `
                -PackageName 'MsixUnitTest_Name' `
                -PackageRelativePath 'MsixUnitTest_RelativePackageRoot' `
                -FailHealthCheckOnStagingFailure 'Unhealthy' `
                -Version '0.0.18838.722' 

            $packages = Get-AzWvdAppAttachPackage -Name "TestPackage"`
                -ResourceGroupName $env.ResourceGroup `
                -SubscriptionId $env.SubscriptionId  

            $packages[0].ImagePackageFamilyName | Should -Be  'MsixUnitTest_FamilyName'
            $packages[0].ImagePath | Should -Be 'C:\\msix\SingleMsix.vhd'
            ($packages[0].ImagePackageApplication | ConvertTo-Json) | Should -Be ($apps | ConvertTo-Json)
            ($packages[0].ImagePackageDependency | ConvertTo-Json) | Should -Be ($deps | ConvertTo-Json)
            $packages[0].ImagePackageName | Should -Be 'MsixUnitTest_Name'
            $packages[0].ImagePackageRelativePath | Should -Be 'MsixUnitTest_RelativePackageRoot'
         } 
         finally{
            $package = Remove-AzWvdAppAttachPackage -Name 'TestPackage' `
                -ResourceGroupName $env.ResourceGroup `
                -SubscriptionId $env.SubscriptionId 
         }
    }
    It 'ImageObject' {
        try {
            $image = Expand-AzWvdMsixImage -HostPoolName $env.HostPoolPersistent2 `
                -ResourceGroupName $env.ResourceGroupPersistent `
                -SubscriptionId $env.SubscriptionId `
                -Uri $env.MSIXImagePath
        
            $image.PackageFamilyName | Should -Be  'Mozilla.MozillaFirefox_gmpnhwe7bv608'
            $image.ImagePath | Should -Be 'C:\AppAttach\Firefox20110.0.1.vhdx'
            $image.PackageName | Should -Be 'Mozilla.MozillaFirefox'
            $image.PackageAlias | Should -Be 'mozillamozillafirefox'
            $image.IsActive | Should -Be $False
            $image.IsRegularRegistration | Should -Be $False
            $image.PackageRelativePath | Should -Be '\apps\Mozilla.MozillaFirefox_110.0.1.0_x64__gmpnhwe7bv608'

            $package_created_1 = New-AzWvdAppAttachPackage -Name "TestPackage" `
                -ResourceGroupName $env.ResourceGroup `
                -SubscriptionId $env.SubscriptionId `
                -Location $env.Location `
                -ImageObject $image `
                -FailHealthCheckOnStagingFailure 'Unhealthy' 

            $packages = Get-AzWvdAppAttachPackage -Name "TestPackage"`
                -ResourceGroupName $env.ResourceGroup `
                -SubscriptionId $env.SubscriptionId  
                
            $packages[0].ImagePackageFamilyName | Should -Be  'Mozilla.MozillaFirefox_gmpnhwe7bv608'
            $packages[0].ImagePath | Should -Be 'C:\AppAttach\Firefox20110.0.1.vhdx'
            $packages[0].ImagePackageName | Should -Be 'Mozilla.MozillaFirefox'
            $packages[0].ImagePackageRelativePath | Should -Be '\apps\Mozilla.MozillaFirefox_110.0.1.0_x64__gmpnhwe7bv608'
            ($packages[0].ImagePackageApplication | ConvertTo-Json) | Should -Be ($image.PackageApplication | ConvertTo-Json)


        }
        finally{
            Remove-AzWvdAppAttachPackage -Name 'TestPackage' `
                -ResourceGroupName $env.ResourceGroup `
                -SubscriptionId $env.SubscriptionId 
        }
    }
    It 'ExpandImage' {
        try {

            $image = Expand-AzWvdMsixImage -HostPoolName $env.HostPoolPersistent2 `
                -ResourceGroupName $env.ResourceGroupPersistent `
                -SubscriptionId $env.SubscriptionId `
                -Uri $env.MSIXImagePath

            $package = New-AzWvdAppAttachPackage -PackageAlias 'mozillamozillafirefox' `
                -ImagePath 'C:\AppAttach\Firefox20110.0.1.vhdx' `
                -ExpandingHostPoolName $env.HostPoolPersistent2 `
                -ExpandingHostpoolResourceGroupName $env.ResourceGroupPersistent `
                -ExpandingHostpoolSubscriptionId $env.SubscriptionId  `
                -Name "TestPackage" `
                -ResourceGroupName $env.ResourceGroupPersistent `
                -SubscriptionId $env.SubscriptionId `
                -Location $env.Location `
                -FailHealthCheckOnStagingFailure 'Unhealthy'

            $packages = Get-AzWvdAppAttachPackage -Name "TestPackage"`
                -ResourceGroupName $env.ResourceGroupPersistent `
                -SubscriptionId $env.SubscriptionId  
                
            $packages[0].ImagePackageFamilyName | Should -Be  'Mozilla.MozillaFirefox_gmpnhwe7bv608'
            $packages[0].ImagePath | Should -Be 'C:\AppAttach\Firefox20110.0.1.vhdx'
            $packages[0].ImagePackageName | Should -Be 'Mozilla.MozillaFirefox'
            $packages[0].ImagePackageRelativePath | Should -Be '\apps\Mozilla.MozillaFirefox_110.0.1.0_x64__gmpnhwe7bv608'
            ($packages[0].ImagePackageApplication | ConvertTo-Json) | Should -Be ($image.PackageApplication | ConvertTo-Json)

        }
        finally{
            Remove-AzWvdAppAttachPackage -Name 'TestPackage' `
                -ResourceGroupName $env.ResourceGroupPersistent `
                -SubscriptionId $env.SubscriptionId 
        }
    }
    It 'ExpandImageNoAlias' {
        try {

            $image = Expand-AzWvdMsixImage -HostPoolName $env.HostPoolPersistent2 `
                -ResourceGroupName $env.ResourceGroupPersistent `
                -SubscriptionId $env.SubscriptionId `
                -Uri $env.MSIXImagePath

            $package = New-AzWvdAppAttachPackage `
                -ImagePath 'C:\AppAttach\Firefox20110.0.1.vhdx' `
                -ExpandingHostPoolName $env.HostPoolPersistent2 `
                -ExpandingHostpoolResourceGroupName $env.ResourceGroupPersistent `
                -ExpandingHostpoolSubscriptionId $env.SubscriptionId  `
                -Name "TestPackage" `
                -ResourceGroupName $env.ResourceGroupPersistent `
                -SubscriptionId $env.SubscriptionId `
                -Location $env.Location `
                -FailHealthCheckOnStagingFailure 'Unhealthy'

            $packages = Get-AzWvdAppAttachPackage -Name "TestPackage"`
                -ResourceGroupName $env.ResourceGroupPersistent `
                -SubscriptionId $env.SubscriptionId  
                
            $packages[0].ImagePackageFamilyName | Should -Be  'Mozilla.MozillaFirefox_gmpnhwe7bv608'
            $packages[0].ImagePath | Should -Be 'C:\AppAttach\Firefox20110.0.1.vhdx'
            $packages[0].ImagePackageName | Should -Be 'Mozilla.MozillaFirefox'
            $packages[0].ImagePackageRelativePath | Should -Be '\apps\Mozilla.MozillaFirefox_110.0.1.0_x64__gmpnhwe7bv608'
            ($packages[0].ImagePackageApplication | ConvertTo-Json) | Should -Be ($image.PackageApplication | ConvertTo-Json)

        }
        finally{
            Remove-AzWvdAppAttachPackage -Name 'TestPackage' `
                -ResourceGroupName $env.ResourceGroupPersistent `
                -SubscriptionId $env.SubscriptionId 
        }
    }
}
