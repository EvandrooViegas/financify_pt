namespace financify_pt
{
    partial class FrmRegister
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            registerlogin_btn = new Button();
            label7 = new Label();
            label2 = new Label();
            register_showpass = new CheckBox();
            register_btn = new Button();
            register_pass = new TextBox();
            label5 = new Label();
            register_email = new TextBox();
            label4 = new Label();
            label3 = new Label();
            register_confirmpass = new TextBox();
            label1 = new Label();
            register_name = new TextBox();
            label6 = new Label();
            btn_cancel = new Button();
            guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            pictureBox1 = new PictureBox();
            btn_X = new Button();
            guna2CustomGradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // registerlogin_btn
            // 
            registerlogin_btn.BackColor = Color.FromArgb(0, 255, 200);
            registerlogin_btn.FlatAppearance.MouseDownBackColor = Color.Teal;
            registerlogin_btn.FlatAppearance.MouseOverBackColor = Color.Teal;
            registerlogin_btn.FlatStyle = FlatStyle.Flat;
            registerlogin_btn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerlogin_btn.ForeColor = Color.White;
            registerlogin_btn.Location = new Point(31, 374);
            registerlogin_btn.Margin = new Padding(3, 2, 3, 2);
            registerlogin_btn.Name = "registerlogin_btn";
            registerlogin_btn.Size = new Size(319, 30);
            registerlogin_btn.TabIndex = 8;
            registerlogin_btn.Text = "SIGN IN";
            registerlogin_btn.UseVisualStyleBackColor = false;
            registerlogin_btn.Click += registerlogin_btn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(112, 340);
            label7.Name = "label7";
            label7.Size = new Size(149, 23);
            label7.TabIndex = 3;
            label7.Text = "SIGN IN HERE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Menu;
            label2.Location = new Point(54, 188);
            label2.Name = "label2";
            label2.Size = new Size(296, 23);
            label2.TabIndex = 1;
            label2.Text = "Income and expenses tracker ";
            // 
            // register_showpass
            // 
            register_showpass.AutoSize = true;
            register_showpass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_showpass.ForeColor = Color.Transparent;
            register_showpass.Location = new Point(612, 337);
            register_showpass.Margin = new Padding(3, 2, 3, 2);
            register_showpass.Name = "register_showpass";
            register_showpass.Size = new Size(139, 25);
            register_showpass.TabIndex = 17;
            register_showpass.Text = "Show password";
            register_showpass.UseVisualStyleBackColor = true;
            register_showpass.CheckedChanged += register_showpass_CheckedChanged;
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.FromArgb(0, 255, 200);
            register_btn.FlatAppearance.BorderSize = 0;
            register_btn.FlatAppearance.MouseDownBackColor = Color.Teal;
            register_btn.FlatAppearance.MouseOverBackColor = Color.Teal;
            register_btn.FlatStyle = FlatStyle.Flat;
            register_btn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_btn.Location = new Point(394, 373);
            register_btn.Margin = new Padding(3, 2, 3, 2);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(88, 30);
            register_btn.TabIndex = 16;
            register_btn.Text = "SIGNUP";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += register_btn_Click;
            // 
            // register_pass
            // 
            register_pass.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_pass.Location = new Point(394, 242);
            register_pass.Margin = new Padding(3, 2, 3, 2);
            register_pass.Name = "register_pass";
            register_pass.PasswordChar = '*';
            register_pass.Size = new Size(368, 27);
            register_pass.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(394, 219);
            label5.Name = "label5";
            label5.Size = new Size(94, 19);
            label5.TabIndex = 14;
            label5.Text = "PASSWORD";
            // 
            // register_email
            // 
            register_email.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_email.Location = new Point(394, 186);
            register_email.Margin = new Padding(3, 2, 3, 2);
            register_email.Name = "register_email";
            register_email.Size = new Size(368, 27);
            register_email.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(394, 163);
            label4.Name = "label4";
            label4.Size = new Size(55, 19);
            label4.TabIndex = 12;
            label4.Text = "EMAIL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(394, 64);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 11;
            label3.Text = "REGISTER";
            // 
            // register_confirmpass
            // 
            register_confirmpass.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_confirmpass.Location = new Point(394, 296);
            register_confirmpass.Margin = new Padding(3, 2, 3, 2);
            register_confirmpass.Name = "register_confirmpass";
            register_confirmpass.PasswordChar = '*';
            register_confirmpass.Size = new Size(368, 27);
            register_confirmpass.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(394, 273);
            label1.Name = "label1";
            label1.Size = new Size(168, 19);
            label1.TabIndex = 19;
            label1.Text = "CONFIRM PASSWORD";
            label1.Click += label1_Click;
            // 
            // register_name
            // 
            register_name.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_name.Location = new Point(394, 125);
            register_name.Margin = new Padding(3, 2, 3, 2);
            register_name.Name = "register_name";
            register_name.Size = new Size(368, 27);
            register_name.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(394, 102);
            label6.Name = "label6";
            label6.Size = new Size(52, 19);
            label6.TabIndex = 21;
            label6.Text = "NAME";
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.FromArgb(0, 255, 200);
            btn_cancel.FlatAppearance.BorderSize = 0;
            btn_cancel.FlatAppearance.MouseDownBackColor = Color.Teal;
            btn_cancel.FlatAppearance.MouseOverBackColor = Color.Teal;
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancel.Location = new Point(663, 371);
            btn_cancel.Margin = new Padding(3, 2, 3, 2);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(88, 30);
            btn_cancel.TabIndex = 23;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // guna2CustomGradientPanel3
            // 
            guna2CustomGradientPanel3.BorderColor = Color.Transparent;
            guna2CustomGradientPanel3.Controls.Add(pictureBox1);
            guna2CustomGradientPanel3.Controls.Add(registerlogin_btn);
            guna2CustomGradientPanel3.Controls.Add(label2);
            guna2CustomGradientPanel3.Controls.Add(label7);
            guna2CustomGradientPanel3.CustomizableEdges = customizableEdges3;
            guna2CustomGradientPanel3.FillColor = Color.Black;
            guna2CustomGradientPanel3.FillColor2 = Color.Gray;
            guna2CustomGradientPanel3.FillColor3 = Color.Black;
            guna2CustomGradientPanel3.FillColor4 = Color.DimGray;
            guna2CustomGradientPanel3.Location = new Point(0, -1);
            guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            guna2CustomGradientPanel3.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2CustomGradientPanel3.Size = new Size(368, 437);
            guna2CustomGradientPanel3.TabIndex = 24;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.image;
            pictureBox1.Location = new Point(101, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
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
            btn_X.Location = new Point(738, -1);
            btn_X.Margin = new Padding(3, 2, 3, 2);
            btn_X.Name = "btn_X";
            btn_X.Size = new Size(43, 33);
            btn_X.TabIndex = 25;
            btn_X.Text = "X";
            btn_X.UseVisualStyleBackColor = false;
            btn_X.Click += btn_X_Click;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(783, 436);
            Controls.Add(btn_X);
            Controls.Add(guna2CustomGradientPanel3);
            Controls.Add(btn_cancel);
            Controls.Add(register_name);
            Controls.Add(label6);
            Controls.Add(register_confirmpass);
            Controls.Add(label1);
            Controls.Add(register_showpass);
            Controls.Add(register_btn);
            Controls.Add(register_pass);
            Controls.Add(label5);
            Controls.Add(register_email);
            Controls.Add(label4);
            Controls.Add(label3);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "registerform";
            Load += registerform_Load;
            MouseDown += FrmRegister_MouseDown;
            guna2CustomGradientPanel3.ResumeLayout(false);
            guna2CustomGradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button registerlogin_btn;
        private Label label7;
        private Label label2;
        private CheckBox register_showpass;
        private Button register_btn;
        private TextBox register_pass;
        private Label label5;
        private TextBox register_email;
        private Label label4;
        private Label label3;
        private TextBox register_confirmpass;
        private Label label1;
        private TextBox register_name;
        private Label label6;
        private Button btn_cancel;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private PictureBox pictureBox1;
        private Button btn_X;
    }
}