using NASA.MarsRover.Core.Directions;
using NASA.MarsRover.Core.Shared.Directions;

namespace NASA.MarsRover.Application.Commands
{
    public static class TurnRight
    {
        public static CoordinateAndDirection Execute(CoordinateAndDirection CurrentCoordinate)
        {
            switch ((DirectionsEnum)Enum.Parse(typeof(DirectionsEnum), CurrentCoordinate.Direction, true))
            {
                case DirectionsEnum.N:
                    CurrentCoordinate.Direction = DirectionsEnum.E.ToString();
                    break;
                case DirectionsEnum.S:
                    CurrentCoordinate.Direction = DirectionsEnum.W.ToString();
                    break;
                case DirectionsEnum.W:
                    CurrentCoordinate.Direction = DirectionsEnum.N.ToString();
                    break;
                case DirectionsEnum.E:
                    CurrentCoordinate.Direction = DirectionsEnum.S.ToString();
                    break;
            }

            return CurrentCoordinate;
        }
    }
}
