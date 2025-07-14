using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace financify_pt.Panels
{
    public partial class InvitationUC : UserControl
    {
        public InvitationUC()
        {
            InitializeComponent();
        }

        private void InvitationUC_Load(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            // ✅ Atribuir corretamente o retorno da função
            var invitations = BLL.Invitation.GetAllFromUser(Globals.UserId);

            if (invitations == null || invitations.Count == 0)
            {
                Label emptyLabel = new Label
                {
                    Text = "No invitations found.",
                    ForeColor = Color.White,
                    AutoSize = true,
                    Padding = new Padding(10)
                };
                panel3.Controls.Add(emptyLabel);
                return;
            }
            int y = 0;
            foreach (var invitation in invitations)
            {
                var uc = new InvitationRowUC(invitation.Id);
                uc.Location = new Point(0, y);
                uc.Width = panel3.Width;
                uc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                panel3.Controls.Add(uc);
                y += uc.Height + 10;
            }
        }
    }
}
