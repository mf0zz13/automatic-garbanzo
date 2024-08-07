namespace _4_2
{
    public class UserAccount
    {
        #region Fields
        public enum Subjects { Math, English, Science, Social_Studies }

        private string _firstName;
        private string _lastName;
        private Subjects _subject;
        private string _userName;
        private string _password;
        #endregion

        #region Constructors
        public UserAccount()
        {
            _firstName = "";
            _lastName = "";
            _userName = "";
            _password = "";
        }

        public UserAccount(string firstName, string lastName, Subjects subject, string userName, string password)
        {
            _firstName = firstName;
            _lastName = lastName;
            _subject = subject;
            _userName = userName;
            _password = password;
        }
        #endregion

        #region Properties
        public string FirstName
        { get => _firstName; set => _firstName = value; }

        public string LastName
        { get => _lastName; set => _lastName = value; }

        public Subjects Subject
        { get => _subject; set => _subject = value; }

        public string UserName
        { get => _userName; set => _userName = value; }

        public string Password
        { get => _password; set => _password = value; }
        #endregion
    }
}
