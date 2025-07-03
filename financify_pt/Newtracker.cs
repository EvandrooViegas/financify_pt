using financify_pt.Auth;
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
    public partial class Newtracker : Form
    {
        public Newtracker()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tbDescription.Text == "" || tbName.Text == "")
            {
                MessageBox.Show("Name or description cannot be empty");
                return;
            }
            else
            {
                try
                {
                    var tracker = BLL.Tracker.Create(tbName.Text, tbDescription.Text);
                    BLL.UserTracker.Create(tracker.Id, Globals.UserId, true);
                    MessageBox.Show("Tracker Created Successfully");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
