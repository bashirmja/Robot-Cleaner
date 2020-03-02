using System;
using ClassLibraryRobotCleaner;

namespace ConsoleApplicationRobotCleaner
{
    class Program
    {
        static void Main(string[] args)
        {
            RobotCleaner robot = new RobotCleaner();
            robot.NumberOfCommands=Convert.ToInt32(Console.ReadLine());

            string[] coordinate = Console.ReadLine().Split(' ');
            robot.StartingCoordinates=new Coordinate( Convert.ToInt32(coordinate[0]), Convert.ToInt32(coordinate[1]));


            if (robot.NumberOfCommands > 0)
            {
                for (int i = 1; i <= robot.NumberOfCommands; i++)
                {
                    string[] vector = Console.ReadLine().Split(' ');
                    robot.AddVector(new Vector(Convert.ToChar(vector[0]), Convert.ToInt32(vector[1])));
                }
            }

            robot.StartSession();


            Console.WriteLine("=> Cleaned: " + robot.GetNumberOfCleanedPlaces());

            Console.ReadKey();


        }
    }
}
