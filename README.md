# FSL-Manager

> Simple Windows manager for installing/uninstalling the `WINMM.dll` (FSL) into GTA V Enhanced, plus a few handy local-save/profile tools.

---

## Table of contents

* [What it does](#what-it-does)
* [Quick start](#quick-start)
* [Usage (UI walkthrough)](#usage-ui-walkthrough)
* [Settings & config files](#settings--config-files)
* [Extras](#extras)
* [Troubleshooting](#troubleshooting)
* [Contributing](#contributing)

---

# What it does

* Copies `WINMM.dll` (the FSL DLL) into your GTA V Enhanced folder to "install" FSL.
* Removes `WINMM.dll` from the game folder to uninstall.
* Saves last-used source DLL and game folder paths to `%AppData%/FSL Manager/config.ini`.
* Reads/writes FSL settings from `%AppData%/FSL/settings.ini`.
* Extra tools to clear local saves or remove local GTA profiles.

---

# Quick start

1. Download the `WINMM.dll` (FSL) from the [official source](https://www.unknowncheats.me/forum/grand-theft-auto-v/616977-fsl-local-gtao-saves.html).
2. Launch **FSL Manager.exe**.
3. Click **Browse** next to *Source DLL* and pick the `WINMM.dll`.
4. Click **Browse** next to *Game Folder* and select your GTA V Enhanced installation folder.
5. Click **Install FSL** to copy `WINMM.dll` into the game folder.
   Click **Uninstall FSL** to remove it.

---

# Usage (UI walkthrough)

* **Source DLL** — Path to the `WINMM.dll` you want to install. Saved in `%AppData%/FSL Manager/config.ini`.
* **Game Folder** — Root folder of the GTA V Enhanced installation. Saved in the same config.
* **Install FSL** — Copies the DLL into `{GameFolder}\WINMM.dll`.
* **Uninstall FSL** — Deletes `{GameFolder}\WINMM.dll` if it exists.
* **Settings checkboxes** — Options linked to `%AppData%/FSL/settings.ini`.
* **Save on exit** — Settings auto-saved when the manager closes.

---

# Settings & config files

### Locations

* Manager config: `%AppData%/FSL Manager/config.ini`
* FSL settings/saves: `%AppData%/FSL/settings.ini`

### `config.ini` format

```ini
sourceDLL = "C:\path\to\WINMM.dll"
gameFolder = "C:\path\to\GTA V Enhanced"
```

### `settings.ini` format

```ini
[Global]
BlockTelemetry = true

[GTA]
UseLocalSaves = true
EnableMoneyCheatCodes = true
UnlockGTAPlus = true
BypassBattlEye = true
UnlockCESP = true
EnableBackups = true
```

Defaults: all `true` if the file doesn’t exist.

---

# Extras

* **Clear Local Save** — Deletes all files in `%AppData%/FSL/` *except* `settings.ini`.
* **Delete Local Profile** — Removes `Documents/Rockstar Games/GTAV Enhanced/Profiles`.

Both actions prompt for confirmation before deleting.

---

# Troubleshooting

* **Missing DLL/game folder warning** — Set both paths before installing.
* **Permission denied** — Run as Admin or check folder access.
* **FSL not installed** — Wrong folder chosen, or DLL missing.
* **Settings not saving** — Ensure `%AppData%/FSL/settings.ini` is writable.
* **No saves/profiles to delete** — App tells you if folders don’t exist.

---

# Contributing

1. Fork the repo.
2. Create a feature branch.
3. Open a PR with a clear description.

Ideas:

* Add logging instead of only MessageBoxes.
* Preview files before delete.
* Backup settings before wipes.
* Improve remembering last-used folders.
