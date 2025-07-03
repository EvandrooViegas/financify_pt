namespace financify_pt
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label3 = new Label();
            label4 = new Label();
            login_email = new TextBox();
            login_pass = new TextBox();
            label5 = new Label();
            login_btn = new Button();
            login_showpass = new CheckBox();
            btn_cancel = new Button();
            label2 = new Label();
            label7 = new Label();
            signup_btn = new Button();
            guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            pictureBox1 = new PictureBox();
            btn_X = new Button();
            guna2CustomGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(392, 77);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 2;
            label3.Text = "SIGN IN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(388, 136);
            label4.Name = "label4";
            label4.Size = new Size(55, 19);
            label4.TabIndex = 3;
            label4.Text = "EMAIL";
            // 
            // login_email
            // 
            login_email.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_email.Location = new Point(388, 159);
            login_email.Margin = new Padding(3, 2, 3, 2);
            login_email.Name = "login_email";
            login_email.Size = new Size(368, 27);
            login_email.TabIndex = 4;
            // 
            // login_pass
            // 
            login_pass.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_pass.Location = new Point(388, 223);
            login_pass.Margin = new Padding(3, 2, 3, 2);
            login_pass.Name = "login_pass";
            login_pass.PasswordChar = '*';
            login_pass.Size = new Size(368, 27);
            login_pass.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(388, 200);
            label5.Name = "label5";
            label5.Size = new Size(94, 19);
            label5.TabIndex = 5;
            label5.Text = "PASSWORD";
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(0, 255, 200);
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatAppearance.MouseDownBackColor = Color.Teal;
            login_btn.FlatAppearance.MouseOverBackColor = Color.Teal;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.Location = new Point(399, 320);
            login_btn.Margin = new Padding(3, 2, 3, 2);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(88, 30);
            login_btn.TabIndex = 7;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // login_showpass
            // 
            login_showpass.AutoSize = true;
            login_showpass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_showpass.ForeColor = Color.Transparent;
            login_showpass.Location = new Point(607, 251);
            login_showpass.Margin = new Padding(3, 2, 3, 2);
            login_showpass.Name = "login_showpass";
            login_showpass.Size = new Size(139, 25);
            login_showpass.TabIndex = 8;
            login_showpass.Text = "Show password";
            login_showpass.UseVisualStyleBackColor = true;
            login_showpass.CheckedChanged += login_showpass_CheckedChanged;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.FromArgb(0, 255, 200);
            btn_cancel.FlatAppearance.BorderSize = 0;
            btn_cancel.FlatAppearance.MouseDownBackColor = Color.Teal;
            btn_cancel.FlatAppearance.MouseOverBackColor = Color.Teal;
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancel.Location = new Point(658, 320);
            btn_cancel.Margin = new Padding(3, 2, 3, 2);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(88, 30);
            btn_cancel.TabIndex = 10;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Menu;
            label2.Location = new Point(40, 198);
            label2.Name = "label2";
            label2.Size = new Size(296, 23);
            label2.TabIndex = 1;
            label2.Text = "Income and expenses tracker ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(95, 368);
            label7.Name = "label7";
            label7.Size = new Size(168, 23);
            label7.TabIndex = 3;
            label7.Text = "REGISTER HERE";
            // 
            // signup_btn
            // 
            signup_btn.BackColor = Color.FromArgb(0, 255, 200);
            signup_btn.FlatAppearance.MouseDownBackColor = Color.Teal;
            signup_btn.FlatAppearance.MouseOverBackColor = Color.Teal;
            signup_btn.FlatStyle = FlatStyle.Flat;
            signup_btn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_btn.ForeColor = Color.White;
            signup_btn.Location = new Point(17, 393);
            signup_btn.Margin = new Padding(3, 2, 3, 2);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(319, 30);
            signup_btn.TabIndex = 8;
            signup_btn.Text = "SIGNUP";
            signup_btn.UseVisualStyleBackColor = false;
            signup_btn.Click += signup_btn_Click;
            // 
            // guna2CustomGradientPanel3
            // 
            guna2CustomGradientPanel3.BorderColor = Color.Transparent;
            guna2CustomGradientPanel3.Controls.Add(pictureBox1);
            guna2CustomGradientPanel3.Controls.Add(signup_btn);
            guna2CustomGradientPanel3.Controls.Add(label2);
            guna2CustomGradientPanel3.Controls.Add(label7);
            guna2CustomGradientPanel3.CustomizableEdges = customizableEdges3;
            guna2CustomGradientPanel3.FillColor = Color.Black;
            guna2CustomGradientPanel3.FillColor2 = Color.Gray;
            guna2CustomGradientPanel3.FillColor3 = Color.Black;
            guna2CustomGradientPanel3.FillColor4 = Color.DimGray;
            guna2CustomGradientPanel3.Location = new Point(0, 0);
            guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            guna2CustomGradientPanel3.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2CustomGradientPanel3.Size = new Size(356, 437);
            guna2CustomGradientPanel3.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.image;
            pictureBox1.Location = new Point(86, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btn_X
            // 
            btn_X.BackColor = Color.Transparent;
            btn_X.FlatAppearance.BorderSize = 0;
            btn_X.FlatAppearance.MouseDownBackColor = Color.Teal;
            btn_X.FlatAppearance.MouseOverBackColor = Color.Teal;
            btn_X.FlatStyle = FlatStyle.Flat;
            btn_X.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_X.ForeColor = Color.White;
            btn_X.Location = new Point(735, 0);
            btn_X.Margin = new Padding(3, 2, 3, 2);
            btn_X.Name = "btn_X";
            btn_X.Size = new Size(47, 39);
            btn_X.TabIndex = 16;
            btn_X.Text = "X";
            btn_X.UseVisualStyleBackColor = false;
            btn_X.Click += btn_X_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(783, 436);
            Controls.Add(btn_X);
            Controls.Add(guna2CustomGradientPanel3);
            Controls.Add(btn_cancel);
            Controls.Add(login_showpass);
            Controls.Add(login_btn);
            Controls.Add(login_pass);
            Controls.Add(label5);
            Controls.Add(login_email);
            Controls.Add(label4);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MouseDown += FrmLogin_MouseDown;
            guna2CustomGradientPanel3.ResumeLayout(false);
            guna2CustomGradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private TextBox login_email;
        private TextBox login_pass;
        private Label label5;
        private Button login_btn;
        private CheckBox login_showpass;
        private Button btn_cancel;
        private Label label2;
        private Label label7;
        private Button signup_btn;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private PictureBox pictureBox1;
        private Button btn_X;
    }
}
