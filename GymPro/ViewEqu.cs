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
    public partial class ViewEqu : Form
    {
        private readonly SqlCommand cmd = Singleton.cmd;

        public ViewEqu()
        {
            InitializeComponent();
        }

        private void ViewEqu_Load(object sender, EventArgs e)
        {
            cmd.CommandText = "SELECT * FROM Equipment";
            Singleton.Command(cmd);

            dataGridView1.DataSource = Singleton.DS.Tables[0];
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
