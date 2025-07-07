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
        public transactions()
        {
            InitializeComponent();
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
            var type = comboBox1.SelectedValue;

            if(date > DateTime.Now)
            {
                MessageBox.Show("The date cannot be in the future");
                return;
            }

            if (value <= 0) {
                MessageBox.Show("The value cannot be less or equal to zero");
                return;
            }

            if(type == "")
            {
                MessageBox.Show("The type cannot be empty");
                return;
            }



        }
    }
}
