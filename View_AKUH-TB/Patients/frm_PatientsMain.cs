﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View_AKUH_TB.Patients;
using View_AKUH_TB.OthersForms;
using View_AKUH_TB.Deshboard;


namespace View_AKUH_TB.LoginForms
{
    public partial class frm_PatientsMain : Form
    {
        public frm_PatientsMain()
        {
            InitializeComponent();
        }


        
        private void frm_Patients_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        { 
            frm_NewPatient ofrm_NewPatient = new frm_NewPatient();
            ofrm_NewPatient.TopLevel = false;
            ofrm_NewPatient.AutoScroll = true;
            ofrm_NewPatient.Dock = DockStyle.Fill;      
            pnl_PatientMain.Controls.Add(ofrm_NewPatient);
            ofrm_NewPatient.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
       
        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {           
            frm_NewPatient ofrm_NewPatient = new frm_NewPatient();
            ofrm_NewPatient.TopLevel = false;
            ofrm_NewPatient.AutoScroll = true;
            ofrm_NewPatient.Dock = DockStyle.Fill;
            pnl_PatientMain.Controls.Add(ofrm_NewPatient);
            ofrm_NewPatient.Show();
        }

       frm_AdminMain o = new frm_AdminMain();
        private void btnExitApplication_Click_1(object sender, EventArgs e)
        {
           this.Hide();
            o.pnlfrm_AdminMain.Controls.Clear();
           // o.f();

            

        }
    }
}
