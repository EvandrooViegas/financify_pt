namespace financify_pt
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            FrmRegister regform = new FrmRegister();

            regform.Show();

            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            if (login_email.Text == "" || login_pass.Text == "")
            {
               MessageBox.Show("Email or pass cannot be empty");
               return;
             }   


            try
                {
                BLL.User.Login(login_email.Text, login_pass.Text);
                MessageBox.Show("Loggin Successfull");
            }   catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
