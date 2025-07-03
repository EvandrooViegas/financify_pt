using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Data.SqlClient;

namespace financify_pt
{
    public partial class FrmRegister : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public FrmRegister()
        {
            InitializeComponent();

            // Permite mover o form ao clicar em qualquer área neutra do formulário
            this.MouseDown += FrmRegister_MouseDown;

            // Certifique-se de substituir "btn_X" e "btn_cancel" pelo nome correto dos seus botões no Designer
            btn_X.Click += btn_X_Click;
            btn_cancel.Click += btn_cancel_Click_1;
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            ApplyMoveFormToControls(this);
        }

        private void ApplyMoveFormToControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                // Ignorar controles que devem responder a cliques normalmente
                if (!(c is Button) && !(c is CheckBox) && !(c is TextBox) && !(c is PictureBox))
                {
                    c.MouseDown += FrmRegister_MouseDown;
                }

                if (c.HasChildren)
                {
                    ApplyMoveFormToControls(c);
                }
            }
        }

        private void FrmRegister_MouseDown(object sender, MouseEventArgs e)
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

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void register_showpass_CheckedChanged(object sender, EventArgs e)
        {
            register_pass.PasswordChar = register_showpass.Checked ? '\0' : '*';
            register_confirmpass.PasswordChar = register_showpass.Checked ? '\0' : '*';
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(register_email.Text) ||
                string.IsNullOrWhiteSpace(register_pass.Text) ||
                string.IsNullOrWhiteSpace(register_confirmpass.Text) ||
                string.IsNullOrWhiteSpace(register_name.Text))
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (register_pass.Text != register_confirmpass.Text)
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                BLL.User.CreateUser(register_email.Text, register_pass.Text, register_name.Text, false, false);
                MessageBox.Show("Register Successful");
                var form = new FrmLogin();
                form.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_registerlogin_Click(object sender, EventArgs e)
        {
            FrmLogin loginform = new FrmLogin();
            loginform.Show();
            this.Hide();
        }
    }
}
