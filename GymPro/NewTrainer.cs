﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymPro
{
    public partial class NewTrainer : Form
    {
        private readonly SqlCommand cmd = Singleton.cmd;

        public NewTrainer()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            String fname = txtFirstName.Text;
            String lname = txtLastName.Text;
            String gender = "";
            bool isChacked = radioButton1.Checked;
            if (isChacked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }

            String dob = dateTimePickerDOB.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String email = txtEmail.Text;
            String register = dateTimePickerRegisterDate.Text;
            String address = txtAddress.Text;

            cmd.CommandText = "insert into NewTrainer(First_Name,Last_Name,Gender,Birthday,Phone_Number,Email,R_Date,M_Address) values (' " + fname + " ' , ' " + lname + " ',' " + gender + " ' ,' " + dob + " ' ,' " + mobile + " ' ,' " + email + " ' ,' " + register + " ' ,' " + address + " ')";
            Singleton.Command(cmd);
            MessageBox.Show("Registration confirmed.");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtMobile.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            dateTimePickerDOB.Value = DateTime.Now;
            dateTimePickerRegisterDate.Value = DateTime.Now;

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewTrainer_Load(object sender, EventArgs e)
        {

        }
    }
}
