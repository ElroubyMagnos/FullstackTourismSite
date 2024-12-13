namespace BoardingDashboard
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (Username.Text == "admin" && Password.Text == "159357")
            {
                Hide();
                new Dashboard().ShowDialog();
                Application.Exit();
            }
        }

        private void Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Enter_Click(sender, e);
            }
        }
    }
}
