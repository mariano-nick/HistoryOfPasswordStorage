using System.Security.Cryptography;
using System.Text;

namespace HistoryOfPasswordStorage_PlainTextToSha2
{
    public class MD5CredentialProcessor : ICredentialProcessor
    {
        private UsernamePasswordCombo _processedUsernamePasswordCombo;

        public UsernamePasswordCombo ProcessedCombo
        {
            get {return _processedUsernamePasswordCombo; }
            private set { _processedUsernamePasswordCombo = value; }
        }

        public void Process(UsernamePasswordCombo startingUsernamePasswordCombo)
        {
            var md5 = MD5.Create();

            md5.ComputeHash(Encoding.ASCII.GetBytes(startingUsernamePasswordCombo.Password));

            string passwordHolder = Encoding.ASCII.GetString(md5.Hash);
            string usernameHolder = startingUsernamePasswordCombo.Username;

            ProcessedCombo = new UsernamePasswordCombo(usernameHolder, passwordHolder);
        }
    }

}
