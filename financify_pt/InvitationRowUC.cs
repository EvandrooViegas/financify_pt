using System;
using System.Windows.Forms;
using static financify_pt.BLL;

namespace financify_pt
{
    public partial class InvitationRowUC : UserControl
    {
        public int InvitationId { get; set; }

        public InvitationRowUC(int invitationId)
        {
            InvitationId = invitationId;
            InitializeComponent();
        }

        private void InvitationRowUC_Load(object sender, EventArgs e)
        {
            LoadInvitationData();
        }

        private void LoadInvitationData()
        {
            var invitation = BLL.Invitation.GetById(InvitationId);
            if (invitation == null)
            {
                MessageBox.Show("Invitation not found.");
                return;
            }

            var tracker = BLL.Tracker.GetById(invitation.TrackerId);
            var owner = BLL.UserTracker.GetOwnerByTrackerId(tracker.Id);

            if (owner == null || tracker == null)
            {
                MessageBox.Show("Invalid user or tracker.");
                return;
            }

            string message = $"{owner["Username"]} invited you to their tracker ({tracker.Name})";

            // Supondo que tenhas um Label chamado lblMessage
            label1.Text = message;
        }

        private void btn_newTracker_Click(object sender, EventArgs e)
        {
            AcceptInvitation();
        }

        private void AcceptInvitation()
        {
            var invitation = BLL.Invitation.GetById(InvitationId);
            if (invitation == null) return;

            var tracker = BLL.Tracker.GetById(invitation.TrackerId);
            if (tracker == null) return;
            var owner = BLL.UserTracker.GetOwnerByTrackerId(tracker.Id);

            var authedUser = BLL.User.GetById(Globals.UserId);

            BLL.UserTracker.Create(tracker.Id, invitation.UserId, false);
            BLL.Invitation.Delete(InvitationId);


            BLL.Notification.Create($"You joined {tracker.Name}", invitation.UserId);
            BLL.Notification.Create($"{authedUser.Username} is a new member to your tracker ({tracker.Name})", Convert.ToInt32(owner["Id"]));

            MessageBox.Show($"You joined the tracker: {tracker.Name}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Are you sure you want to decline this invitation?",
                "Confirm Decline",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                DeclineInvitation();
            }
        }

        private void DeclineInvitation()
        {
            BLL.Invitation.Delete(InvitationId);
            MessageBox.Show("Invitation declined.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
        }
    }
}
