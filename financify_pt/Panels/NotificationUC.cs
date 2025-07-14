using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace financify_pt.Panels
{
    public partial class NotificationUC : UserControl
    {
        public NotificationUC()
        {
            InitializeComponent();
        }

        private void NotificationUC_Load(object sender, EventArgs e)
        {
            panel3.Controls.Clear(); // Substitua por o nome do seu painel

            var notifications = BLL.Notification.GetAllFromUser(Globals.UserId); // Supondo que tenhas este método

            if (notifications == null || notifications.Count == 0)
            {
                Label emptyLabel = new Label
                {
                    Text = "No notifications found.",
                    ForeColor = Color.White,
                    AutoSize = true,
                    Padding = new Padding(10)
                };
                panel3.Controls.Add(emptyLabel);
                return;
            }

            int y = 0;
            foreach (var notification in notifications) // do mais recente para o mais antigo
            {
                var row = new NotificationRowUC(notification.Id);
                row.Location = new Point(0, y);
                row.Width = panel3.Width;
                row.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                panel3.Controls.Add(row);
                y += row.Height + 10;
            }
        }
    }
}
