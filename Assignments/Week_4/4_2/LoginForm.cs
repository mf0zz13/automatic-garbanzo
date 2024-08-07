namespace _4_2
{
    public partial class LoginForm : Form
    {
        public LoginForm LoginInstance;
        private string _userName;
        private string _password;

        public LoginForm()
        {

            InitializeComponent();
        }

        public Dictionary<string, (UserAccount.Subjects subject, string name, string password)> TeacherAccounts = new Dictionary<string, (UserAccount.Subjects subject, string name, string password)>();

        private void CreateNewAccountTxt_MouseHover(object sender, EventArgs e)
        {
            // Setting the color of text to CornflowerBlue when hovered over.
            CreateNewAccountTxt.ForeColor = Color.FromArgb(100, 149, 237);
        }

        private void CreateNewAccountTxt_MouseLeave(object sender, EventArgs e)
        {
            // Setting the color to DarkGrey when the mouse is moved away.
            CreateNewAccountTxt.ForeColor = Color.FromArgb(169, 169, 169);
            CreateNewAccountTxt.Font = new Font(CreateNewAccountTxt.Font, FontStyle.Regular);
        }

        private void CreateNewAccountTxt_MouseClick(object sender, MouseEventArgs e)
        {
            // Making the text bold when clicked on.
            CreateNewAccountTxt.Font = new Font(CreateNewAccountTxt.Font, FontStyle.Bold);

            LoginInstance createNewAccount = new LoginInstance();
            this.Hide();
            createNewAccount.LoginInstance = this;
            createNewAccount.ShowDialog();
            this.Show();
        }

        private void Username_Box_Enter(object sender, EventArgs e)
        {
            Username_Box.Clear();
        }

        private void Username_Box_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Username_Box.Text))
            {
                Username_Box.Text = "Username";
            }
        }

        private void Password_Box_Enter(object sender, EventArgs e)
        {
            Password_Box.Clear();
        }

        private void Password_Box_Leave(object sender, EventArgs e)
        {   if (String.IsNullOrEmpty(Password_Box.Text)) Password_Box.Text = "Password";
        }

        private void Username_Box_TextChanged(object sender, EventArgs e)
        {
            _userName = Username_Box.Text;
        }

        public void AddAccount(string name, UserAccount.Subjects subject, string username, string password)
        {
            LoginInstance.TeacherAccounts.Add(username, (subject, name, password));

        }

        private void Password_Box_TextChanged(object sender, EventArgs e)
        {
            _password = Password_Box.Text;
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (TeacherAccounts.ContainsKey(_userName))
            {
                if (TeacherAccounts[_userName].password == _password)
                {
                    this.Hide();
                    TeacherPortal tp = new TeacherPortal();
                    tp.Show();
                }
            }
        }
    }
}
