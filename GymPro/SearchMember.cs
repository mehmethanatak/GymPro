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
    public partial class SearchMember : Form
    {
        private readonly SqlCommand cmd = Singleton.cmd;

        public SearchMember()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)

        {
            if (txtSearch.Text != "")
            {
                cmd.CommandText = "select * from NewMember where MID = " + txtSearch.Text + "";
                Singleton.Command(cmd);
                dataGridView1.DataSource = Singleton.DS.Tables[0];
            }
            else
            {
                MessageBox.Show("Please enter a ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SearchMember_Load(object sender, EventArgs e)
        {
            cmd.CommandText = "select * from NewMember";
            Singleton.Command(cmd);

            dataGridView1.DataSource = Singleton.DS.Tables[0];
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}