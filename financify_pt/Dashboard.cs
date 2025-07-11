using financify_pt.Panels;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace financify_pt.Auth
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {


        }

        private void LoadContent(UserControl uc)
        {
            panel2.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel2.Controls.Add(uc);
        }

        private void RefreshData()
        {
            var authedUser = BLL.User.GetById(Globals.UserId);
            label5.Text = authedUser.Email;


        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_newTracker_Click(object sender, EventArgs e)
        {
            var tracker = new AddOrEditTracker();
            tracker.ShowDialog();
            RefreshData();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Globals.UserId = 0;
            MessageBox.Show("Logged out successfully");
            var form = new Main();
            form.ShowDialog();

            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            LoadContent(new TransactionUC());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //this.close
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LoadContent(new TrackerUC());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            LoadContent(new NotificationUC());
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            var form = new Main();
            form.ShowDialog();
        }
    }
}
