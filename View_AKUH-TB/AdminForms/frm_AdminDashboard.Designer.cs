namespace View_AKUH_TB.OthersForms
{
    partial class frm_AdminDashboard
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
            this.pnl_HeaderAdminDashboard = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnExitApplication = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnl_HeaderAdminDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_HeaderAdminDashboard
            // 
            this.pnl_HeaderAdminDashboard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_HeaderAdminDashboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_HeaderAdminDashboard.Controls.Add(this.btnExitApplication);
            this.pnl_HeaderAdminDashboard.Controls.Add(this.bunifuCustomLabel1);
            this.pnl_HeaderAdminDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_HeaderAdminDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnl_HeaderAdminDashboard.Name = "pnl_HeaderAdminDashboard";
            this.pnl_HeaderAdminDashboard.Size = new System.Drawing.Size(1056, 82);
            this.pnl_HeaderAdminDashboard.TabIndex = 0;
            this.pnl_HeaderAdminDashboard.TabStop = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.LightGray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(32, 21);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(179, 45);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Dashboard\r\n";
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
            this.btnExitApplication.Iconimage = global::View_AKUH_TB.Properties.Resources.Delete_30px;
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
            this.btnExitApplication.Location = new System.Drawing.Point(990, 21);
            this.btnExitApplication.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnExitApplication.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btnExitApplication.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(89)))), ((int)(((byte)(181)))));
            this.btnExitApplication.selected = false;
            this.btnExitApplication.Size = new System.Drawing.Size(52, 43);
            this.btnExitApplication.TabIndex = 13;
            this.btnExitApplication.Text = " ";
            this.btnExitApplication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitApplication.Textcolor = System.Drawing.Color.White;
            this.btnExitApplication.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frm_AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 1002);
            this.Controls.Add(this.pnl_HeaderAdminDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_HeaderAdminDashboard.ResumeLayout(false);
            this.pnl_HeaderAdminDashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_HeaderAdminDashboard;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnExitApplication;
    }
}