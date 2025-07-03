using financify_pt.Auth;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace financify_pt
{
    public partial class Main : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Main()
        {
            InitializeComponent();

            // Associa o evento de mover o form ao form e controles neutros
            this.MouseDown += Main_MouseDown;
            ApplyMoveFormToControls(this);

            // Associa o evento do botão fechar para garantir
            
        }

        private void ApplyMoveFormToControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                // Ignora controles interativos para não atrapalhar cliques
                if (!(c is Button) && !(c is TextBox) && !(c is CheckBox) && !(c is PictureBox))
                {
                    c.MouseDown += Main_MouseDown;
                }

                if (c.HasChildren)
                    ApplyMoveFormToControls(c);
            }
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            // Se clicar em botão, textbox, checkbox ou picturebox, NÃO move o form
            if (sender is Button || sender is TextBox || sender is CheckBox || sender is PictureBox)
                return;

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

       

        // Outros eventos do form abaixo (sem alteração) ...
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
        }

        private void btnDasboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void login_Btn_Click(object sender, EventArgs e)
        {
            FrmLogin loginform = new FrmLogin();
            loginform.Show();
        }

        private void register_Btn_Click(object sender, EventArgs e)
        {
            FrmRegister regform = new FrmRegister();
            regform.Show();
        }

        private void Start_Btn_Click(object sender, EventArgs e)
        {
            FrmLogin loginform = new FrmLogin();
            loginform.Show();
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
