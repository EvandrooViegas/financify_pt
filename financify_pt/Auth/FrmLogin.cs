using financify_pt.Auth;
using System;
using System.Runtime.InteropServices;
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

            // Permite mover o form ao clicar fora dos botões/inputs
            this.MouseDown += FrmLogin_MouseDown;

            // Garante que o botão X funciona mesmo que o evento não esteja conectado no designer
            btn_X.Click += btn_X_Click;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            ApplyMoveFormToControls(this);
        }

        private void ApplyMoveFormToControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                // Ignora botões, checkboxes, textboxes e picturebox para não atrapalhar o clique
                if (!(c is Button) && !(c is CheckBox) && !(c is TextBox) && !(c is PictureBox))
                {
                    c.MouseDown += FrmLogin_MouseDown;
                }

                if (c.HasChildren)
                {
                    ApplyMoveFormToControls(c);
                }
            }
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            FrmRegister regform = new FrmRegister();
            regform.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_email.Text == "" || login_pass.Text == "")
            {
                MessageBox.Show("Email or pass cannot be empty");
                return;
            }

            try
            {
                var user = BLL.User.Login(login_email.Text, login_pass.Text);
                if (user == null)
                {
                    MessageBox.Show("The email or password are wrong");
                }
                else
                {
                    MessageBox.Show("Login Successful");
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            login_pass.PasswordChar = login_showpass.Checked ? '\0' : '*';
        }
    }
}
