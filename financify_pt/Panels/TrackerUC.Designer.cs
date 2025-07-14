namespace financify_pt.Panels
{
    partial class TrackerUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackerUC));
            btn_newTracker = new Guna.UI2.WinForms.Guna2Button();
            panel3 = new Panel();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
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
            btn_newTracker.Location = new Point(413, 22);
            btn_newTracker.Name = "btn_newTracker";
            btn_newTracker.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_newTracker.Size = new Size(180, 29);
            btn_newTracker.TabIndex = 32;
            btn_newTracker.Text = "Add New Tracker";
            btn_newTracker.Click += btn_newTracker_Click;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Location = new Point(16, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(577, 369);
            panel3.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(46, 17);
            label4.Name = "label4";
            label4.Size = new Size(157, 29);
            label4.TabIndex = 30;
            label4.Text = "My Trackers";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(16, 22);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 24);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 29;
            pictureBox5.TabStop = false;
            // 
            // TrackerUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(btn_newTracker);
            Controls.Add(panel3);
            Controls.Add(label4);
            Controls.Add(pictureBox5);
            Name = "TrackerUC";
            Size = new Size(613, 447);
            Load += TrackerUC_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_newTracker;
        private Panel panel3;
        private Label label4;
        private PictureBox pictureBox5;
    }
}
