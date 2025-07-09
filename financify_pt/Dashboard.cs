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

        private void RefreshData()
        {
            var authedUser = BLL.User.GetById(Globals.UserId);
            label5.Text = authedUser.Email;

            panel3.Controls.Clear();
            panel3.AutoScroll = true;

            var trackers = BLL.Tracker.GetTrackersByUserId(Globals.UserId);

            // Reverse to show the latest first
            var trackersReversed = trackers.Reverse().ToList();

            int itemWidth = 409;
            int itemHeight = 231;
            int margin = 10;
            int columns = 2;

            for (int i = 0; i < trackersReversed.Count(); i++)
            {
                var tracker = trackersReversed[i];

                var trackerUC = new TrackerUC(tracker.Name, tracker.Description, tracker.Id)
                {
                    Size = new Size(itemWidth, itemHeight)
                };

                int col = i % columns;
                int row = i / columns;

                int x = col * (itemWidth + margin);
                int y = row * (itemHeight + margin);

                trackerUC.Location = new Point(x, y);

                panel3.Controls.Add(trackerUC);
            }
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

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //this.close
        }
    }
}
