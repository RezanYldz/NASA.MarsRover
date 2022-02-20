// See https://aka.ms/new-console-template for more information
using NASA.MarsRover.Application.Commands;
using NASA.MarsRover.Core.Commands;
using NASA.MarsRover.Core.Coordinates;
using NASA.MarsRover.Core.Directions;
using NASA.MarsRover.Core.Rover;

Console.Write("Coordinate endpoints:");
string coordinate = Console.ReadLine();

Coordinate coordinateConvert = HandleCoordinate.Execute(coordinate);

List<Rover> inputList = new();

do
{
    Rover newRover = new();

    newRover.CoordinateLimit = new Coordinate() { X = coordinateConvert.X, Y = coordinateConvert.Y };

    Console.Write("Rover coordinate starting points:");
    string startingCoordinate = Console.ReadLine();
    newRover.StartCoordinate = HandleStartingCoordinate.Execute(startingCoordinate);
    newRover.CurrentCoordinate = newRover.StartCoordinate;

    Console.Write("Command :");
    string commands = Console.ReadLine();
    newRover.Commands = HandleCommandsEnum.Execute(commands);

    inputList.Add(newRover);

    Console.WriteLine("Do you want to add another rover ? (Y/N)");
    var addRoverInput = Console.ReadLine();

    if (!addRoverInput.Equals("Y", StringComparison.InvariantCultureIgnoreCase))
    {
        break;
    }
} while (true);

for (int i = 0; i < inputList.Count(); i++)
{
    inputList[i] = Execute.Command(inputList[i]);
}

Console.ReadKey();