param(
[string]$apiKey,
[string]$source,
[string]$tag
)

dotnet nuget push ($PWD.Path + "\ArchUnitNET\nupkgs\TngTech.ArchUnitNET.*.nupkg") -k "test123" -s $source
dotnet nuget push ($PWD.Path + "\ArchUnitNET.xUnit\nupkgs\TngTech.ArchUnitNET.xUnit.*.nupkg") -k "test123" -s $source
dotnet nuget push ($PWD.Path + "\ArchUnitNET.NUnit\nupkgs\TngTech.ArchUnitNET.xUnit.*.nupkg") -k "test123" -s $source
