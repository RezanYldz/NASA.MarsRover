using Microsoft.VisualStudio.TestTools.UnitTesting;
using NASA.MarsRover.Application.Commands;
using NASA.MarsRover.Core.Rover;
using System.Collections.Generic;
using System.Linq;

namespace NASA.MarsRover.Test
{
    [TestClass]
    public class MarsRoverTest
    {
        #region Expected
        private Rover expected1 = new Rover()
        {
            Commands = "LMLMLMLMM",
            CoordinateLimit = new() { X = 5, Y = 5 },
            CurrentCoordinate = new()
            {
                CoordinateInfo = new() { X = 1, Y = 3 },
                Direction = "N"
            },
            StartCoordinate = new()
            {
                CoordinateInfo = new() { X = 1, Y = 2 },
                Direction = "N"
            }
        };
        private Rover expected2 = new Rover()
        {
            Commands = "LMLMLMLMM",
            CoordinateLimit = new() { X = 5, Y = 5 },
            CurrentCoordinate = new()
            {
                CoordinateInfo = new() { X = 5, Y = 1 },
                Direction = "N"
            },
            StartCoordinate = new()
            {
                CoordinateInfo = new() { X = 1, Y = 2 },
                Direction = "N"
            }
        };
        #endregion

        [TestMethod]
        public void RoverTest()
        {
            #region input
            var rover1 = new Rover()
            {
                Id= expected1.Id,
                Commands = "LMLMLMLMM",
                CoordinateLimit = new() { X = 5, Y = 5 },
                CurrentCoordinate = new()
                {
                    CoordinateInfo = new() { X = 1, Y = 2 },
                    Direction = "N"
                },
                StartCoordinate = new()
                {
                    CoordinateInfo = new() { X = 1, Y = 2 },
                    Direction = "N"
                }
            };

            var rover2 = new Rover()
            {
                Id=expected2.Id,
                Commands = "MMRMMRMRRM",
                CoordinateLimit = new() { X = 5, Y = 5 },
                CurrentCoordinate = new()
                {
                    CoordinateInfo = new() { X = 3, Y = 3 },
                    Direction = "E"
                },
                StartCoordinate = new()
                {
                    CoordinateInfo = new() { X = 3, Y = 3 },
                    Direction = "E"
                }
            };
            #endregion

            rover1 = Execute.Command(rover1);
            rover2 = Execute.Command(rover2);

            Assert.AreEqual(expected1, rover1);
            Assert.AreEqual(expected2, rover2);
        }
    }
}