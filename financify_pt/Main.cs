using financify_pt.Auth;
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
    }
}
