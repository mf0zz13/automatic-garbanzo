using System.Text;

using static _4_2.UserAccount;

namespace _4_2
{
    public partial class LoginInstance : LoginForm
    {
        public LoginInstance()
        {
            InitializeComponent();
            LoginTxt.Visible = false;
            Username_Box.Visible = false;
            Password_Box.Visible = false;
            Login_Button.Visible = false;
            UserName_Icon.Visible = false;
            Password_Icon.Visible = false;
            CreateNewAccountTxt.Visible = false;

        }

        private UserAccount tempAccount = new UserAccount();
        private StringBuilder sb = new StringBuilder();

        private void FirstName_Box_TextChanged(object sender, EventArgs e)
        {
            if (FirstName_Box.Text != "First Name")
            {
                ValidateString(FirstName_Box, "Name");
                tempAccount.FirstName = FirstName_Box.Text;
            }
        }

        private void SubjectsBox_Enter(object sender, EventArgs e)
        {
            SubjectsBox.DataSource = Enum.GetNames(typeof(Subjects));
        }

        private void FirstName_Box_Enter(object sender, EventArgs e)
        {
            if (FirstName_Box.Text == "First Name") FirstName_Box.Clear();
        }

        private void FirstName_Box_Leave(object sender, EventArgs e)
        {
            if (FirstName_Box.Text == "")
            {
                FirstName_Box.Text = "First Name";
            }
        }

        private void LastName_Box_Enter(object sender, EventArgs e)
        {
            if (LastName_Box.Text == "Last Name") LastName_Box.Clear();
        }

        private void LastName_Box_Leave(object sender, EventArgs e)
        {
            if (LastName_Box.Text == "")
            {
                LastName_Box.Text = "Last Name";
            }
        }

        private void UserNameInput_Box_Enter(object sender, EventArgs e)
        {
            if (UserNameInput_Box.Text == "Username") UserNameInput_Box.Clear();
        }

        private void UserNameInput_Box_Leave(object sender, EventArgs e)
        {
            if (UserNameInput_Box.Text == "")
            {
                UserNameInput_Box.Text = "Username";
            }
        }

        private void PasswordInput_Box_Enter(object sender, EventArgs e)
        {
            if (PasswordInput_Box.Text == "Password") PasswordInput_Box.Clear();
        }

        private void PasswordInput_Box_Leave(object sender, EventArgs e)
        {
            if (PasswordInput_Box.Text == "")
            {
                PasswordInput_Box.Text = "Password";
            }
        }

        private void ValidateString(TextBox box, string boxName)
        {
            foreach (char character in box.Text)
            {
                if (!Char.IsLetter(character))
                {
                    MessageBox.Show($"{boxName} can only contain letters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sb.Append(box.Text);
                    sb.Remove(sb.Length - 1, 1);
                    box.Text = sb.ToString();
                    sb.Clear();
                    box.SelectionStart = box.Text.Length;

                }
            }
        }

        private void LastName_Box_TextChanged(object sender, EventArgs e)
        {
            if (LastName_Box.Text != "Last Name")
            {
                ValidateString(LastName_Box, "Name");
                tempAccount.LastName = LastName_Box.Text;
            }
        }

        private void UserNameInput_Box_TextChanged(object sender, EventArgs e)
        {
            CharNotPermittedTxt.Visible = false;

            if (UserNameInput_Box.Text != "Username" || !String.IsNullOrEmpty(UserNameInput_Box.Text))
            {
                foreach (char character in UserNameInput_Box.Text)
                {
                    if (!Char.IsLetterOrDigit(character))
                    {
                        CharNotPermittedTxt.Visible = true;
                    }
                    else
                    { tempAccount.UserName = UserNameInput_Box.Text; }
                }
            }
        }

        private void PasswordInput_Box_TextChanged(object sender, EventArgs e)
        {
            tempAccount.Password = PasswordInput_Box.Text;
        }

        private void SubjectsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Subjects subject;
            bool parseStatus = Enum.TryParse(SubjectsBox.SelectedValue.ToString(), out subject);
            if (parseStatus) tempAccount.Subject = subject;
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Create_Button_Click_1(object sender, EventArgs e)
        {
            AddAccount($"{tempAccount.FirstName} {tempAccount.LastName}", tempAccount.Subject, tempAccount.UserName, tempAccount.Password);
            this.Close();
        }
    }
}
