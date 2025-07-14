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
    public partial class NotificationRowUC : UserControl
    {
        public int notificationId { get; set; }
        public NotificationRowUC(int notificationId)
        {
            InitializeComponent();
            this.notificationId = notificationId;
        }

        private void NotificationRowUC_Load(object sender, EventArgs e)
        {
            var notification = BLL.Notification.GetById(notificationId);
            label1.Text = notification["Message"].ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            BLL.Notification.Delete(notificationId);
            Hide();
        }
    }
}
