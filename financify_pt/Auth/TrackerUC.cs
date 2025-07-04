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
            label2.Text = Description;

      
        }

        private void btm_view_Click(object sender, EventArgs e)
        {

        }

        private void btm_view_Click_1(object sender, EventArgs e)
        {
            var  TrackerToEdit = new Models.TrackerModel { Description = Description, Name = Title, Id  =Id  };
            var form = new Tracker(TrackerToEdit);
                form.ShowDialog();
        }
    }
}
