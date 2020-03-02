using System;

namespace ClassLibraryRobotCleaner
{
    public class Vector
    {
        public char Directon { get; }
        public int Steps { get; }

        public Vector(char direction, int steps)
        {
            this.Directon = direction ;
            this.Steps = steps;
        }

        public static Coordinate ConvertDirectionToCoordinate(char direction)
        {

            if (direction == 'E')
            {
                return new Coordinate(1, 0);
            }
            else if (direction == 'W')
            {
                return new Coordinate(-1, 0);
            }

            else if (direction == 'N')
            {
                return new Coordinate(0, 1);
            }
            else if (direction == 'S')
            {
                return new Coordinate(0, -1);
            }
            else
            {
                return new Coordinate(0, 0);
            }
        }
    }
}