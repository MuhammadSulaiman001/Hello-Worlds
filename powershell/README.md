# Powershell
- Getting started from https://learn.microsoft.com/en-us/powershell/scripting/learn/ps101/01-getting-started?view=powershell-7.5

- Some of the commands I like most:

```
$PSHOME
$env:PATH
Get-Help Get-Command # there is not --help
Get-Command git # shows you the path of git
Get-Content file.txt
Set-Content file.txt "some text"
echo "some text2" | Set-Content file2.txt
curl example.com >> file3.txt # `>>` appends string to file3.txt, but `>` overrides file3.txt content
git -h | wsl grep tag # pip to WSL2
git -h | Select-String tag # I liked this version
New-Item text4.txt | notepad text4.txt
New-Item folder1 -Type Directory # or mkdir folder1
ls
cd
```
