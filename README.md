# Bmp2Ico
## Setup
1) Clone the repo
2) Build
3) Create a registry key under `Computer\HKEY_CLASSES_ROOT\SystemFileAssociations\` for `.bmp` and `.png` entries as follows:
> Shell
>> Bmp2Ico
>>> command
4) Set the value of the `(Default)` string for `command` to the full file path of the `.exe` file produced in the build step, plus a placeholder for the file path as a command line parameter, e.g.
  `"D:\repos\Bmp2Ico\Bmp2Ico\bin\Release\Bmp2Ico.exe" "%1"`
5) Set the value of the `(Default)` string for `Bmp2Ico` to 'Convert to Icon (Bmp2Ico)' (Note that this is optional, but will look better in the Window Explorer context menu)
6) If desired you could copy the `.exe` into a central program files folder, but this isn't a required step.

## How to use
1) Right click on a `.png` or `.bmp` image file in Windows Explorer.
2) If on Windows 11 you may need to click 'Show more options'
3) Click 'Convert to Icon (Bmp2Ico)' (assuming that's what you set it to during the setup above)

## Troubleshooting
### Your icon is blank
> Your source file may be too large
> For anything else feel free to raise an issue. I may, or may not, look at it. I have other things to do, and this is a personal project...
