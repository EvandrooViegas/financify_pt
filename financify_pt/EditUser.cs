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
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            var authed = BLL.User.GetById(Globals.UserId);

            txtEmail.Text = authed.Email;
            txtUsername.Text = authed.Username;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string username = txtUsername.Text.Trim();

            try
            {
                if (string.IsNullOrWhiteSpace(email))
                    throw new Exception("Email is required.");

                if (string.IsNullOrWhiteSpace(username))
                    throw new Exception("Username is required.");

                var addr = new System.Net.Mail.MailAddress(email);
                if (addr.Address != email)
                    throw new Exception("Invalid email format.");

                BLL.User.UpdateUser(Globals.UserId, email, username);

                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
