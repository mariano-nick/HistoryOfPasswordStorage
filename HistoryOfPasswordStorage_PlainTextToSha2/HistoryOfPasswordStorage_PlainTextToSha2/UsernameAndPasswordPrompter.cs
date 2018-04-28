using System;

namespace HistoryOfPasswordStorage_PlainTextToSha2
{
    public class UsernameAndPasswordPrompter
    {
        #region Private Fields

        private bool _continueGoing;
        private string _continueGoingPrompt = "Continue going? (Y/N): ";
        private string _greeting = "Greetings. ";
        private string _passwordEntered;
        private string _passwordPrompt = "Please type your password: ";
        private string _usernameEntered;
        private string _usernamePrompt = "Please type your username: ";

        #endregion Private Fields

        #region Public Properties

        public bool ContinueGoing
        {
            get { return _continueGoing; }
        }

        public UsernamePasswordCombo UsernamePasswordCombo
        {
            get { return new UsernamePasswordCombo(_usernameEntered, _passwordEntered); }
        }

        #endregion Public Properties

        #region Public Methods

        public void ClearEnteredCredentials()
        {
            _usernameEntered = String.Empty;
            _passwordEntered = String.Empty;
        }

        public void GreetAndPromptForUsernamePassword()
        {
            Console.Write(_greeting);

            Console.Write(_usernamePrompt);
            _usernameEntered = Console.ReadLine();

            Console.Write(_passwordPrompt);
            _passwordEntered = Console.ReadLine();
        }

        public void AskContinueGoing()
        {
            Console.Write(_continueGoingPrompt);
            ProcessContinueGoingInput(Console.ReadLine());
    }
        #endregion Public Methods

        #region Private Methods

        private void ProcessContinueGoingInput(string inputFromUser)   // would need to protect this var more
        {
            if (inputFromUser.ToUpper() == "Y" || inputFromUser.ToUpper() == "YES")
            {
                _continueGoing = true;
            }
            else   // would really use an if else here for unknown input
            {
                _continueGoing = false;
            }

        }

        #endregion Private Methods
    }
}
