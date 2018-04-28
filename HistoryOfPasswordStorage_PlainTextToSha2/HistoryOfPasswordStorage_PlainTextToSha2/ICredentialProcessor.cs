using System.Security.Cryptography;    // do these using statements come through when implementing the interface?
using System.Text;


namespace HistoryOfPasswordStorage_PlainTextToSha2
{
    public interface ICredentialProcessor    // probably should be a parent class, not an interface. I'm too far down this hole to turn back nowwww
    {
        UsernamePasswordCombo ProcessedCombo { get; }
        void Process(UsernamePasswordCombo startingUsernamePasswordCombo);
    }

}
