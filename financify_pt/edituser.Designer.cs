namespace financify_pt
{
    partial class edituser
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
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            tbName = new TextBox();
            label1 = new Label();
            radioButton1 = new RadioButton();
            label3 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(177, 173);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 19;
            button2.Text = "CANCEL";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(72, 173);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 18;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(22, 123);
            label4.Name = "label4";
            label4.Size = new Size(224, 19);
            label4.TabIndex = 17;
            label4.Text = "ADD OWNER PREVILEGES ";
            label4.Click += label4_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(9, 77);
            tbName.Margin = new Padding(3, 2, 3, 2);
            tbName.Name = "tbName";
            tbName.Size = new Size(330, 23);
            tbName.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(323, 27);
            label1.TabIndex = 12;
            label1.Text = "ADD USER TO THE TRACKER";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.FlatStyle = FlatStyle.Flat;
            radioButton1.ForeColor = SystemColors.ButtonFace;
            radioButton1.Location = new Point(249, 128);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(13, 12);
            radioButton1.TabIndex = 20;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(6, 56);
            label3.Name = "label3";
            label3.Size = new Size(53, 19);
            label3.TabIndex = 21;
            label3.Text = "USER";
            // 
            // edituser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(351, 229);
            Controls.Add(label3);
            Controls.Add(radioButton1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(tbName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "edituser";
            Text = "edituser";
            Load += edituser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label4;
        private TextBox tbName;
        private Label label1;
        private RadioButton radioButton1;
        private Label label3;
    }
}