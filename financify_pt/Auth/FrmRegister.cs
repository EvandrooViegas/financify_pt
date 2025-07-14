using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

            // Permite mover o form ao clicar em qualquer parte neutra
            this.MouseDown += FrmRegister_MouseDown;

            // Conecta o evento ao botão close (caso não esteja feito no designer)

        }

        private void registerform_Load(object sender, EventArgs e)
        {
            // Aplica a lógica recursiva sem afetar controles interativos
            ApplyMoveFormToControls(this);
        }

        private void ApplyMoveFormToControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                // Ignora controles interativos
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
        private void register_showpass_CheckedChanged(object sender, EventArgs e)
        {
            bool show = register_showpass.Checked;
            register_pass.PasswordChar = show ? '\0' : '*';
            register_confirmpass.PasswordChar = show ? '\0' : '*';
        }



        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (register_email.Text == "" || register_pass.Text == "" || register_confirmpass.Text == "" || register_name.Text == "")
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (register_pass.Text != register_confirmpass.Text)
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            else
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(register_email.Text);
                    BLL.User.CreateUser(register_email.Text, register_pass.Text, register_name.Text, false, false);
                    MessageBox.Show("Register Successful");

                    FrmLogin loginForm = new FrmLogin();
                    loginForm.Show();

                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registerlogin_Click(object sender, EventArgs e)
        {
            FrmLogin loginform = new FrmLogin();
            loginform.Show();
            this.Close();
        }

        private void register_confirmpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            register_pass.PasswordChar = '*';
            register_confirmpass.PasswordChar = '*';

            ApplyMoveFormToControls(this);
        }
    }
}
