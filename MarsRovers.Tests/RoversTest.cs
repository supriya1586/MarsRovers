using MarsRovers.Models;
using NUnit.Framework;


namespace MarsRovers.Tests
{
    public class Tests
    {
        private MarsRoversModel rovers;
        [SetUp]
        public void Setup()
        {
            rovers = new MarsRoversModel();
        }

        [Test]

        [TestCase("0 0 E|LL", "0,0,W")]
        [TestCase("0 0 E|LLL", "0,0,S")]
        public void LeftMove(string commands, string expectedPosition)
        {
            rovers.Execute(commands);
            Assert.That(rovers.OriginalPosition, Is.EqualTo(expectedPosition));
        }

        [TestCase("1 2 E|RR", "1,2,W")]
        [TestCase("1 2 E|RRR", "1,2,N")]
        public void RightMove(string commands, string expectedPosition)
        {
            rovers.Execute(commands);
            Assert.That(rovers.OriginalPosition, Is.EqualTo(expectedPosition));
        }


        [TestCase("1 2 N|LMLMLMLMM", "1,3,N")]
        public void Command1(string commands, string expectedPosition)
        {
            rovers.Execute(commands);
            Assert.That(rovers.OriginalPosition, Is.EqualTo(expectedPosition));
        }

        [TestCase("3 3 E|MMRMMRMRRM", "5,1,E")]
        public void Command2(string commands, string expectedPosition)
        {
            rovers.Execute(commands);
            Assert.That(rovers.OriginalPosition, Is.EqualTo(expectedPosition));
        }
    }
}