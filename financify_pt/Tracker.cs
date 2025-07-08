using financify_pt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace financify_pt
{
    public partial class Tracker : Form
    {
        private TrackerModel TrackerToEdit { get; }

        public Tracker(TrackerModel tracker)
        {
            InitializeComponent();

            TrackerToEdit = tracker;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var form = new AddOrEditTracker(TrackerToEdit);
            form.ShowDialog();
        }

        private void LoadData()
        {
            var tracker = BLL.Tracker.GetById(TrackerToEdit.Id);

            label3.Text = tracker.Name;
            label2.Text = tracker.Description;

            panelTransactions.Controls.Clear(); // clear previous controls

            var transactions = BLL.Transaction.GetAllByTrackerId(TrackerToEdit.Id);

            int y = 0; // vertical offset
            foreach (var transaction in transactions.Reverse())
            {
                var uc = new TransactionUC((int)transaction.Value, transaction.Type, transaction.CreatedById, transaction.Date); // assuming CreatedAt exists
                uc.Location = new Point(0, y);
                uc.Width = panelTransactions.Width;
                uc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                panelTransactions.Controls.Add(uc);
                y += uc.Height + 10; // space between controls
            }
        }

        private void Tracker_Load(object sender, EventArgs e)
        {
            var isOwner = BLL.UserTracker.IsUserOwner(Globals.UserId, TrackerToEdit.Id);
            if (!isOwner)
            {
                register_Btn.Hide();
            }
            LoadData();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var form = new transactions(TrackerToEdit.Id);
            form.ShowDialog();
            LoadData();
        }

        private void register_Btn_Click(object sender, EventArgs e)
        {
            var form = new AddOrEditTracker(TrackerToEdit);
            form.ShowDialog();
            LoadData();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
