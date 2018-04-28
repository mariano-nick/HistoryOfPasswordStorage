using System.Security.Cryptography;
using System.Text;

namespace HistoryOfPasswordStorage_PlainTextToSha2
{
    public class SHA1CredentialProcessor : ICredentialProcessor
    {
        private UsernamePasswordCombo _processedUsernamePasswordCombo;

        public UsernamePasswordCombo ProcessedCombo
        {
            get { return _processedUsernamePasswordCombo; }
            private set { _processedUsernamePasswordCombo = value; }
        }

        public void Process(UsernamePasswordCombo startingUsernamePasswordCombo)
        {
            var sha1 = SHA1.Create();
            sha1.ComputeHash(Encoding.ASCII.GetBytes(startingUsernamePasswordCombo.Password));

            string passwordHolder = Encoding.ASCII.GetString(sha1.Hash);
            string usernameHolder = startingUsernamePasswordCombo.Username;

            ProcessedCombo = new UsernamePasswordCombo(usernameHolder, passwordHolder);
        }
    }

}
