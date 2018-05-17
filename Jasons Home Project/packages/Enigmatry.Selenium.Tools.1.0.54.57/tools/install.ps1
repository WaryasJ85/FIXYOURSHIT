param($installPath, $toolsPath, $package, $project)

function Get-ProjectProperty($name)
{
    $property = $project.Properties.Item($name)
    if (!$property)
    {
        return $null
    }
    return $property.Value
}


$packagePath = Join-Path $toolsPath ".."
$projectPath = Get-ProjectProperty FullPath
$toolAppConfig = Join-Path $toolsPath App.config
$projAppConfig = Join-Path $projectPath App.config

if (!(Test-Path $projAppConfig)) {
	Copy-Item $toolAppConfig $projAppConfig
	$project.ProjectItems.AddFromFile($projAppConfig)
}