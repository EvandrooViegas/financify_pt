using System;
using System.Windows.Forms;

namespace financify_pt.Auth
{
    public partial class TrackerUC : UserControl
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }

        public TrackerUC()
        {
            InitializeComponent();
        }

        public TrackerUC(string title, string description, int id) : this()
        {
            Title = title;
            Description = description;
            Id = id;
        }

        private void TrackerUC_Load(object sender, EventArgs e)
        {
            label1.Text = Title;
            richTextBox1.Text = Description;
        }
    }
}
