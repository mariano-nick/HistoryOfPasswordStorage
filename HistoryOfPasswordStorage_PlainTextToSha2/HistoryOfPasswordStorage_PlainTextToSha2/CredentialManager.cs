using System.Collections.Generic;

namespace HistoryOfPasswordStorage_PlainTextToSha2
{
    internal class CredentialManager
    {
        private Dictionary<string, string> _usernamePasswordDictionary = new Dictionary<string, string>();    // likely stored in a database - would be cool project to start a database server and store this here. TODO for another time

        public void AddCredential(UsernamePasswordCombo usernamePasswordCombo, ICredentialProcessor credentialProcessor)
        {
            credentialProcessor.Process(usernamePasswordCombo);
            _usernamePasswordDictionary.Add(credentialProcessor.ProcessedCombo.Username, credentialProcessor.ProcessedCombo.Password);
        }
    }


}
