using System;
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
    public partial class DeleteMember : Form
    {
        public DeleteMember()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete your member. Are you sure?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var cmd = Singleton.cmd;
                cmd.CommandText = "delete from NewMember where MID = " + txtSearch.Text + "";
                Singleton.Command(cmd);
            }
            else
            {
                this.Activate();
                var cmd = Singleton.cmd;

                cmd.CommandText = "select * from NewMember";
                Singleton.Command(cmd);
                dataGridView1.DataSource = Singleton.DS.Tables[0];
            }

        }
        private void DeleteMember_Load(object sender, EventArgs e)
        {
            var cmd = Singleton.cmd;

            cmd.CommandText = "select * from NewMember";
            Singleton.Command(cmd);

            dataGridView1.DataSource = Singleton.DS.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
