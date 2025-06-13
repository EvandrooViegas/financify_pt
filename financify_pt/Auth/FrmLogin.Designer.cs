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
            panel1 = new Panel();
            signup_btn = new Button();
            label7 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            login_email = new TextBox();
            login_pass = new TextBox();
            label5 = new Label();
            login_btn = new Button();
            login_showpass = new CheckBox();
            close = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(signup_btn);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 436);
            panel1.TabIndex = 0;
            // 
            // signup_btn
            // 
            signup_btn.BackColor = Color.Teal;
            signup_btn.FlatAppearance.MouseDownBackColor = Color.Teal;
            signup_btn.FlatAppearance.MouseOverBackColor = Color.Teal;
            signup_btn.FlatStyle = FlatStyle.Flat;
            signup_btn.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_btn.ForeColor = Color.White;
            signup_btn.Location = new Point(23, 371);
            signup_btn.Margin = new Padding(3, 2, 3, 2);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(319, 30);
            signup_btn.TabIndex = 8;
            signup_btn.Text = "SIGNUP";
            signup_btn.UseVisualStyleBackColor = false;
            signup_btn.Click += signup_btn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(94, 339);
            label7.Name = "label7";
            label7.Size = new Size(168, 23);
            label7.TabIndex = 3;
            label7.Text = "REGISTER HERE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Menu;
            label2.Location = new Point(46, 183);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            label5.Location = new Point(388, 200);
            label5.Name = "label5";
            label5.Size = new Size(94, 19);
            label5.TabIndex = 5;
            label5.Text = "PASSWORD";
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.Teal;
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
            login_showpass.Location = new Point(607, 251);
            login_showpass.Margin = new Padding(3, 2, 3, 2);
            login_showpass.Name = "login_showpass";
            login_showpass.Size = new Size(139, 25);
            login_showpass.TabIndex = 8;
            login_showpass.Text = "Show password";
            login_showpass.UseVisualStyleBackColor = true;
            // 
            // close
            // 
            close.AutoSize = true;
            close.Cursor = Cursors.Hand;
            close.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.Location = new Point(748, 7);
            close.Name = "close";
            close.RightToLeft = RightToLeft.No;
            close.Size = new Size(23, 23);
            close.TabIndex = 9;
            close.Text = "X";
            close.Click += close_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 436);
            Controls.Add(close);
            Controls.Add(login_showpass);
            Controls.Add(login_btn);
            Controls.Add(login_pass);
            Controls.Add(label5);
            Controls.Add(login_email);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private TextBox login_email;
        private TextBox login_pass;
        private Label label5;
        private Button login_btn;
        private CheckBox login_showpass;
        private Label close;
        private Button signup_btn;
        private Label label7;
    }
}
