# Are you running in 32-bit mode?
#   (\SysWOW64\ = 32-bit mode)

if ($PSHOME -like "*SysWOW64*")
{
  Write-Warning "Restarting this script under 64-bit Windows PowerShell."

  # Restart this script under 64-bit Windows PowerShell.
  #   (\SysNative\ redirects to \System32\ for 64-bit mode)

  & (Join-Path ($PSHOME -replace "SysWOW64", "SysNative") powershell.exe) -File (Join-Path $PSScriptRoot $MyInvocation.MyCommand) @args

  # Exit 32-bit script.

  Exit $LastExitCode
}

function DeleteIfExistsAndCreateEmptyFolder($dir)
{
    if ( Test-Path $dir) {    
        Get-ChildItem -Path $dir -Force -Recurse | Remove-Item -force -recurse
        Remove-Item $dir -Force
    }
    New-Item -ItemType Directory -Force -Path $dir
}


# Was restart successful?
Write-Warning "Hello from $PSHOME"
Write-Warning "  (\SysWOW64\ = 32-bit mode, \System32\ = 64-bit mode)"
Write-Warning "Original arguments (if any): $args"

#Stop IIs Server
Stop-IISSite -Name "Default Web Site"

#Delete old folder and recreate it
DeleteIfExistsAndCreateEmptyFolder("c:\inetpub\wwwroot")

