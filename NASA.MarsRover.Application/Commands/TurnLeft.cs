using NASA.MarsRover.Core.Directions;
using NASA.MarsRover.Core.Shared.Directions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASA.MarsRover.Application.Commands
{
    public static class TurnLeft
    {
        public static CoordinateAndDirection Execute(CoordinateAndDirection CurrentCoordinate)
        {
            switch ((DirectionsEnum)Enum.Parse(typeof(DirectionsEnum), CurrentCoordinate.Direction, true))
            {
                case DirectionsEnum.N:
                    CurrentCoordinate.Direction = DirectionsEnum.W.ToString();
                    break;
                case DirectionsEnum.S:
                    CurrentCoordinate.Direction = DirectionsEnum.E.ToString();
                    break;
                case DirectionsEnum.W:
                    CurrentCoordinate.Direction = DirectionsEnum.S.ToString();
                    break;
                case DirectionsEnum.E:
                    CurrentCoordinate.Direction = DirectionsEnum.N.ToString();
                    break;
            }

            return CurrentCoordinate;
        }
    }
}
