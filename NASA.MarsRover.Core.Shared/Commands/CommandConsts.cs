using System.Text.RegularExpressions;

namespace NASA.MarsRover.Core.Shared.Commands
{
    public class CommandConsts
    {
        public static readonly Regex CommandsRegex = new Regex(@"^[LRM]+$");
    }
}
