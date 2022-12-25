using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MongoDB.Driver.Core.Configuration;

namespace GymPro
{
    public partial class NewMember : Form
    {
        public NewMember()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            String fname = txtFirstName.Text;
            String lname = txtLastName.Text;
            String gender = "";
            Int64 height = Int64.Parse(txtHeight.Text);
            Int64 weight = Int64.Parse(txtWeight.Text);
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
            String membership = comboBoxMembership.Text;

            var cmd = Singleton.cmd;
            cmd.CommandText = "insert into NewMember(First_Name,Last_Name,Gender,Height_cm,Weight_kg,Birthday,Phone_Number,Email,R_Date,M_Address,M_Time) values ('" + fname + "' , '" + lname + "','" + gender + "','"+height+"','"+weight+"', '" + dob+ "' ,'"+mobile+"',' " +email+ " ',' " + register+ " ',' " + address+ " ',' " + membership+ "')";
            Singleton.Command(cmd);
            MessageBox.Show("Registration confirmed.");

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtHeight.Clear();
            txtWeight.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            comboBoxMembership.ResetText();
            txtAddress.Clear();
            dateTimePickerDOB.Value= DateTime.Now;
            dateTimePickerRegisterDate.Value= DateTime.Now;

        }

        private void NewMember_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWeight_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePickerRegisterDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
