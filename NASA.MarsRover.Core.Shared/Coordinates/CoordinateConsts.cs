using System.Text.RegularExpressions;

namespace NASA.MarsRover.Core.Shared.Coordinates
{
    public class CoordinateConsts
    {
        public static readonly Regex CoordinatesInputRegex = new Regex(@"^\d+\s\d+$");
    }
}
