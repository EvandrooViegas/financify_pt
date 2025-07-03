using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace financify_pt
{
    public partial class UserPrevileges : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public UserPrevileges()
        {
            InitializeComponent();

            // Associa o evento para mover o form ao form e controles neutros
            this.MouseDown += UserPrevileges_MouseDown;
            ApplyMoveFormToControls(this);

            // Se tiver um botão para fechar (exemplo: button2), garanta que evento está ok
            button2.Click += button2_Click;
        }

        private void ApplyMoveFormToControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                // Ignora controles interativos para evitar conflito com botões etc.
                if (!(c is Button) && !(c is TextBox) && !(c is CheckBox) && !(c is PictureBox))
                {
                    c.MouseDown += UserPrevileges_MouseDown;
                }

                if (c.HasChildren)
                    ApplyMoveFormToControls(c);
            }
        }

        private void UserPrevileges_MouseDown(object sender, MouseEventArgs e)
        {
            // Se o controle é interativo, não movemos o form aqui
            if (sender is Button || sender is TextBox || sender is CheckBox || sender is PictureBox)
                return;

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Fecha ou esconde o form conforme sua lógica
            this.Hide();
        }

        private void edituser_Load(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
