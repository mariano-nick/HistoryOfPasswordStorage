namespace HistoryOfPasswordStorage_PlainTextToSha2
{
    public class PlaintextCredentialProcessor : ICredentialProcessor
    {
        public UsernamePasswordCombo ProcessedCombo { get; private set; }

        public void Process(UsernamePasswordCombo startingUsernamePasswordCombo)
        {
            ProcessedCombo = startingUsernamePasswordCombo;
        }
    }

}
