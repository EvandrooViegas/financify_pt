namespace financify_pt
{
    partial class InvitationRowUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btn_newTracker = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_newTracker
            // 
            btn_newTracker.BackColor = Color.Transparent;
            btn_newTracker.BorderRadius = 10;
            btn_newTracker.CustomizableEdges = customizableEdges1;
            btn_newTracker.DisabledState.BorderColor = Color.DarkGray;
            btn_newTracker.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_newTracker.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_newTracker.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_newTracker.FillColor = Color.FromArgb(102, 163, 155);
            btn_newTracker.Font = new Font("Segoe UI", 9F);
            btn_newTracker.ForeColor = Color.White;
            btn_newTracker.Location = new Point(463, 13);
            btn_newTracker.Name = "btn_newTracker";
            btn_newTracker.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_newTracker.Size = new Size(91, 25);
            btn_newTracker.TabIndex = 33;
            btn_newTracker.Text = "Join";
            btn_newTracker.Click += btn_newTracker_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderRadius = 10;
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(563, 13);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(91, 25);
            guna2Button1.TabIndex = 34;
            guna2Button1.Text = "Decline";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(18, 13);
            label1.Name = "label1";
            label1.Size = new Size(296, 15);
            label1.TabIndex = 35;
            label1.Text = "Evandro sent you an invitation to his tracker (Tracker 1)";
            // 
            // InvitationRowUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(label1);
            Controls.Add(guna2Button1);
            Controls.Add(btn_newTracker);
            Name = "InvitationRowUC";
            Size = new Size(666, 52);
            Load += InvitationRowUC_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_newTracker;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label label1;
    }
}
