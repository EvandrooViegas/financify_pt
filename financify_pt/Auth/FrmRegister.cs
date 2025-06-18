using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace financify_pt
{
    public partial class FrmRegister : Form
    {
        
        public FrmRegister()
        {
            InitializeComponent();
        }


        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerlogin_btn_Click(object sender, EventArgs e)
        {
            FrmLogin loginform = new FrmLogin();
            loginform.Show();

            this.Hide();
        }

        private void register_btn_Click(object sender, EventArgs e)
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
                    BLL.User.CreateUser(register_email.Text, register_pass.Text, register_name.Text, false, false);
                    MessageBox.Show("Register Successfull");
                    var form = new FrmLogin();
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
            

        private void registerform_Load(object sender, EventArgs e)
        {

        }

        private void register_showpass_CheckedChanged(object sender, EventArgs e)
        {
            register_pass.PasswordChar = register_showpass.Checked ? '\0' : '*';
            register_confirmpass.PasswordChar = register_showpass.Checked ? '\0' : '*';
        }
    }
}
