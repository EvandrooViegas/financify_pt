namespace financify_pt
{
    partial class Tracker
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

        #region Windows Form Designer generated code

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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label2 = new Label();
            label3 = new Label();
            register_Btn = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 77);
            label2.MaximumSize = new Size(400, 100);
            label2.Name = "label2";
            label2.Size = new Size(362, 100);
            label2.TabIndex = 6;
            label2.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(26, 26);
            label3.Name = "label3";
            label3.Size = new Size(160, 37);
            label3.TabIndex = 5;
            label3.Text = "TRACKER 1";
            // 
            // register_Btn
            // 
            register_Btn.BackColor = Color.Transparent;
            register_Btn.BackgroundImageLayout = ImageLayout.None;
            register_Btn.BorderColor = Color.Transparent;
            register_Btn.BorderRadius = 10;
            register_Btn.CustomizableEdges = customizableEdges1;
            register_Btn.DisabledState.BorderColor = Color.DarkGray;
            register_Btn.DisabledState.CustomBorderColor = Color.DarkGray;
            register_Btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            register_Btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            register_Btn.FillColor = Color.White;
            register_Btn.FocusedColor = Color.Transparent;
            register_Btn.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            register_Btn.ForeColor = Color.Black;
            register_Btn.Location = new Point(669, 40);
            register_Btn.Name = "register_Btn";
            register_Btn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            register_Btn.Size = new Size(100, 23);
            register_Btn.TabIndex = 22;
            register_Btn.Text = "Edit";
            register_Btn.Click += register_Btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16.25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 177);
            label1.Name = "label1";
            label1.Size = new Size(127, 27);
            label1.TabIndex = 23;
            label1.Text = "Transactions";
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BackgroundImageLayout = ImageLayout.None;
            guna2Button1.BorderColor = Color.Transparent;
            guna2Button1.BorderRadius = 10;
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.FocusedColor = Color.Transparent;
            guna2Button1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(626, 177);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(143, 29);
            guna2Button1.TabIndex = 24;
            guna2Button1.Text = "New Transaction";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // Tracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(guna2Button1);
            Controls.Add(label1);
            Controls.Add(register_Btn);
            Controls.Add(label2);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Tracker";
            Text = "Tracker";
            Load += Tracker_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button register_Btn;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}