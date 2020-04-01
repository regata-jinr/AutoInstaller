# TODO: check if genie already installed

param([String]$vers = "3.2.1", [String]$lang = "eng")

if (-not (Test-Path .tmp))
{
	New-Item -Type "Directory" .tmp
}

cd .tmp

$versionDict = @{"3.2.1" = "https://disk.jinr.ru/index.php/s/kWgZGP526mk5r4b/download"; "3.4.0" = "https://disk.jinr.ru/index.php/s/88SNe25nNJbJY4k/download" }

Write-Output "Welcome to the Regata Auto Installation process!"
Write-Output ""
Write-Output "Now chosen version of genie2k will be install"

$archName = ("Genie2KV" + $vers + ".zip")


Write-Output ("Downloading Genie2kV" + $vers)
Invoke-WebRequest -Uri $versionDict[$vers] -OutFile $archName

Write-Output "Extracting files..."
Expand-Archive -Path $archName -DestinationPath .

Write-Output ("Getting language settings...")

Invoke-WebRequest -Uri ("https://raw.githubusercontent.com/regata-jinr/AutoInstaller/master/inis/G2KV" + $vers + "/s504" + $lang + ".iss") -OutFile ("S500_502_504\Bin\G2KV" + $vers + "\S504\setup.iss")
Invoke-WebRequest -Uri ("https://raw.githubusercontent.com/regata-jinr/AutoInstaller/master/inis/G2KV" + $vers + "/s501" + $lang + ".iss") -OutFile ("S501\setup.iss")
Invoke-WebRequest -Uri ("https://raw.githubusercontent.com/regata-jinr/AutoInstaller/master/inis/G2KV" + $vers + "/s506" + $lang + ".iss") -OutFile ("S506\setup.iss")

Write-Output "S504 GENIE-2000 InSpector Basic Spectroscopy installing..."
Start-Process -Wait ("S500_502_504\Bin\G2KV" + $vers + "\S504\setup.exe") /s

Write-Output "S501 GENIE-2000 Gamma Analysis installing..."
Start-Process -Wait .\S501\setup.exe /s

Write-Output "S506 GENIE-2000 Interactive Peak Fit..."s
Start-Process -Wait .\S506\setup.exe /s
