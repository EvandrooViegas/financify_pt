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
            Close();
        }

       





        private void login_showpass_CheckedChanged(object sender, EventArgs e)
        {
            txt_pass.PasswordChar = login_showpass.Checked ? '\0' : '*';
        }

        private void login_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load_1(object sender, EventArgs e)
        {

        }

        private void login_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Email or password cannot be empty.");
                return;
            }

            try
            {
                var user = BLL.User.Login(txt_email.Text, txt_pass.Text);
                if (user == null)
                {
                    MessageBox.Show("Incorrect email or password.");
                }
                else
                {
                    Globals.UserId = user.Id;
                    this.DialogResult = DialogResult.OK; // ✅ Signals Main to proceed
                    this.Close(); // ✅ Closes FrmLogin
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_singUp_Click(object sender, EventArgs e)
        {
            FrmRegister regform = new FrmRegister();
            regform.Show();
            this.Hide();
        }
    }
}
