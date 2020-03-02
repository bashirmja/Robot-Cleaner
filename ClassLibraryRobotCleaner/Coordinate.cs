namespace ClassLibraryRobotCleaner
{
    public class Coordinate
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Coordinate(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static Coordinate operator +(Coordinate c1, Coordinate c2)
        {
            
            c1.Y += c2.Y;
            c1.X += c2.X;
            return c1;
        }

    }
}