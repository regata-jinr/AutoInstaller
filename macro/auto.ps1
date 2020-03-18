# TODO: check if genie already exist
# TODO: choose version as parameter
# TODO: dict with version and link
# TODO: download files 
# TODO: dict with language and rename function
# TODO: move workprog to c

# set-executionpolicy remotesigned

param([String]$vers = "3.2.1", [String]$lang = "eng")

New-Item -Type "Directory" .tmp

cd .tmp

$versionDict = @{"3.2.1" = "https://disk.jinr.ru/index.php/s/BjsEq2KXtFSdGDc/download"; "3.4.0" = "https://disk.jinr.ru/index.php/s/855yicC8f3QNC7d/download" }

Write-Output "Welcome to the Regata Auto Installation process!"
Write-Output ""
Write-Output "Now chosen version of genie2k will be install"

$archName = ("Genie2KV" + $vers + ".zip")


Write-Output ("Downloading Genie2kV" + $vers)
Invoke-WebRequest -Uri $versionDict[$vers] -OutFile $archName

Write-Output "Extracting files..."
Expand-Archive -Path $archName -DestinationPath .

$pat = ("*" + $lang + ".iss")

Write-Output "Setting lanugage"
gci -Recurse *.iss | ForEach-Object { if ($_.Name.ToLower().Contains($lang)) { Rename-Item $_ "setup.iss" } }

Write-Output "S504 GENIE-2000 InSpector Basic Spectroscopy installing..."
Start-Process -Wait .\S504\setup.exe /s

Write-Output "S501 GENIE-2000 Gamma Analysis installing..."
Start-Process -Wait .\S501\setup.exe /s

Write-Output "S506 GENIE-2000 Interactive Peak Fit..."s
Start-Process -Wait .\S506\setup.exe /s
