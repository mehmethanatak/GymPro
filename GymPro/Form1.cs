namespace GymPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMember nm = new NewMember();
            nm.Show();
        }

        private void newTrainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTrainer ns = new NewTrainer();
            ns.Show();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchMember sn = new SearchMember();
            sn.Show();
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)

        {
            DeleteMember dm = new DeleteMember();
            dm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure want to close this application?", "",MessageBoxButtons.YesNo, MessageBoxIcon.Error)==DialogResult.Yes)
            {
                Application.Exit();
            }
            
            }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure want to log out?", "",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
            {
                this.Close();
                Login lg = new Login();
                lg.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SearchTrainer sn = new SearchTrainer();
            sn.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DeleteTrainer dm = new DeleteTrainer();
            dm.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Equipment equ = new Equipment();
            equ.Show();
        }
    }
}
