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
    public partial class transactions : Form
    {
        public int trackerId { get; set; }
        public transactions(int trackerId)
        {
            InitializeComponent();
            this.trackerId = trackerId;
        }

        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            var value = guna2NumericUpDown1.Value;
            var date = guna2DateTimePicker1.Value;
            var type = comboBox1.SelectedItem?.ToString(); // ✅ safer way
            var description = richTextBox1.Text;

            if (date > DateTime.Now)
            {
                MessageBox.Show("The date cannot be in the future");
                return;
            }

            if (value <= 0)
            {
                MessageBox.Show("The value cannot be less or equal to zero");
                return;
            }

            if (string.IsNullOrWhiteSpace(type))
            {
                MessageBox.Show("The type cannot be empty");
                return;
            }

            string[] validTypes = { "Eletronics", "Fitness", "Alimentation", "Health", "Others" };
            if (!validTypes.Contains(type))
            {
                MessageBox.Show("Invalid type selected. Please choose a valid category.");
                return;
            }

            try
            {
                BLL.Transaction.Create(value, type, Globals.UserId, trackerId, date, description);
                var isOwner = BLL.UserTracker.IsUserOwner(Globals.UserId, trackerId);
                if (isOwner)
                {
                    BLL.Notification.Create("A new transaction was created on your tracker", Globals.UserId);
                }
                MessageBox.Show("New transaction created successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
