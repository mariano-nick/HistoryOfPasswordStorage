using System;

namespace HistoryOfPasswordStorage_PlainTextToSha2
{
    class Program
    {
        static void Main(string[] args)
        {
            var passwordPrompt = new UsernameAndPasswordPrompter();
            var credentialManager = new CredentialManager();

            passwordPrompt.GreetAndPromptForUsernamePassword();
            credentialManager.AddCredential(passwordPrompt.UsernamePasswordCombo, new PlaintextCredentialProcessor());
            passwordPrompt.ClearEnteredCredentials();

            passwordPrompt.GreetAndPromptForUsernamePassword();
            credentialManager.AddCredential(passwordPrompt.UsernamePasswordCombo, new MD5CredentialProcessor());
            passwordPrompt.ClearEnteredCredentials();

            passwordPrompt.GreetAndPromptForUsernamePassword();
            credentialManager.AddCredential(passwordPrompt.UsernamePasswordCombo, new SHA1CredentialProcessor());
            passwordPrompt.ClearEnteredCredentials();

            passwordPrompt.AskContinueGoing();
        }
    }

}
