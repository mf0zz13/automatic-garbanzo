namespace _4_2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void CreateNewAccountTxt_MouseHover(object sender, EventArgs e)
        {
            // Setting the color of text to CornflowerBlue when hovered over.
            CreateNewAccountTxt.ForeColor = Color.FromArgb(100, 149, 237);
        }

        private void CreateNewAccountTxt_MouseLeave(object sender, EventArgs e)
        {
            // Setting the color to DarkGrey when the mouse is moved away.
            CreateNewAccountTxt.ForeColor = Color.FromArgb(169, 169, 169);
        }

        private void CreateNewAccountTxt_MouseClick(object sender, MouseEventArgs e)
        {
            // Making the text bold when clicked on.
            CreateNewAccountTxt.Font = new Font(CreateNewAccountTxt.Font, FontStyle.Bold);
        }
    }
}
