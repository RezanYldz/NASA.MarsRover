using NASA.MarsRover.Core.Coordinates;
using NASA.MarsRover.Core.Directions;

namespace NASA.MarsRover.Core.Rover
{
    public class Rover
    {
        public Rover()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public Coordinate CoordinateLimit { get; set; }
        public CoordinateAndDirection StartCoordinate { get; set; }
        public CoordinateAndDirection CurrentCoordinate { get; set; }
        public string Commands { get; set; }
        public override bool Equals(Object obj)
        {
            if (obj is Rover)
            {
                var that = obj as Rover;
                return this.Id == that.Id;
            }

            return false;
        }
    }
}
