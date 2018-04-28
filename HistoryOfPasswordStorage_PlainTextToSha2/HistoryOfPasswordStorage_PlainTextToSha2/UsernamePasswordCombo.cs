namespace HistoryOfPasswordStorage_PlainTextToSha2
{
    public class UsernamePasswordCombo
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public UsernamePasswordCombo(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
