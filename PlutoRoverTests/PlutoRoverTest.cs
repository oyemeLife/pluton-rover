using System.Collections.Generic;
using NUnit.Framework;
using PlutoRover.RoverCore;
using PlutoRover.RoverCore.Models;
using PlutoRover.RoverCore.Provider;

namespace PlutoRoverTests
{
    public class PlutoRoverTest
    {
        public Rover Rover { get; private set; }

        private static readonly object[] TestCasesWithObstacles =
        {
           new object[]{
               new char[] { 'F', 'F','F','B','F'},
               new List<Obstacle> {
                 new Obstacle() { X = 10, Y = 10,},
                 new Obstacle() { X = 0, Y = 2},
                },
                "X:0:Y:1|N|Obstacle found:X:0:Y:2"
            }
        };

        private static readonly object[] TestCasesExtented =
        {
           new object[]{
               new char[] { 'F', 'F', 'B','F','F','F','F' },
               new List<Obstacle> {
                 new Obstacle() { X = 10, Y = 10,},
                 new Obstacle() { X = 5, Y = 2},
                },
               "X:0:Y:5|N|"
            }
        };

        private static readonly object[] TestCasesWrappedMinBoundaries =
        {
           new object[]{
               new char[] { 'F', 'B' , 'B', 'B','B'},
               new List<Obstacle> {
                 new Obstacle() { X = 10, Y = 10,},
                 new Obstacle() { X = 5, Y = 1},
                },
               "X:0:Y:8|N|"
            }
        };

        private static readonly object[] TestCasesWrappedMaxBoundaries =
        {
           new object[]{
               new char[] { 'F','F','F','F','F','F','F','F','F','F','F','F',},
               new List<Obstacle> {
                 new Obstacle() { X = 5, Y = 3 },
                },
               "X:0:Y:1|N|"
            }
        };

        private static readonly object[] TestCasesWrappedMaxBoundariesUltraMax =
     {
           new object[]{
               new char[] { 'F','F','F','F','F','F','F','F','F','F','F','F','R','R','F','F','F','F','F','B'},
               new List<Obstacle> {
                 new Obstacle() { X = 5, Y = 3},
                 new Obstacle() { X = 1, Y = 2},
                 new Obstacle() { X = 0, Y =8 },
                 new Obstacle() { X = 5, Y =7},
                },
               "X:0:Y:7|N|Obstacle found:X:0:Y:8"
            }
        };


        [Test]
        [TestCaseSource("TestCasesWithObstacles")]
        [TestCaseSource("TestCasesExtented")]
        [TestCaseSource("TestCasesWrappedMinBoundaries")]
        [TestCaseSource("TestCasesWrappedMaxBoundaries")]
        [TestCaseSource("TestCasesWrappedMaxBoundariesUltraMax")]

        public void ValdatedkMultpleTestCases(char[] data, List<Obstacle> obstacles, string output)
        {
            var positionStateRepo = new PositionState();
            var movementProvider = new MovementsProvider(positionStateRepo, new Landscape() { Obstacles = obstacles });

            var roverObject = new Rover(movementProvider, positionStateRepo);
            roverObject.AddMovements(data);
            roverObject.Move();
            Assert.AreEqual(roverObject.GetCurrentState().ToString(), output);
        }

    }
}