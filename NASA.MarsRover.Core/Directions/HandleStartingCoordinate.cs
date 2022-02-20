using NASA.MarsRover.Core.Coordinates;
using NASA.MarsRover.Core.Shared.Coordinates;
using NASA.MarsRover.Core.Shared.Directions;

namespace NASA.MarsRover.Core.Directions
{
    public static class HandleStartingCoordinate
    {
        public static CoordinateAndDirection Execute(string input)
        {
            if (!DirectionConsts.RoverCoordinatesInputRegex.Match(input).Success)
                throw new ArgumentException("The rover's starting coordinate format is incorrect", nameof(input));

            string[] splitArray = input.Split(" ");

            CoordinateAndDirection coordinateOutput = new()
            {
                CoordinateInfo = new()
                {
                    X = Convert.ToInt32(splitArray[(int)CoordinatesEnum.X]),
                    Y = Convert.ToInt32(splitArray[(int)CoordinatesEnum.Y])
                },
                Direction = splitArray[2]
            };

            return coordinateOutput;
        }
    }
}
