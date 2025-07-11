namespace financify_pt.Auth
{
    partial class TrackerCardUC
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            btm_view = new Guna.UI2.WinForms.Guna2Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(160, 37);
            label1.TabIndex = 0;
            label1.Text = "TRACKER 1";
            // 
            // btm_view
            // 
            btm_view.BorderRadius = 10;
            btm_view.CustomizableEdges = customizableEdges5;
            btm_view.DisabledState.BorderColor = Color.DarkGray;
            btm_view.DisabledState.CustomBorderColor = Color.DarkGray;
            btm_view.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btm_view.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btm_view.FillColor = Color.FromArgb(102, 163, 155);
            btm_view.Font = new Font("Segoe UI", 9F);
            btm_view.ForeColor = Color.White;
            btm_view.Location = new Point(24, 146);
            btm_view.Name = "btm_view";
            btm_view.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btm_view.Size = new Size(97, 23);
            btm_view.TabIndex = 3;
            btm_view.Text = "View";
            btm_view.Click += btm_view_Click_1;
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 70);
            label2.MaximumSize = new Size(400, 100);
            label2.Name = "label2";
            label2.Size = new Size(209, 65);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // TrackerCardUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(label2);
            Controls.Add(btm_view);
            Controls.Add(label1);
            Name = "TrackerCardUC";
            Size = new Size(212, 180);
            Load += TrackerUC_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btm_view;
        private Label label2;
    }
}
