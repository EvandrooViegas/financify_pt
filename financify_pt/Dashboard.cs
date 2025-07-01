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

        private void Dashboard_Load_1(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.AutoScroll = true;

            var trackers = BLL.Tracker.GetTrackersByUserId(Globals.UserId);

            int itemWidth = 409;
            int itemHeight = 231;
            int margin = 10;
            int columns = 3;

            for (int i = 0; i < trackers.Count(); i++)
            {
                var tracker = trackers[i];

                var trackerUC = new TrackerUC(tracker.Name, tracker.Description, tracker.Id)
                {
                    Size = new Size(itemWidth, itemHeight)
                };

                // Calculate grid position
                int col = i % columns;
                int row = i / columns;

                int x = col * (itemWidth + margin);
                int y = row * (itemHeight + margin);

                trackerUC.Location = new Point(x, y);

                panel3.Controls.Add(trackerUC);
            }
    }

    private void button1_Click(object sender, EventArgs e)
        {
            var tracker = new Newtracker();
            tracker.ShowDialog();
        }

    }
}
