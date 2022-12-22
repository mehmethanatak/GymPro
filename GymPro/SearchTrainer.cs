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

namespace GymPro
{
    public partial class SearchTrainer : Form
    {
        public SearchTrainer()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            {
                if (txtSearch.Text != "")
                {

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source=LAPTOP-LTT8NJF2;  database = GYM; integrated security = True ";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "select * from NewTrainer where MID = " + txtSearch.Text + "";
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);

                    dataGridView1.DataSource = DS.Tables[0];

                }
                else
                {
                    MessageBox.Show("Please enter a ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchTrainer_Load(object sender, EventArgs e)
        {
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=LAPTOP-LTT8NJF2;  database = GYM; integrated security = True ";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewTrainer";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];


            }

        }
    }
}
