namespace FSL_Manager
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox sourcePath;
        private System.Windows.Forms.TextBox gamePath;
        private System.Windows.Forms.Label labelSourcePath;
        private System.Windows.Forms.Label labelGamePath;
        private System.Windows.Forms.Button browseSource;
        private System.Windows.Forms.Button browseGame;
        private System.Windows.Forms.Button InstallFSL;
        private System.Windows.Forms.Button UninstallFSL;
        private System.Windows.Forms.CheckBox chkBlockTelemetry;
        private System.Windows.Forms.CheckBox chkUseLocalSaves;
        private System.Windows.Forms.CheckBox chkEnableMoneyCheatCodes;
        private System.Windows.Forms.CheckBox chkUnlockGTAPlus;
        private System.Windows.Forms.CheckBox chkBypassBattlEye;
        private System.Windows.Forms.CheckBox chkUnlockCESP;
        private System.Windows.Forms.CheckBox chkEnableBackups;
        private System.Windows.Forms.Button btnClearSaves;
        private System.Windows.Forms.Button btnDeleteProfile;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.sourcePath = new System.Windows.Forms.TextBox();
            this.gamePath = new System.Windows.Forms.TextBox();
            this.labelSourcePath = new System.Windows.Forms.Label();
            this.labelGamePath = new System.Windows.Forms.Label();
            this.browseSource = new System.Windows.Forms.Button();
            this.browseGame = new System.Windows.Forms.Button();
            this.InstallFSL = new System.Windows.Forms.Button();
            this.UninstallFSL = new System.Windows.Forms.Button();
            this.chkBlockTelemetry = new System.Windows.Forms.CheckBox();
            this.chkUseLocalSaves = new System.Windows.Forms.CheckBox();
            this.chkEnableMoneyCheatCodes = new System.Windows.Forms.CheckBox();
            this.chkUnlockGTAPlus = new System.Windows.Forms.CheckBox();
            this.chkBypassBattlEye = new System.Windows.Forms.CheckBox();
            this.chkUnlockCESP = new System.Windows.Forms.CheckBox();
            this.chkEnableBackups = new System.Windows.Forms.CheckBox();
            this.btnClearSaves = new System.Windows.Forms.Button();
            this.btnDeleteProfile = new System.Windows.Forms.Button();
            this.LaunchGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sourcePath
            // 
            this.sourcePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourcePath.Location = new System.Drawing.Point(150, 30);
            this.sourcePath.Name = "sourcePath";
            this.sourcePath.ReadOnly = true;
            this.sourcePath.Size = new System.Drawing.Size(320, 22);
            this.sourcePath.TabIndex = 1;
            // 
            // gamePath
            // 
            this.gamePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamePath.Location = new System.Drawing.Point(150, 70);
            this.gamePath.Name = "gamePath";
            this.gamePath.ReadOnly = true;
            this.gamePath.Size = new System.Drawing.Size(320, 22);
            this.gamePath.TabIndex = 4;
            // 
            // labelSourcePath
            // 
            this.labelSourcePath.AutoSize = true;
            this.labelSourcePath.Location = new System.Drawing.Point(30, 33);
            this.labelSourcePath.Name = "labelSourcePath";
            this.labelSourcePath.Size = new System.Drawing.Size(80, 16);
            this.labelSourcePath.TabIndex = 0;
            this.labelSourcePath.Text = "Source DLL:";
            // 
            // labelGamePath
            // 
            this.labelGamePath.AutoSize = true;
            this.labelGamePath.Location = new System.Drawing.Point(30, 73);
            this.labelGamePath.Name = "labelGamePath";
            this.labelGamePath.Size = new System.Drawing.Size(89, 16);
            this.labelGamePath.TabIndex = 3;
            this.labelGamePath.Text = "Game Folder:";
            // 
            // browseSource
            // 
            this.browseSource.Location = new System.Drawing.Point(480, 25);
            this.browseSource.Name = "browseSource";
            this.browseSource.Size = new System.Drawing.Size(100, 30);
            this.browseSource.TabIndex = 2;
            this.browseSource.Text = "Browse";
            this.browseSource.Click += new System.EventHandler(this.browseSource_Click);
            // 
            // browseGame
            // 
            this.browseGame.Location = new System.Drawing.Point(480, 65);
            this.browseGame.Name = "browseGame";
            this.browseGame.Size = new System.Drawing.Size(100, 30);
            this.browseGame.TabIndex = 5;
            this.browseGame.Text = "Browse";
            this.browseGame.Click += new System.EventHandler(this.browseGame_Click);
            // 
            // InstallFSL
            // 
            this.InstallFSL.Location = new System.Drawing.Point(150, 120);
            this.InstallFSL.Name = "InstallFSL";
            this.InstallFSL.Size = new System.Drawing.Size(140, 40);
            this.InstallFSL.TabIndex = 6;
            this.InstallFSL.Text = "Install FSL";
            this.InstallFSL.Click += new System.EventHandler(this.InstallFSL_Click);
            // 
            // UninstallFSL
            // 
            this.UninstallFSL.Location = new System.Drawing.Point(330, 120);
            this.UninstallFSL.Name = "UninstallFSL";
            this.UninstallFSL.Size = new System.Drawing.Size(140, 40);
            this.UninstallFSL.TabIndex = 7;
            this.UninstallFSL.Text = "Uninstall FSL";
            this.UninstallFSL.Click += new System.EventHandler(this.UninstallFSL_Click);
            // 
            // chkBlockTelemetry
            // 
            this.chkBlockTelemetry.AutoSize = true;
            this.chkBlockTelemetry.Location = new System.Drawing.Point(40, 180);
            this.chkBlockTelemetry.Name = "chkBlockTelemetry";
            this.chkBlockTelemetry.Size = new System.Drawing.Size(127, 20);
            this.chkBlockTelemetry.TabIndex = 8;
            this.chkBlockTelemetry.Text = "Block Telemetry";
            // 
            // chkUseLocalSaves
            // 
            this.chkUseLocalSaves.AutoSize = true;
            this.chkUseLocalSaves.Location = new System.Drawing.Point(40, 210);
            this.chkUseLocalSaves.Name = "chkUseLocalSaves";
            this.chkUseLocalSaves.Size = new System.Drawing.Size(132, 20);
            this.chkUseLocalSaves.TabIndex = 9;
            this.chkUseLocalSaves.Text = "Use Local Saves";
            // 
            // chkEnableMoneyCheatCodes
            // 
            this.chkEnableMoneyCheatCodes.AutoSize = true;
            this.chkEnableMoneyCheatCodes.Location = new System.Drawing.Point(40, 240);
            this.chkEnableMoneyCheatCodes.Name = "chkEnableMoneyCheatCodes";
            this.chkEnableMoneyCheatCodes.Size = new System.Drawing.Size(197, 20);
            this.chkEnableMoneyCheatCodes.TabIndex = 10;
            this.chkEnableMoneyCheatCodes.Text = "Enable Money Cheat Codes";
            // 
            // chkUnlockGTAPlus
            // 
            this.chkUnlockGTAPlus.AutoSize = true;
            this.chkUnlockGTAPlus.Location = new System.Drawing.Point(40, 270);
            this.chkUnlockGTAPlus.Name = "chkUnlockGTAPlus";
            this.chkUnlockGTAPlus.Size = new System.Drawing.Size(131, 20);
            this.chkUnlockGTAPlus.TabIndex = 11;
            this.chkUnlockGTAPlus.Text = "Unlock GTA Plus";
            // 
            // chkBypassBattlEye
            // 
            this.chkBypassBattlEye.AutoSize = true;
            this.chkBypassBattlEye.Location = new System.Drawing.Point(40, 300);
            this.chkBypassBattlEye.Name = "chkBypassBattlEye";
            this.chkBypassBattlEye.Size = new System.Drawing.Size(128, 20);
            this.chkBypassBattlEye.TabIndex = 12;
            this.chkBypassBattlEye.Text = "Bypass BattlEye";
            // 
            // chkUnlockCESP
            // 
            this.chkUnlockCESP.AutoSize = true;
            this.chkUnlockCESP.Location = new System.Drawing.Point(40, 330);
            this.chkUnlockCESP.Name = "chkUnlockCESP";
            this.chkUnlockCESP.Size = new System.Drawing.Size(110, 20);
            this.chkUnlockCESP.TabIndex = 13;
            this.chkUnlockCESP.Text = "Unlock CESP";
            // 
            // chkEnableBackups
            // 
            this.chkEnableBackups.AutoSize = true;
            this.chkEnableBackups.Location = new System.Drawing.Point(40, 360);
            this.chkEnableBackups.Name = "chkEnableBackups";
            this.chkEnableBackups.Size = new System.Drawing.Size(128, 20);
            this.chkEnableBackups.TabIndex = 14;
            this.chkEnableBackups.Text = "Enable Backups";
            // 
            // btnClearSaves
            // 
            this.btnClearSaves.Location = new System.Drawing.Point(330, 295);
            this.btnClearSaves.Name = "btnClearSaves";
            this.btnClearSaves.Size = new System.Drawing.Size(200, 35);
            this.btnClearSaves.TabIndex = 16;
            this.btnClearSaves.Text = "Clear Local Save";
            this.btnClearSaves.Click += new System.EventHandler(this.btnClearSaves_Click);
            // 
            // btnDeleteProfile
            // 
            this.btnDeleteProfile.Location = new System.Drawing.Point(330, 345);
            this.btnDeleteProfile.Name = "btnDeleteProfile";
            this.btnDeleteProfile.Size = new System.Drawing.Size(200, 35);
            this.btnDeleteProfile.TabIndex = 17;
            this.btnDeleteProfile.Text = "Delete Local Profile";
            this.btnDeleteProfile.Click += new System.EventHandler(this.btnDeleteProfile_Click);
            // 
            // LaunchGame
            // 
            this.LaunchGame.Location = new System.Drawing.Point(330, 180);
            this.LaunchGame.Name = "LaunchGame";
            this.LaunchGame.Size = new System.Drawing.Size(200, 35);
            this.LaunchGame.TabIndex = 15;
            this.LaunchGame.Text = "Launch Game (Steam)";
            this.LaunchGame.Click += new System.EventHandler(this.LaunchGame_Click);
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.sourcePath);
            this.Controls.Add(this.gamePath);
            this.Controls.Add(this.labelSourcePath);
            this.Controls.Add(this.labelGamePath);
            this.Controls.Add(this.browseSource);
            this.Controls.Add(this.browseGame);
            this.Controls.Add(this.InstallFSL);
            this.Controls.Add(this.UninstallFSL);
            this.Controls.Add(this.chkBlockTelemetry);
            this.Controls.Add(this.chkUseLocalSaves);
            this.Controls.Add(this.chkEnableMoneyCheatCodes);
            this.Controls.Add(this.chkUnlockGTAPlus);
            this.Controls.Add(this.chkBypassBattlEye);
            this.Controls.Add(this.chkUnlockCESP);
            this.Controls.Add(this.chkEnableBackups);
            this.Controls.Add(this.LaunchGame);
            this.Controls.Add(this.btnClearSaves);
            this.Controls.Add(this.btnDeleteProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FSL Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.Button LaunchGame;
    }
}
