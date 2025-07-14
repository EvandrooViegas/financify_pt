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
                var uc = new TransactionRowUC((int)transaction.Value, transaction.Type, transaction.CreatedById, transaction.Date, transaction.Id, TrackerToEdit.Id); // assuming CreatedAt exists
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
                guna2Button3.Hide();
                guna2Button2.Hide();
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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to delete this tracker? This action cannot be undone.",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                BLL.UserTracker.DeleteAllUsersFromTracker(TrackerToEdit.Id);
                BLL.Transaction.DeleteAllFromTracker(TrackerToEdit.Id);
                BLL.Tracker.Delete(TrackerToEdit.Id);
                MessageBox.Show("Tracker deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide(); // ou this.Parent.Controls.Remove(this); se estiver em um container
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var form = new ManageUsers(TrackerToEdit.Id);
            form.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
