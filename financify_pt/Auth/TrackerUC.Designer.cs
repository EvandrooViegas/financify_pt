namespace financify_pt.Auth
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
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(90, 37);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(24, 61);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(362, 117);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(299, 184);
            button1.Name = "button1";
            button1.Size = new Size(97, 33);
            button1.TabIndex = 2;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(196, 184);
            button2.Name = "button2";
            button2.Size = new Size(97, 33);
            button2.TabIndex = 3;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            // 
            // TrackerUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Name = "TrackerUC";
            Size = new Size(409, 231);
            Load += TrackerUC_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
    }
}
