using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace financify_pt.Auth
{
    public partial class TrackerUC : UserControl
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }
        public TrackerUC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void TrackerUC_Load(object sender, EventArgs e)
        {
            label1.Text  = Title;
            richTextBox1.Text = Description;
        }
    }
}
