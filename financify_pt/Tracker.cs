using financify_pt.Models;
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
    public partial class Tracker : Form
    {
        private TrackerModel TrackerToEdit { get; }

        public Tracker(TrackerModel tracker)
        {
            InitializeComponent();

            TrackerToEdit = tracker;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var form = new AddOrEditTracker(TrackerToEdit);
            form.ShowDialog();
        }

        private void LoadData()
        {
           var tracker = BLL.Tracker.GetById(TrackerToEdit.Id);

            label3.Text = tracker.Name;
            label2.Text = tracker.Description;
        }

        private void Tracker_Load(object sender, EventArgs e)
        {
            LoadData();   
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void register_Btn_Click(object sender, EventArgs e)
        {
            var form = new AddOrEditTracker(TrackerToEdit);
            form.ShowDialog();
            LoadData();

        }
    }
}
