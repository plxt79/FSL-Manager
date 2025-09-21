using System;
using System.IO;
using System.Windows.Forms;

namespace FSL_Manager
{
    public partial class Main : Form
    {
        private readonly string iniPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "FSL",
            "settings.ini"
        );

        private readonly string configDir = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "FSL Manager"
        );

        private string config;
        private string sourceDLL = string.Empty;
        private string gameFolder = string.Empty;

        public Main()
        {
            InitializeComponent();
            this.Load += Main_Load;

            config = Path.Combine(configDir, "config.ini");
            LoadConfig();
            LoadSettings();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            sourcePath.TabStop = false;
            gamePath.TabStop = false;
            this.ActiveControl = null;
        }

        #region DLL/Game Config

        private void LoadConfig()
        {
            if (!File.Exists(config)) return;

            foreach (string line in File.ReadAllLines(config))
            {
                string l = line.Trim();
                int i = l.IndexOf("=");
                if (i < 0) continue;

                string key = l.Substring(0, i).Trim();
                string value = l.Substring(i + 1).Trim().Trim('"');

                switch (key)
                {
                    case "sourceDLL": sourceDLL = value; break;
                    case "gameFolder": gameFolder = value; break;
                }
            }

            sourcePath.Text = sourceDLL;
            gamePath.Text = gameFolder;
        }

        private void SaveConfig()
        {
            try
            {
                if (!Directory.Exists(configDir))
                    Directory.CreateDirectory(configDir);

                File.WriteAllLines(config, new string[]
                {
                    $"sourceDLL = \"{sourceDLL}\"",
                    $"gameFolder = \"{gameFolder}\""
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save config: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Browse

        private void browseSource_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "WINMM.dll|WINMM.dll";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    sourceDLL = ofd.FileName;
                    sourcePath.Text = sourceDLL;
                    SaveConfig();
                }
            }
        }

        private void browseGame_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    gameFolder = fbd.SelectedPath;
                    gamePath.Text = gameFolder;
                    SaveConfig();
                }
            }
        }

        #endregion

        #region Install/Uninstall

        private void InstallFSL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sourceDLL) || string.IsNullOrEmpty(gameFolder))
            {
                MessageBox.Show("Select source DLL and game folder first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string target = Path.Combine(gameFolder, "WINMM.dll");
                File.Copy(sourceDLL, target, true);
                MessageBox.Show("FSL Installed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to install FSL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UninstallFSL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gameFolder))
            {
                MessageBox.Show("Please select the game folder first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string target = Path.Combine(gameFolder, "WINMM.dll");
                if (File.Exists(target))
                {
                    File.Delete(target);
                    MessageBox.Show("FSL Uninstalled Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("FSL not installed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to uninstall FSL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Settings INI

        private void LoadSettings()
        {
            chkBlockTelemetry.Checked = true;
            chkEnableBackups.Checked = true;
            chkUseLocalSaves.Checked = true;
            chkEnableMoneyCheatCodes.Checked = true;
            chkUnlockGTAPlus.Checked = true;
            chkBypassBattlEye.Checked = true;
            chkUnlockCESP.Checked = true;

            if (!File.Exists(iniPath)) return;

            string section = "";
            foreach (string line in File.ReadAllLines(iniPath))
            {
                string l = line.Trim();
                if (l.StartsWith("[") && l.EndsWith("]"))
                {
                    section = l.Substring(1, l.Length - 2);
                    continue;
                }

                if (string.IsNullOrWhiteSpace(l) || !l.Contains("=")) continue;

                string[] parts = l.Split(new[] { '=' }, 2);
                string key = parts[0].Trim();
                string val = parts[1].Trim().ToLower();

                if (section == "Global" && key == "BlockTelemetry") chkBlockTelemetry.Checked = val == "true";
                else if (section == "GTA")
                {
                    switch (key)
                    {
                        case "UseLocalSaves": chkUseLocalSaves.Checked = val == "true"; break;
                        case "EnableMoneyCheatCodes": chkEnableMoneyCheatCodes.Checked = val == "true"; break;
                        case "UnlockGTAPlus": chkUnlockGTAPlus.Checked = val == "true"; break;
                        case "BypassBattlEye": chkBypassBattlEye.Checked = val == "true"; break;
                        case "UnlockCESP": chkUnlockCESP.Checked = val == "true"; break;
                        case "EnableBackups": chkEnableBackups.Checked = val == "true"; break;
                    }
                }
            }
        }

        private void SaveSettings()
        {
            try
            {
                string dir = Path.GetDirectoryName(iniPath);
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

                using (StreamWriter sw = new StreamWriter(iniPath))
                {
                    sw.WriteLine("[Global]");
                    sw.WriteLine($"BlockTelemetry = {chkBlockTelemetry.Checked.ToString().ToLower()}");
                    sw.WriteLine();
                    sw.WriteLine("[GTA]");
                    sw.WriteLine($"UseLocalSaves = {chkUseLocalSaves.Checked.ToString().ToLower()}");
                    sw.WriteLine($"EnableMoneyCheatCodes = {chkEnableMoneyCheatCodes.Checked.ToString().ToLower()}");
                    sw.WriteLine($"UnlockGTAPlus = {chkUnlockGTAPlus.Checked.ToString().ToLower()}");
                    sw.WriteLine($"BypassBattlEye = {chkBypassBattlEye.Checked.ToString().ToLower()}");
                    sw.WriteLine($"UnlockCESP = {chkUnlockCESP.Checked.ToString().ToLower()}");
                    sw.WriteLine($"EnableBackups = {chkEnableBackups.Checked.ToString().ToLower()}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save settings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SaveSettings();
            base.OnFormClosing(e);
        }

        #endregion

        #region Extra Buttons

        private void btnClearSaves_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Are you sure you want to delete all local saves? This cannot be undone (settings.ini will be preserved).",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning
            );
            if (confirm != DialogResult.Yes) return;

            string fslDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FSL");
            if (!Directory.Exists(fslDir))
            {
                MessageBox.Show("No local saves found to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                foreach (var file in Directory.GetFiles(fslDir))
                {
                    if (Path.GetFileName(file).Equals("settings.ini", StringComparison.OrdinalIgnoreCase)) continue;
                    File.Delete(file);
                }

                foreach (var dir in Directory.GetDirectories(fslDir))
                    Directory.Delete(dir, true);

                MessageBox.Show("Local saves cleared.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to clear saves: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteProfile_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Are you sure you want to delete all local profiles? This will remove Documents/Rockstar Games/GTAV Enhanced/Profiles.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning
            );
            if (confirm != DialogResult.Yes) return;

            string profileDir = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "Rockstar Games",
                "GTAV Enhanced",
                "Profiles"
            );

            if (!Directory.Exists(profileDir))
            {
                MessageBox.Show("No local profiles found to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                Directory.Delete(profileDir, true);
                MessageBox.Show("Local profiles deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to delete profiles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void LaunchGame_Click(object sender, EventArgs e)
        {
            using (var versionDialog = new VersionSelect())
            {
                versionDialog.ShowDialog(this);
            }
        }
    }
}
