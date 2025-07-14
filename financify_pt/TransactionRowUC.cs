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
    public partial class TransactionRowUC : UserControl
    {
        public int id {  get; set; }
        public decimal value { get; set; }
        public string type { get; set; }
        public int addedById { get; set; }
        public DateTime date { get; set; }
        public int trackerId { get; set; }
        public TransactionRowUC(int _value, string _type, int _addedById, DateTime _date, int _id, int _trackerId)
        {
            value = _value;
            type = _type;
            addedById = _addedById;
            date = _date;
            trackerId = _trackerId;

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TransactionUC_Load(object sender, EventArgs e)
        {
            var isOwner = BLL.UserTracker.IsUserOwner(Globals.UserId, trackerId);
            if (!isOwner)
            {
                label5.Hide();
            } else
            {
                label5.Show();
            }

                var user = BLL.User.GetById(addedById);

            label2.Text = value.ToString() + "$";
            label1.Text = date.ToString();
            label3.Text = "Added by: " + user.Username;
            label4.Text = type.ToString();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this transaction?",
                                                "Confirm Delete",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                BLL.Transaction.Delete(id);
                MessageBox.Show("Transaction deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
            }
        }
    }
}
