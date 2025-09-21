using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace FSL_Manager
{
    public partial class VersionSelect : Form
    {
        private const string APPID_LEGACY = "271590";
        private const string APPID_ENHANCED = "3240220";

        public VersionSelect()
        {
            InitializeComponent();
            btnLegacy.Click += (s, e) => LaunchGame(APPID_LEGACY);
            btnEnhanced.Click += (s, e) => LaunchGame(APPID_ENHANCED);
        }

        private void LaunchGame(string appId)
        {
            try
            {
                if (DisableBattlEye.Checked)
                {
                    string steamPath = GetSteamPath();
                    if (string.IsNullOrEmpty(steamPath) || !File.Exists(steamPath))
                    {
                        MessageBox.Show("Steam not found.", "Launch Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string args = "-applaunch " + appId + " -nobattleye";
                    Process.Start(steamPath, args);
                }
                else
                {
                    Process.Start("steam://launch/" + appId);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error launching Steam: " + ex.Message, "Launch Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetSteamPath()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Valve\Steam"))
                {
                    if (key != null)
                    {
                        object path = key.GetValue("SteamPath");
                        if (path != null)
                            return Path.Combine(path.ToString(), "Steam.exe");
                    }
                }
            }
            catch { }

            return null;
        }
    }
}
