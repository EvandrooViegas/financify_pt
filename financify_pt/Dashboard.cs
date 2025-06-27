using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace financify_pt.Auth
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.Controls.Add(new Label()
            {
                Location = new Point(1, 1),
                Text = "asdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasdasd",
                ForeColor = Color.White,
                Size = new Size(100, 100)

            }
            );
        }

        private void tracker_Load(object sender, EventArgs e)
        {
            var trackers 
            this.panel3.Controls.Add(new TrackerUC()
            {
                Location = new Point(1, 1),
                Size = new Size(100, 100),
                Message = "O prof é o rei"
            }
            );

            this.panel3.Controls.Add(new TrackerUC()
            {
                Location = new Point(101, 1),
                Size = new Size(100, 100),
                Message = "O evandro é o submundo"
            }
);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tracker = new Newtracker();
            tracker.ShowDialog();
        }
    }
}
