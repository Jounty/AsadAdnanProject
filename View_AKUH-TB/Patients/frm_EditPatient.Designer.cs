namespace View_AKUH_TB.Patients
{
    partial class frm_EditPatient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EditPatient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExitApplication = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblProjectName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnExitApplication);
            this.panel1.Controls.Add(this.lblProjectName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 82);
            this.panel1.TabIndex = 2;
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.Activecolor = System.Drawing.Color.LightGray;
            this.btnExitApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitApplication.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExitApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExitApplication.BorderRadius = 0;
            this.btnExitApplication.ButtonText = " ";
            this.btnExitApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitApplication.DisabledColor = System.Drawing.Color.Gray;
            this.btnExitApplication.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExitApplication.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExitApplication.Iconimage")));
            this.btnExitApplication.Iconimage_right = null;
            this.btnExitApplication.Iconimage_right_Selected = null;
            this.btnExitApplication.Iconimage_Selected = null;
            this.btnExitApplication.IconMarginLeft = 5;
            this.btnExitApplication.IconMarginRight = 0;
            this.btnExitApplication.IconRightVisible = true;
            this.btnExitApplication.IconRightZoom = 0D;
            this.btnExitApplication.IconVisible = true;
            this.btnExitApplication.IconZoom = 65D;
            this.btnExitApplication.IsTab = false;
            this.btnExitApplication.Location = new System.Drawing.Point(979, 17);
            this.btnExitApplication.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnExitApplication.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btnExitApplication.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(89)))), ((int)(((byte)(181)))));
            this.btnExitApplication.selected = false;
            this.btnExitApplication.Size = new System.Drawing.Size(52, 43);
            this.btnExitApplication.TabIndex = 11;
            this.btnExitApplication.Text = " ";
            this.btnExitApplication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitApplication.Textcolor = System.Drawing.Color.White;
            this.btnExitApplication.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.ForeColor = System.Drawing.Color.DarkGray;
            this.lblProjectName.Location = new System.Drawing.Point(16, 26);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(163, 34);
            this.lblProjectName.TabIndex = 4;
            this.lblProjectName.Text = "Edit Patient";
            // 
            // frm_EditPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1056, 1002);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_EditPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_EditPatient";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnExitApplication;
        private Bunifu.Framework.UI.BunifuCustomLabel lblProjectName;
    }
}