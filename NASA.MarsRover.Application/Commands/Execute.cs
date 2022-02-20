
using NASA.MarsRover.Core.Coordinates;
using NASA.MarsRover.Core.Directions;
using NASA.MarsRover.Core.Rover;
using NASA.MarsRover.Core.Shared.Commands;

namespace NASA.MarsRover.Application.Commands
{
    public static class Execute
    {
        public static Rover Command(Rover input)
        {
            foreach (var item in input.Commands)
            {
                input.CurrentCoordinate = CommandRecognition(item.ToString(), input.CurrentCoordinate, input.CoordinateLimit);
            }

            Console.WriteLine("Rover current coordinate: {0} {1} {2}", input.CurrentCoordinate.CoordinateInfo.X, input.CurrentCoordinate.CoordinateInfo.Y, input.CurrentCoordinate.Direction);
            
            return input;
        }
        private static CoordinateAndDirection CommandRecognition(string Command, CoordinateAndDirection CurrentCoordinate, Coordinate CoordinateLimit)
        {
            CoordinateAndDirection newCoordinate = new();

            switch ((CommandsEnum)Enum.Parse(typeof(CommandsEnum), Command, true))
            {
                case CommandsEnum.M:
                    newCoordinate = Move.Execute(CurrentCoordinate, CoordinateLimit);
                    break;
                case CommandsEnum.L:
                    newCoordinate = TurnLeft.Execute(CurrentCoordinate);
                    break;
                case CommandsEnum.R:
                    newCoordinate = TurnRight.Execute(CurrentCoordinate);
                    break;
            }

            return newCoordinate;
        }
    }
}
