using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View_AKUH_TB.Deshboard;

namespace View_AKUH_TB.Login
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            
            InitializeComponent();
           

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           Environment.Exit(0);
          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //frm_Login o = new frm_Login();
          
      
           // MessageBox.Show("You are logged in Successfully ;) ", "Login Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frm_AdminMain o = new frm_AdminMain();
            o.Show();
            //Form1 a = new Form1();
            //a.ShowDialog();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            //this.SetBevel(false);
            //FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //Left = Top - 0;
            //Width = Screen.PrimaryScreen.WorkingArea.Width;
            //Height = Screen.PrimaryScreen.WorkingArea.Height;
        }
    }
}
