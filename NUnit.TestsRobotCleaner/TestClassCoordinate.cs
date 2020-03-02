using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryRobotCleaner;

namespace NUnit.TestsRobotCleaner
{
    [TestFixture]
    public class TestClassCoordinate
    {
        [Test]
        public void Coordinate()
        {
            Coordinate c = new Coordinate(1, 5);

            Assert.AreEqual(c.X, 1);
            Assert.AreEqual(c.Y, 5);
        }

        [Test]
        public void SumOfTwoCoordinate()
        {
            Coordinate c1 = new Coordinate(1, 5);
            Coordinate c2 = new Coordinate(1, 2);
            Coordinate cSum = c1 + c2;

            Assert.AreEqual(cSum.X, 2);
            Assert.AreEqual(cSum.Y, 7);

        }


    }
}
