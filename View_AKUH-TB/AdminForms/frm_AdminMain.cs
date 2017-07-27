using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View_AKUH_TB;
using View_AKUH_TB.LoginForms;
using View_AKUH_TB.OthersForms;
using View_AKUH_TB.Patients;
using View_AKUH_TB.Settings;

namespace View_AKUH_TB.Deshboard
{
    public partial class frm_AdminMain : Form
    { 

        public frm_AdminMain()
        {

            InitializeComponent();
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);
            pictureBox.Region = new Region(path);
           
           
            this.bunifuCustomLabel4.Hide();
            this.bunifuCustomLabel6.Hide();

        }

        private void frm_AdminDeshboard_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            this.MinimumSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            this.WindowState = FormWindowState.Maximized;
            MinimumSize = MaximumSize = this.Size;
            this.SetDesktopBounds(0, 0, Width, Height);
            this.CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Normal)
            //{
            //    WindowState = FormWindowState.Minimized;

            //} else if (WindowState == FormWindowState.Maximized)
            //{
            //    WindowState = FormWindowState.Minimized;
            //}
 
        }      
 
        private void button2_Click(object sender, EventArgs e)
        {       

        //        if (this.WindowState == FormWindowState.Normal)
        //        {
        //            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
        //            this.MinimumSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
        //            this.WindowState = FormWindowState.Maximized;
        //            MinimumSize = MaximumSize = this.Size;
        //            this.SetDesktopBounds(0, 0, Width , Height);
        //            this.CenterToParent();
                   
        //        }

        //        //maximises window
        //        else if(this.WindowState == FormWindowState.Maximized)
        //        {       
        //            this.MaximumSize = new System.Drawing.Size(1200, 750);
        //            this.MinimumSize = new System.Drawing.Size(1200, 750);
        //            this.WindowState = FormWindowState.Normal;               
        //            MinimumSize = MaximumSize = this.Size;
        //            this.SetDesktopBounds(50, 50, 1200, 800);
        //            this.CenterToParent();


        //        }          

            }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnimgMenu_Click(object sender, EventArgs e)
        {
           
            if(pnlsidebar.Width == 258)
            {
                //int a = this.pnlsidebar.Width;
                //MessageBox.Show("aa" + a);
                pnlsidebar.Width = 85;
                //int b = this.pnlsidebar.Width;
                //MessageBox.Show("aa" + b);
                //this.lblUSerType.Hide();
                //this.lblUserName.Hide();
                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);
                pictureBox.Region = new Region(path);
                this.pictureBox.SetBounds(5, 15, pictureBox.Width, pictureBox.Height);
             //   this.bunifuCustomLabel1.Location = new Point(10, 140);
            }
            else
            {
                pnlsidebar.Width = 258;
                this.lblUSerType.Show();
                this.lblUserName.Show();
                System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
                path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);
                pictureBox.Region = new Region(path);
                this.pictureBox.SetBounds(93, 15, pictureBox.Width, pictureBox.Height);
             //   this.bunifuCustomLabel1.Location = new Point(10, 140);
            }
        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {

            //if (this.WindowState == FormWindowState.Normal)
            //{
            //    this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            //    this.MinimumSize = new System.Drawing.Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            //    this.WindowState = FormWindowState.Maximized;
            //    MinimumSize = MaximumSize = this.Size;
            //    this.SetDesktopBounds(0, 0, Width, Height);
            //    this.CenterToParent();

            //}

            ////maximises window
            //else if (this.WindowState == FormWindowState.Maximized)
            //{
            //    this.MaximumSize = new System.Drawing.Size(1200, 750);
            //    this.MinimumSize = new System.Drawing.Size(1200, 750);
            //    this.WindowState = FormWindowState.Normal;
            //    MinimumSize = MaximumSize = this.Size;
            //    this.SetDesktopBounds(50, 50, 1200, 800);
            //    this.CenterToParent();


            //}
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;

            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.bunifuCustomLabel4.Show();
            this.bunifuCustomLabel6.Show();
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            pnlfrm_AdminMain.Controls.Clear();
            pnlfrm_AdminMain.Update();

            frm_AdminDashboard ofrm_AdminDashboard = new frm_AdminDashboard();
            ofrm_AdminDashboard.MdiParent = this;
            ofrm_AdminDashboard.Dock = DockStyle.Fill;
            pnlfrm_AdminMain.Controls.Add(ofrm_AdminDashboard);
            ofrm_AdminDashboard.Show();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            pnlfrm_AdminMain.Controls.Clear();
            pnlfrm_AdminMain.Update();

            frm_PatientsMain ofrm_PatientsMain = new frm_PatientsMain();
            ofrm_PatientsMain.MdiParent = this;
            ofrm_PatientsMain.Dock = DockStyle.Fill;
            pnlfrm_AdminMain.Controls.Add(ofrm_PatientsMain);
            ofrm_PatientsMain.Show();
        }

        private void bubtnSettings_Click(object sender, EventArgs e)
        {
            pnlfrm_AdminMain.Controls.Clear();
            pnlfrm_AdminMain.Update();

            frm_SettingMain ofrm_SettingMain = new frm_SettingMain();
            ofrm_SettingMain.MdiParent = this;
            ofrm_SettingMain.Dock = DockStyle.Fill;
            pnlfrm_AdminMain.Controls.Add(ofrm_SettingMain);
            ofrm_SettingMain.Show();

        }
    }
    }

