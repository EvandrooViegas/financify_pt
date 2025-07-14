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
    public partial class ManageUsers : Form
    {
        private int trackerId { get; set; }
        public ManageUsers(int trackerId)
        {
            InitializeComponent();
            this.trackerId = trackerId;
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            RefreshUserDataGridViewData();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            var form = new UserPrevileges(trackerId);
            form.ShowDialog();
            RefreshUserDataGridViewData();
        }

        private void RefreshUserDataGridViewData()
        {
            var trackerUsers = BLL.UserTracker.GetUsersByTrackerId(trackerId);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = trackerUsers;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row first");
                return;
            }

            var idToDelete = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

            try
            {
                var isOwner = BLL.UserTracker.IsUserOwner(idToDelete, trackerId);
                if (isOwner)
                {
                    MessageBox.Show("You can't remove the owner");
                    return;
                }


                BLL.UserTracker.Delete(trackerId, idToDelete);
                MessageBox.Show("User removed!");
                RefreshUserDataGridViewData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
