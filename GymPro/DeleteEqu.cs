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
    public partial class DeleteEqu : Form
    {
        public DeleteEqu()
        {
            InitializeComponent();
        }

        private void DeleteEqu_Load(object sender, EventArgs e)
        {
            var cmd = Singleton.cmd;

            cmd.CommandText = "select * from Equipment";
            Singleton.Command(cmd);

            dataGridView1.DataSource = Singleton.DS.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete your equipment. Are you sure?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var cmd = Singleton.cmd;

                cmd.CommandText = "delete from Equipment where E_ID = " + txtSearch.Text + "";
                Singleton.Command(cmd);
            }
            else
            {
                this.Activate();
                var cmd = Singleton.cmd;

                cmd.CommandText = "select * from Equipment";
                Singleton.Command(cmd);
                dataGridView1.DataSource = Singleton.DS.Tables[0];


            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
