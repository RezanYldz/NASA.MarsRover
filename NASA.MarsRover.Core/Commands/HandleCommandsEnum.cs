using NASA.MarsRover.Core.Shared.Commands;

namespace NASA.MarsRover.Core.Commands
{
    public static class HandleCommandsEnum
    {
        public static string Execute(string input)
        {
            if (!CommandConsts.CommandsRegex.Match(input).Success)
                    throw new ArgumentException("Invalid command", nameof(input));

            return input;
        }
    }
}
