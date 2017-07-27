using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View_AKUH_TB.ComboBoxForms;

namespace View_AKUH_TB.Settings
{
    public partial class frm_SettingMain : Form
    {
        public frm_SettingMain()
        {
            InitializeComponent();
            this.pnl_ManageFeildsSettings.Width = 0;
            this.pnl_ManageUsersSettings.Width = 0;

            
        }

        private void frm_SettingMain_Load(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        { 
            if (pnl_ManageFeildsSettings.Width == 0)
            {               
                pnl_ManageFeildsSettings.Width = 260;           
            }
            else 
            {              
                pnl_ManageFeildsSettings.Width = 0;              
            }        
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frm_ComboBox_AFBS o = new frm_ComboBox_AFBS();
            o.ShowDialog();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (pnl_ManageUsersSettings.Width == 0)
            {
                pnl_ManageUsersSettings.Width = 420;
            }
            else
            {
                pnl_ManageUsersSettings.Width = 0;
            }
        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
