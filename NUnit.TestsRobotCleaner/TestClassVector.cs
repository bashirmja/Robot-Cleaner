using ClassLibraryRobotCleaner;
using NUnit.Framework;


namespace NUnit.TestsRobotCleaner
{
    [TestFixture]
    public class TestClassVector
    {
        [Test]
        public void Vector()
        {
            Vector cv = new Vector('E', 5);

            Assert.AreEqual(cv.Directon, 'E');
            Assert.AreEqual(cv.Steps, 5);
        }



        [Test]
        public void ConvertDirectionToCoordinate()
        {
            Coordinate east = ClassLibraryRobotCleaner.Vector.ConvertDirectionToCoordinate('E');
            Coordinate west = ClassLibraryRobotCleaner.Vector.ConvertDirectionToCoordinate('W');
            Coordinate north = ClassLibraryRobotCleaner.Vector.ConvertDirectionToCoordinate('N');
            Coordinate south = ClassLibraryRobotCleaner.Vector.ConvertDirectionToCoordinate('S');

            Assert.AreEqual(east.X, 1);
            Assert.AreEqual(east.Y, 0);

            Assert.AreEqual(west.X, -1);
            Assert.AreEqual(west.Y, 0);

            Assert.AreEqual(north.X, 0);
            Assert.AreEqual(north.Y, 1);

            Assert.AreEqual(south.X, 0);
            Assert.AreEqual(south.Y, -1);

        }



    }
}
