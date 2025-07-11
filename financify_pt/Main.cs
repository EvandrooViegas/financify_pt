﻿using financify_pt.Auth;
using Guna.UI2.WinForms;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace financify_pt
{
    public partial class Main : Form
    {
        // Constantes para arrastar o form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Main()
        {
            InitializeComponent();

            // Permite mover o formulário clicando em áreas neutras
            this.MouseDown += Main_MouseDown;
        }

        private void Main_Load(object sender, EventArgs e)
        {

            if (Globals.UserId == 0)
            {
                //NAO LOGADO


                guna2Button2.Hide();
                guna2Button1.Hide();
                btnsettings.Hide();

            }
            else
            {
                login_Btn.Hide();
                register_Btn.Hide();

                btnDasboard.Hide();
                btnGoals.Hide();
                btnPlanning.Hide();
                btnEducation.Hide();
            }
            // Aplica o evento MouseDown em todos os controles neutros do form
            ApplyMoveFormToControls(this);
        }

        private void ApplyMoveFormToControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (!(c is Button) && !(c is TextBox) && !(c is PictureBox) && !(c is CheckBox) && !(c is DataGridView))
                {
                    c.MouseDown += Main_MouseDown;
                }

                if (c.HasChildren)
                {
                    ApplyMoveFormToControls(c);
                }
            }
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // ✅ Fecha o app corretamente


        // Outros eventos do form...

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            // ação do botão Start
        }

        private void btnDasboard_Click(object sender, EventArgs e)
        {

            if (Globals.UserId == 0)
            {
                MessageBox.Show("You need to be logged in to access the dashboard");
                return;
            }
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void login_Btn_Click(object sender, EventArgs e)
        {
            if (Globals.UserId != 0)
            {
                // User already logged in, open Dashboard
                Dashboard dashboard = new Dashboard();
                this.Hide(); // Hide current form
                dashboard.Show(); // Show dashboard
                return;
            }

            using (FrmLogin loginform = new FrmLogin())
            {
                var result = loginform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
            }
        }


        private void register_Btn_Click(object sender, EventArgs e)
        {

            FrmRegister regform = new FrmRegister();
            regform.Show();
        }

        private void Start_Btn_Click(object sender, EventArgs e)
        {
            if (Globals.UserId != 0)
            {
                Dashboard dashboard = new Dashboard();
                this.Hide();
                dashboard.Show();
                return;
            }

            FrmLogin loginform = new FrmLogin();
            var result = loginform.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Lógica futura
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            var form = new EditUser();
            form.ShowDialog();
        }
    }
}
