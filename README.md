<div align="center">

# Function Key Remapper (X1 Extreme Gen 5)

![badge](https://badgen.net/badge/version/v1.0.0/orange?style=flat-square)
![badge](https://badgen.net/badge/platform/Windows%20(x64)/green?style=flat-square)
![badge](https://badgen.net/badge/.net/6/yellow?style=flat-square)

<p align = "center">
  <img width="527" alt="X1EG5 Keyboard" src="https://github.com/ZX-80/Fn-Remapper/assets/44975876/22a1f75f-839c-4413-a9a7-e31ccb4db984">
</p>

A simple GUI to allow remapping Function keys on the Lenovo Thinkpad X1 Extreme Gen 5

[Description](#description) •
[How to Use](#how-to-use) •
[Compatibility](#compatibility)

</div>

# Description

The X1E comes with some pretty useless special keys:

- F7 = Project options (Windows + P already exists)
- F8 = Airplane mode (Fine, but very rarely used)
- F9 = Open notifications (equivelent to clicking the bottom right of the screen)
- F10 = Answer Microsoft Teams call (Speaks for itself)
- F11 = Reject Microsoft Teams call

Sadly none of them can be officially remapped except the F12 key. I had been unable to find any way of fixing this, and had thus given up. But recently I watched a video by John Hammond titled ["The Mysterious Office Hotkey.."](https://www.youtube.com/watch?v=fLrA5eBmMwM) which showed how to capture and manipulate shortcuts using Sysinternals process monitor and the registry. I thought I'd give this a shot, and suprisingly it worked. I was able to discover the following:

1. The function keys F4-F12 first check for a key in `Computer\HKEY_LOCAL_MACHINE\SOFTWARE\Lenovo\ShortcutKey\AppLaunch`
   - Ex_13 = FN-Tab (magnify.exe)
   - Ex_90 = F12 (User Defined Key)
   - Ex_98 = F11 (Reject Microsoft Teams call)
   - Ex_97 = F10 (Answer Microsoft Teams call)
   - Ex_96 = F9 (Open notifications)
   - 5 = F8 (Airplane Mode)
   - 7 = F7 (Windows + P)
   - Ex_0F = F6 (Brightness+)
   - Ex_10 = F5 (Brightness-)
   - Ex_1A = F4 (Microphone Mute)
   - Ex_17 = ThinkVantage button (Not present on the X1E)
3. If present, and the subkey `Apptype` is 1, run the program in the subkey `Desktop/File` with parameters `Desktop/Parameters`
4. If present, and the subkey `Apptype` is 2, run the program as administrator in the subkey `UIAccess/File` with parameters `UIAccess/Parameters`
5. If present, and the subkey `Apptype` is 3, run the metro app in the subkey `Metro/URI`
6. Otherwise performs some default action

As you can see, only F4-12 & Tab can be modified this way, but I had no intention of changing the volume keys, so I don't consider it an issue. I'd recommend [Nircmd](https://www.nirsoft.net/utils/nircmd.html) to anyone using this tool, as it has a lot of useful features desined for key mapping. I've mapped the media keys to F9 (Previous), F10 (Next), and F12 (Play/Pause), for example.

# How to Use

<p align = "center">
  <img width="547" alt="Application Screenshot" src="https://github.com/ZX-80/Fn-Remapper/assets/44975876/2950fe12-1a16-4152-9816-9343ce0199f1">
</p>

**First Run**
- Export `Computer\HKEY_LOCAL_MACHINE\SOFTWARE\Lenovo\ShortcutKey\AppLaunch` in regedit and save it as a backup
- If you see any popups when clicking certain function keys, you may need to disable Lenovos "On screen display drawer" (tposd.exe) in the Group policy editor

**Modifying a Function Key**
1. Select the button you wish to modify from the top row
2. Edit `File` to the full path of the program you wish to run
3. Edit `Parameters` to be the parameters passed to that program
4. Click Apply to save your changes

**Resetting a Function Key**
1. Select the button you wish to reset from the top row
2. Click Default to reset the key to its default function

# Compatibility

> [!WARNING] 
> This program has only been tested on the following. It is provided as-is, without any warranty. Use at your own peril.

- Laptop: Lenovo Thinkpad X1 Extreme Gen 5
- Lenovo Commercial Vantage: 10.2305.30.0
