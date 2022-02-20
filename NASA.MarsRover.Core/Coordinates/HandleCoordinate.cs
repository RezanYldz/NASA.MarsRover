using NASA.MarsRover.Core.Shared.Coordinates;

namespace NASA.MarsRover.Core.Coordinates
{
    public static class HandleCoordinate
    {
        public static Coordinate Execute(string input)
        {
            if (!CoordinateConsts.CoordinatesInputRegex.Match(input).Success)
                throw new ArgumentException("The coordinate format is incorrect.", nameof(input));

            string[] splitArray = input.Split(" ");

            Coordinate coordinate = new()
            {
                X = Convert.ToInt32(splitArray[(int)CoordinatesEnum.X]),
                Y = Convert.ToInt32(splitArray[(int)CoordinatesEnum.Y])
            };

            return coordinate;
        }
    }
}
