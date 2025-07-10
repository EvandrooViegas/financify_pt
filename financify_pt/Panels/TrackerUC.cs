using financify_pt.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace financify_pt.Panels
{
    public partial class TrackerUC : UserControl
    {
        public TrackerUC()
        {
            InitializeComponent();
        }

        private void TrackerUC_Load(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.AutoScroll = true;

            var trackers = BLL.Tracker.GetTrackersByUserId(Globals.UserId);
            var trackersReversed = trackers.Reverse().ToList();

            int margin = 10;
            int columns = 2;

            // Calculate card width to fit inside panel3 width (577px)
            int panelWidth = 577;
            int itemWidth = (panelWidth - (columns - 1) * margin) / columns;  // = (577 - 10)/2 = 283 approx
            int itemHeight = 180; // reduce height a bit to fit more vertically, adjust as needed

            for (int i = 0; i < trackersReversed.Count(); i++)
            {
                var tracker = trackersReversed[i];

                var trackerUC = new TrackerCardUC(tracker.Name, tracker.Description, tracker.Id)
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
        }
    }
