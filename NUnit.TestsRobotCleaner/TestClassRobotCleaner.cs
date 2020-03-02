using ClassLibraryRobotCleaner;
using NUnit.Framework;


namespace NUnit.TestsRobotCleaner
{
    [TestFixture]
    public class TestClassRobotCleaner
    {
        [Test]
        public void NumberOfCommands()
        {
            RobotCleaner crc = new RobotCleaner();
            crc.NumberOfCommands = 2;

            Assert.AreEqual(crc.NumberOfCommands, 2);
        }


        [Test]
        public void StartingCoordinates()
        {
            RobotCleaner crc = new RobotCleaner();
            Coordinate cc = new Coordinate(2, 3);
            crc.StartingCoordinates = cc;

            Assert.AreEqual(cc.X, 2);
            Assert.AreEqual(cc.Y, 3);
        }

        [Test]
        public void AddVectors()
        {
            RobotCleaner crc = new RobotCleaner();
            crc.AddVector(new Vector('E', 5));
            crc.AddVector(new Vector('S', 3));

            Assert.AreEqual(crc.GetNumberOfVectors(), 2);
        }

        [Test]
        public void GetOneVector()
        {
            RobotCleaner crc = new RobotCleaner();
            crc.AddVector(new Vector('E', 5));
            crc.AddVector(new Vector('S', 3));
            crc.AddVector(new Vector('W', 2));

            Assert.AreEqual(crc.GetOneVector(0).Directon, 'E');
            Assert.AreEqual(crc.GetOneVector(0).Steps, 5);

            Assert.AreEqual(crc.GetOneVector(1).Directon, 'S');
            Assert.AreEqual(crc.GetOneVector(1).Steps, 3);

            Assert.AreEqual(crc.GetOneVector(2).Directon, 'W');
            Assert.AreEqual(crc.GetOneVector(2).Steps, 2);

        }



        [Test]
        public void GetCurrentCoordinate()
        {
            RobotCleaner crc = new RobotCleaner();
            crc.NumberOfCommands = 0;
            crc.StartingCoordinates = new Coordinate(5, 4);
            crc.StartSession();

            Assert.AreEqual(crc.GetCurrentCoordinate().X, 5);
            Assert.AreEqual(crc.GetCurrentCoordinate().Y, 4);
        }


        [Test]
        public void GetNumberOfCleanedPlaces()
        {
            RobotCleaner crc = new RobotCleaner();
            crc.NumberOfCommands = 0;
            crc.StartingCoordinates = new Coordinate(5, 4);
            crc.StartSession();

            Assert.AreEqual(crc.GetNumberOfCleanedPlaces(), 1);
        }


        [Test]
        public void GetCurrentCoordinate_WithOneCommand()
        {
            RobotCleaner crc = new RobotCleaner();
            crc.NumberOfCommands = 1;
            crc.StartingCoordinates = new Coordinate(0, 0);
            crc.AddVector(new Vector('E', 1));
            crc.StartSession();

            Assert.AreEqual(crc.GetCurrentCoordinate().X, 1);
            Assert.AreEqual(crc.GetCurrentCoordinate().Y, 0);
        }

        [Test]
        public void GetCurrentCoordinate_WithTwoCommand()
        {
            RobotCleaner crc = new RobotCleaner();
            crc.NumberOfCommands = 2;
            crc.StartingCoordinates = new Coordinate(0, 0);
            crc.AddVector(new Vector('E', 1));
            crc.AddVector(new Vector('N', 2));
            crc.StartSession();

            Assert.AreEqual(crc.GetCurrentCoordinate().X, 1);
            Assert.AreEqual(crc.GetCurrentCoordinate().Y, 2);
        }

        [Test]
        public void GetNumberOfCleanedPlaces_withTwoCommands()
        {
            RobotCleaner crc = new RobotCleaner();
            crc.NumberOfCommands = 2;
            crc.StartingCoordinates = new Coordinate(5, 4);
            crc.AddVector(new Vector('E', 5));
            crc.AddVector(new Vector('N', 6));
            crc.StartSession();

            Assert.AreEqual(crc.GetNumberOfCleanedPlaces(), 12);
        }

        [Test]
        public void GetNumberOfCleanedPlaces_withTwoCommandsOverlap()
        {
            RobotCleaner crc = new RobotCleaner();
            crc.NumberOfCommands = 2;
            crc.StartingCoordinates = new Coordinate(5, 4);
            crc.AddVector(new Vector('E', 5));
            crc.AddVector(new Vector('W', 6));
            crc.StartSession();

            Assert.AreEqual(crc.GetNumberOfCleanedPlaces(), 7);
        }

    }

}