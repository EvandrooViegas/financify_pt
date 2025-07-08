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
    public partial class TransactionUC : UserControl
    {
        public decimal value {  get; set; }
        public string type {  get; set; }
        public int addedById {  get; set; }
        public DateTime date {  get; set; }
        public TransactionUC(int _value, string _type, int _addedById, DateTime _date)
        {
            value = _value; 
            type = _type;
            addedById = _addedById;
            date = _date;

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
            var user = BLL.User.GetById(addedById);

            label2.Text = value.ToString();
            label1.Text = date.ToString();
            label3.Text = "Added by: " + user.Username;
            label4.text = type.ToString();
        }
    }
}
