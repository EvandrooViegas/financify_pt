using financify_pt.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace financify_pt
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            // Associa o evento do botão fechar para garantir
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

       

        // Outros eventos do form abaixo (sem alteração) ...
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
