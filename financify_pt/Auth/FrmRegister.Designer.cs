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
            panel1 = new Panel();
            registerlogin_btn = new Button();
            label7 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            close = new Label();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(registerlogin_btn);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 436);
            panel1.TabIndex = 10;
            // 
            // registerlogin_btn
            // 
            registerlogin_btn.BackColor = Color.Teal;
            registerlogin_btn.FlatAppearance.MouseDownBackColor = Color.Teal;
            registerlogin_btn.FlatAppearance.MouseOverBackColor = Color.Teal;
            registerlogin_btn.FlatStyle = FlatStyle.Flat;
            registerlogin_btn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerlogin_btn.ForeColor = Color.White;
            registerlogin_btn.Location = new Point(23, 371);
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
            label7.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(94, 339);
            label7.Name = "label7";
            label7.Size = new Size(149, 23);
            label7.TabIndex = 3;
            label7.Text = "SIGN IN HERE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Menu;
            label2.Location = new Point(23, 183);
            label2.Name = "label2";
            label2.Size = new Size(296, 23);
            label2.TabIndex = 1;
            label2.Text = "Income and expenses tracker ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_6639581;
            pictureBox1.Location = new Point(148, 89);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Cursor = Cursors.Hand;
            close.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.Location = new Point(753, 7);
            close.Name = "close";
            close.RightToLeft = RightToLeft.No;
            close.Size = new Size(23, 23);
            close.TabIndex = 18;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // register_showpass
            // 
            register_showpass.AutoSize = true;
            register_showpass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            register_btn.BackColor = Color.Teal;
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
            label4.Location = new Point(394, 163);
            label4.Name = "label4";
            label4.Size = new Size(55, 19);
            label4.TabIndex = 12;
            label4.Text = "EMAIL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            label1.Location = new Point(394, 273);
            label1.Name = "label1";
            label1.Size = new Size(168, 19);
            label1.TabIndex = 19;
            label1.Text = "CONFIRM PASSWORD";
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
            label6.Location = new Point(394, 102);
            label6.Name = "label6";
            label6.Size = new Size(52, 19);
            label6.TabIndex = 21;
            label6.Text = "NAME";
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 436);
            Controls.Add(register_name);
            Controls.Add(label6);
            Controls.Add(register_confirmpass);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(close);
            Controls.Add(register_showpass);
            Controls.Add(register_btn);
            Controls.Add(register_pass);
            Controls.Add(label5);
            Controls.Add(register_email);
            Controls.Add(label4);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "registerform";
            Load += registerform_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button registerlogin_btn;
        private Label label7;
        private Label label2;
        private PictureBox pictureBox1;
        private Label close;
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
    }
}