using financify_pt.Auth;
using System.Runtime.InteropServices;
using System;
using System.Windows.Forms;

namespace financify_pt
{
    public partial class FrmLogin : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public FrmLogin()
        {
            InitializeComponent();

            // Permite mover o form clicando em QUALQUER lugar do form
            this.MouseDown += FrmLogin_MouseDown;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            FrmRegister regform = new FrmRegister();
            regform.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Permite mover o form mesmo quando clicar nos controles (botões, labels, etc.)
            foreach (Control c in this.Controls)
            {
                c.MouseDown += FrmLogin_MouseDown;
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_email.Text == "" || login_pass.Text == "")
            {
                MessageBox.Show("Email or pass cannot be empty");
                return;
            }
            else
            {
                try
                {
                    var user = BLL.User.Login(login_email.Text, login_pass.Text);
                    if (user == null)
                    {
                        MessageBox.Show("The email or password are wrong");
                    }
                    else
                    {
                        MessageBox.Show("Loggin Successful");
                        this.Hide();
                        Globals.UserId = user.Id;
                        var form = new Dashboard();
                        form.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.Hide();
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
        }

        private void login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            login_pass.PasswordChar = login_showpass.Checked ? '\0' : '*';
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            // ⚠️ REMOVIDO base.OnMouseDown(e); para evitar loop infinito
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}