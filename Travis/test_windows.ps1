param(
    [string]$tag
)
New-Variable -Name "VERSION_PATTERN" -Value "^[0-9]+\.[0-9]+\.[0-9]"

dotnet build -c Release

if("$tag" -eq "")
{
    dotnet pack -c Release --output nupkgs -p:PackageVersion="0.0.0" -p:AssemblyVersion="0.0.0.0"
}
elseif ("$tag" -match $VERSION_PATTERN)
{
    dotnet pack -c Release --output nupkgs -p:PackageVersion="$tag" -p:AssemblyVersion="$tag.0"
}
else
{
    Write-Output "Git Tag has to resemble a package version (e.g. 1.0.0)."
    exit 1
}
#dotnet test -c Release
dotnet nuget push ($PWD.Path + "\ArchUnitNET\nupkgs\TngTech.ArchUnitNET.*.nupkg") -k "test123" -s $source
dotnet nuget push ($PWD.Path + "\ArchUnitNET.xUnit\nupkgs\TngTech.ArchUnitNET.xUnit.*.nupkg") -k "test123" -s $source
dotnet nuget push ($PWD.Path + "\ArchUnitNET.NUnit\nupkgs\TngTech.ArchUnitNET.xUnit.*.nupkg") -k "test123" -s $source