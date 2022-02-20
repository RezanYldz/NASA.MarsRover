using NASA.MarsRover.Core.Coordinates;
using NASA.MarsRover.Core.Directions;
using NASA.MarsRover.Core.Shared.Directions;

namespace NASA.MarsRover.Application.Commands
{
    public static class Move
    {
        public static CoordinateAndDirection Execute(CoordinateAndDirection Coordinate, Coordinate CoordinateLimit)
        {
            switch ((DirectionsEnum)Enum.Parse(typeof(DirectionsEnum), Coordinate.Direction, true))
            {
                case DirectionsEnum.N:
                    if (Coordinate.CoordinateInfo.Y < CoordinateLimit.Y)
                        Coordinate.CoordinateInfo.Y += 1;
                    break;
                case DirectionsEnum.S:
                    if (Coordinate.CoordinateInfo.Y > 0)
                        Coordinate.CoordinateInfo.Y -= 1;
                    break;
                case DirectionsEnum.W:
                    if (Coordinate.CoordinateInfo.X > 0)
                        Coordinate.CoordinateInfo.X -= 1;
                    break;
                case DirectionsEnum.E:
                    if (Coordinate.CoordinateInfo.X < CoordinateLimit.X)
                        Coordinate.CoordinateInfo.X += 1;
                    break;
            }

            return Coordinate;
        }
    }
}
