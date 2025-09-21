# FSL-Manager

> Modern Windows utility for managing FSL (`WINMM.dll`) in GTA V Enhanced, handling local saves/profiles, and launching the game via Steam.

---

## Table of Contents

- [Overview](#overview)  
- [Quick Start](#quick-start)  
- [UI Walkthrough](#ui-walkthrough)  
- [Settings & Config](#settings--config)  
- [Extras](#extras)  
- [Launching the Game](#launching-the-game)  
- [Troubleshooting](#troubleshooting)  
- [Contributing](#contributing)  

---

## Overview

FSL-Manager lets you:

- Install/uninstall `WINMM.dll` (FSL) into GTA V Enhanced.  
- Save last-used Source DLL and Game Folder paths.  
- Read/write FSL settings from `%AppData%/FSL/settings.ini`.  
- Clear local saves or delete local GTA profiles.  
- Launch GTA V via Steam with optional **Disable BattlEye**.  

---

## Quick Start

1. Download the `WINMM.dll` (FSL) from the [official source](https://www.unknowncheats.me/forum/grand-theft-auto-v/616977-fsl-local-gtao-saves.html).  
2. Launch **FSL Manager.exe**.  
3. Click **Browse** next to *Source DLL* and select the `WINMM.dll`.  
4. Click **Browse** next to *Game Folder* and select your GTA V Enhanced folder.  
5. Click **Install FSL** to copy the DLL, or **Uninstall FSL** to remove it.  

---

## UI Walkthrough

- **Source DLL** — Path to the DLL.  
- **Game Folder** — GTA V Enhanced installation folder.  
- **Install FSL / Uninstall FSL** — Manage the DLL in the game folder.  
- **Settings checkboxes** — Saved to `%AppData%/FSL/settings.ini`.  
- **Clear Local Save / Delete Local Profile** — Deletes saves or profiles after confirmation.  
- **Launch Game** — Opens a dialog to select *Legacy* or *Enhanced* Steam version, with optional **Disable BattlEye**.  

---

## Settings & Config

### Locations

- Manager config: `%AppData%/FSL Manager/config.ini`  
- FSL settings: `%AppData%/FSL/settings.ini`  

### config.ini

```
sourceDLL = "C:\path\to\WINMM.dll"
gameFolder = "C:\path\to\GTA V Enhanced"
```

### settings.ini

```
[Global]
BlockTelemetry=true

[GTA]
UseLocalSaves=true
EnableMoneyCheatCodes=true
UnlockGTAPlus=true
BypassBattlEye=true
UnlockCESP=true
EnableBackups=true
```

Defaults: all values are `true` if file doesn’t exist.

---

## Extras

- **Clear Local Save** — Deletes all files in `%AppData%/FSL/` except `settings.ini`.  
- **Delete Local Profile** — Deletes `Documents/Rockstar Games/GTAV Enhanced/Profiles`.  

Both actions require confirmation.

---

## Launching the Game

- Opens **VersionSelect dialog** for Legacy/Enhanced.  
- **Disable BattlEye** launches via Steam executable with `-nobattleye`.  
- Otherwise, uses `steam://launch/APPID`.

---

## Troubleshooting

- Missing DLL or game folder — Set both paths first.  
- Permission denied — Run as Administrator.  
- FSL not installed — Check folder or DLL.  
- Settings not saving — Ensure `%AppData%/FSL/settings.ini` is writable.  
- No saves/profiles to delete — App will notify.  
- Steam not launching — Ensure Steam is installed and running.  

---

## Contributing

1. Fork the repo.  
2. Create a feature branch.  
3. Open a PR with a clear description.  

Ideas:

- Add logging instead of MessageBoxes.  
- Preview files before deletion.  
- Backup settings before wipes.  
- Improve remembering last-used folders.
