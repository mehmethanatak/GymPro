using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GymPro
{
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String EquipName = txtEqName.Text;
            String Description = txtDesc.Text;
            String MUsed = txtMuscle.Text;
            String DDate = dateTimePickerDel.Text;  
            Int64 cost = Int64.Parse(txtCost.Text);
            String MID = txtMID.Text;
            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=LAPTOP-LTT8NJF2;  database = GYM; integrated security = True ";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into Equipment(Equip_Name,E_Desc,Muscle_Used,Deliver_Date,Cost,MID) values ('" + EquipName + "' , '" + Description + "','" + MUsed + "','" + DDate + "','" + cost + "','"+MID+"')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Equipment informations are saved.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            txtEqName.Clear();
            txtDesc.Clear();
            txtMuscle.Clear();
            dateTimePickerDel.Value = DateTime.Now;
            txtCost.Clear();
            txtMID.Clear();

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewEqu ve = new ViewEqu();
            ve.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteEqu de = new DeleteEqu();
            de.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Equipment_Load(object sender, EventArgs e)
        {

        }
    }
}
