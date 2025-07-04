using Microsoft.IdentityModel.Tokens;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace financify_pt
{
    public partial class UserPrevileges : Form
    {

        private int trackerId { get; set; } 
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;


        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public UserPrevileges(int trackerId)
        {
            InitializeComponent();

            // Associa o evento para mover o form ao form e controles neutros
            this.MouseDown += UserPrevileges_MouseDown;
            ApplyMoveFormToControls(this);
            this.trackerId = trackerId;

            // Se tiver um botão para fechar (exemplo: button2), garanta que evento está ok

        }

        private void ApplyMoveFormToControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                // Ignora controles interativos para evitar conflito com botões etc.
                if (!(c is Button) && !(c is TextBox) && !(c is CheckBox) && !(c is PictureBox))
                {
                    c.MouseDown += UserPrevileges_MouseDown;
                }

                if (c.HasChildren)
                    ApplyMoveFormToControls(c);
            }
        }

        private void UserPrevileges_MouseDown(object sender, MouseEventArgs e)
        {
            // Se o controle é interativo, não movemos o form aqui
            if (sender is Button || sender is TextBox || sender is CheckBox || sender is PictureBox)
                return;

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void edituser_Load(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Fecha ou esconde o form conforme sua lógica
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            var username = txtName.Text;
            if(username.IsNullOrEmpty())
            {
                MessageBox.Show("Insert a valid username");
                return;
            }

            try
            {
                var user = BLL.User.GetByUsername(username);
                if (user == null)
                {
                    new Exception("This user doesn't exists");
                }
               var exists = BLL.UserTracker.IsUserParticipant(user.Id, trackerId);
                if(exists)
                {
                    new Exception("User is already a participant of this tracker");
                }


                BLL.UserTracker.Create(trackerId, user.Id, radioButton1.Checked);
                MessageBox.Show("User participant created successfully!");
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
