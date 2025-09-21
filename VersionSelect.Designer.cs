namespace FSL_Manager
{
    partial class VersionSelect
    {
        private System.ComponentModel.IContainer components = null;

        // ----------------------
        // Controls
        // ----------------------
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLegacy;
        private System.Windows.Forms.Button btnEnhanced;
        private System.Windows.Forms.CheckBox DisableBattlEye;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // ----------------------
            // Labels
            // ----------------------
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(157, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Choose a version to start:";

            // ----------------------
            // Version Buttons
            // ----------------------
            this.btnLegacy = new System.Windows.Forms.Button();
            this.btnLegacy.Location = new System.Drawing.Point(20, 60);
            this.btnLegacy.Name = "btnLegacy";
            this.btnLegacy.Size = new System.Drawing.Size(114, 38);
            this.btnLegacy.TabIndex = 1;
            this.btnLegacy.Text = "Legacy";

            this.btnEnhanced = new System.Windows.Forms.Button();
            this.btnEnhanced.Location = new System.Drawing.Point(140, 60);
            this.btnEnhanced.Name = "btnEnhanced";
            this.btnEnhanced.Size = new System.Drawing.Size(114, 38);
            this.btnEnhanced.TabIndex = 2;
            this.btnEnhanced.Text = "Enhanced";

            // ----------------------
            // Disable BattlEye Checkbox
            // ----------------------
            this.DisableBattlEye = new System.Windows.Forms.CheckBox();
            this.DisableBattlEye.AutoSize = true;
            this.DisableBattlEye.Checked = true;
            this.DisableBattlEye.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisableBattlEye.Location = new System.Drawing.Point(20, 120);
            this.DisableBattlEye.Name = "DisableBattlEye";
            this.DisableBattlEye.Size = new System.Drawing.Size(129, 20);
            this.DisableBattlEye.TabIndex = 3;
            this.DisableBattlEye.Text = "Disable BattlEye";
            this.DisableBattlEye.UseVisualStyleBackColor = true;

            // ----------------------
            // Form Settings
            // ----------------------
            this.ClientSize = new System.Drawing.Size(280, 180);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLegacy);
            this.Controls.Add(this.btnEnhanced);
            this.Controls.Add(this.DisableBattlEye);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VersionSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GTA V Launcher";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
