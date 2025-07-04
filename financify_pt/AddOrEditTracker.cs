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
            var form = new UserPrevileges();
            form.ShowDialog();
            RefreshUserDataGridViewData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tbDescription.Text == "" || tbName.Text == "")
            {
                MessageBox.Show("Name or description cannot be empty");
                return;
            }
            else
            {
                try
                {
                    var tracker = BLL.Tracker.Create(tbName.Text, tbDescription.Text);
                    BLL.UserTracker.Create(tracker.Id, Globals.UserId, true);
                    MessageBox.Show("Tracker Created Successfully");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
                button1.Hide();
                button2.Hide();
                dataGridView1.Hide();
                return;
            }
            tbName.Text = TrackerToEdit.Name;
            tbDescription.Text = TrackerToEdit.Description;

            RefreshUserDataGridViewData();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
