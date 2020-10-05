param(
[string]$apiKey,
[string]$source,
[string]$tag
)
New-Variable -Name "ArchUnitNET" -Value $PWD.Path + "\ArchUnitNET\nupkgs\TngTech.ArchUnitNET.*.nupkg"
New-Variable -Name "ArchUnitNETxUnit" -Value $PWD.Path + "\ArchUnitNET.xUnit\nupkgs\TngTech.ArchUnitNET.xUnit.*.nupkg"
New-Variable -Name "ArchUnitNETNUnit" -Value $PWD.Path + "\ArchUnitNET.NUnit\nupkgs\TngTech.ArchUnitNET.xUnit.*.nupkg"

dotnet nuget push $ArchUnitNET -k "test123" -s $source
dotnet nuget push $ArchUnitNETxUnit -k "test123" -s $source
dotnet nuget push $ArchUnitNETNUnit -k "test123" -s $source
