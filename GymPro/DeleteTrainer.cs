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
    public partial class DeleteTrainer : Form
    {
        private readonly SqlCommand cmd = Singleton.cmd;

        public DeleteTrainer()
        {
            InitializeComponent();
        }

        private void DeleteTrainer_Load(object sender, EventArgs e)
        {
            cmd.CommandText = "select * from NewTrainer";
            Singleton.Command(cmd);

            dataGridView1.DataSource = Singleton.DS.Tables[0];
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete your trainer. Are you sure?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cmd.CommandText = "delete from NewTrainer where MID = " + txtSearch.Text + "";
                Singleton.Command(cmd);
            }
            else
            {
                this.Activate();

                cmd.CommandText = "select * from NewMember";
                Singleton.Command(cmd);
                dataGridView1.DataSource = Singleton.DS.Tables[0];
            }
        }
    }
}
