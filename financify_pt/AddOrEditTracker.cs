using financify_pt.Auth;
using financify_pt.Models;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace financify_pt
{
    public partial class AddOrEditTracker : Form
    {
        private TrackerModel TrackerToEdit { get; }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public AddOrEditTracker(TrackerModel tracker = null)
        {
            InitializeComponent();

            TrackerToEdit = tracker;

            // Evento para mover o form clicando em áreas neutras
            this.MouseDown += AddOrEditTracker_MouseDown;
            ApplyMoveFormToControls(this);
        }

        private void ApplyMoveFormToControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                // Evita associar a controles interativos para não interferir em botões, textbox etc
                if (!(c is Button) && !(c is TextBox) && !(c is CheckBox) && !(c is DataGridView) && !(c is PictureBox))
                {
                    c.MouseDown += AddOrEditTracker_MouseDown;
                }
                if (c.HasChildren)
                    ApplyMoveFormToControls(c);
            }
        }

        private void AddOrEditTracker_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshUserDataGridViewData()
        {
            var trackerUsers = BLL.UserTracker.GetUsersByTrackerId(TrackerToEdit.Id);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = trackerUsers;
        }

        private void Newtracker_Load(object sender, EventArgs e)
        {
            if (TrackerToEdit == null)
            {
                label4.Hide();
                guna2Button4.Hide();
                guna2Button5.Hide();
                dataGridView1.Hide();
                return;
            }
            tbName.Text = TrackerToEdit.Name;
            richTextBox1.Text = TrackerToEdit.Description;

            RefreshUserDataGridViewData();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            var form = new UserPrevileges(TrackerToEdit.Id);
            form.ShowDialog();
            RefreshUserDataGridViewData();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
          
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "" || tbName.Text == "")
            {
                MessageBox.Show("Name or description cannot be empty");
                return;
            }

            if (richTextBox1.Text.Length < 10 || richTextBox1.Text.Length > 100)
            {
                MessageBox.Show("The text length cannot be less than 10 or larger than 100 chars!");
                return;
            }
            else
            {
                try
                {

                    if (TrackerToEdit == null)
                    {
                        var tracker = BLL.Tracker.Create(tbName.Text, richTextBox1.Text);
                        BLL.UserTracker.Create(tracker.Id, Globals.UserId, true);
                        MessageBox.Show("Tracker Created Successfully");

                    }
                    else
                    {
                        BLL.Tracker.Update(TrackerToEdit.Id, tbName.Text, richTextBox1.Text);
                        MessageBox.Show("Tracker Updated Successfully");
                    }
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            var form = new UserPrevileges(TrackerToEdit.Id);
            form.ShowDialog();
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
                var isOwner = BLL.UserTracker.IsUserOwner(idToDelete, TrackerToEdit.Id);
                if (isOwner)
                {
                    MessageBox.Show("You can't remove the owner");
                    return;
                }


                BLL.UserTracker.Delete(TrackerToEdit.Id, idToDelete);
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
