using System.Text.RegularExpressions;

namespace NASA.MarsRover.Core.Shared.Directions
{
    public class DirectionConsts
    {
        public static readonly Regex RoverCoordinatesInputRegex = new Regex(@"^\d+\s\d+\s[NSWE]$");
    }
}
