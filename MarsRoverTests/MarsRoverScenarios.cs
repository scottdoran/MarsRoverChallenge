using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MarsRoverTest
{
    [TestClass]
    public class MarsRoverScenarios
    {
        [TestMethod]
        public void Scenario1()
        {
            Position initialPosition = new Position(0, 2, "E");
            Crater crater = new Crater(5, 5);
            Rover rover = new Rover(initialPosition);
            Position expectedPosition = new Position(4, 1, "N");

            rover.ExecuteMovementInstructions("FLFRFFFRFFRR", crater);

            Assert.AreEqual(expectedPosition.X, rover.CurrentPosition.X);
            Assert.AreEqual(expectedPosition.Y, rover.CurrentPosition.Y);
            Assert.AreEqual(expectedPosition.Direction, rover.CurrentPosition.Direction);
            Assert.AreEqual(0, rover.NoOfScuffs);
        }

        [TestMethod]
        public void Scenario2()
        {
            Position initialPosition = new Position(4, 4, "S");
            Crater crater = new Crater(5, 5);
            Rover rover = new Rover(initialPosition);
            Position expectedPosition = new Position(0, 1, "W");

            rover.ExecuteMovementInstructions("LFLLFFLFFFRFF", crater);

            Assert.AreEqual(expectedPosition.X, rover.CurrentPosition.X);
            Assert.AreEqual(expectedPosition.Y, rover.CurrentPosition.Y);
            Assert.AreEqual(expectedPosition.Direction, rover.CurrentPosition.Direction);
            Assert.AreEqual(1, rover.NoOfScuffs);
        }

        [TestMethod]
        public void Scenario3()
        {
            Position initialPosition = new Position(2, 2, "W");
            Crater crater = new Crater(5, 5);
            Rover rover = new Rover(initialPosition);
            Position expectedPosition = new Position(2, 2, "N");

            rover.ExecuteMovementInstructions("FLFLFLFRFRFRFRF", crater);

            Assert.AreEqual(expectedPosition.X, rover.CurrentPosition.X);
            Assert.AreEqual(expectedPosition.Y, rover.CurrentPosition.Y);
            Assert.AreEqual(expectedPosition.Direction, rover.CurrentPosition.Direction);
            Assert.AreEqual(0, rover.NoOfScuffs);
        }

        [TestMethod]
        public void Scenario4()
        {
            Position initialPosition = new Position(1, 3, "N");
            Crater crater = new Crater(5, 5);
            Rover rover = new Rover(initialPosition);
            Position expectedPosition = new Position(0, 0, "S");

            rover.ExecuteMovementInstructions("FFLFFLFFFFF", crater);

            Assert.AreEqual(expectedPosition.X, rover.CurrentPosition.X);
            Assert.AreEqual(expectedPosition.Y, rover.CurrentPosition.Y);
            Assert.AreEqual(expectedPosition.Direction, rover.CurrentPosition.Direction);
            Assert.AreEqual(3, rover.NoOfScuffs);
        }
    }
}

