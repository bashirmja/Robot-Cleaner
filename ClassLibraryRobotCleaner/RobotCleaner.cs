using System;
using System.Collections.Generic;

namespace ClassLibraryRobotCleaner
{
    public class RobotCleaner
    {
        public int NumberOfCommands { get; set; }
        public Coordinate StartingCoordinates { get; set; }

        private Coordinate _currentCoordinates;
        private List<Vector> _vectorsList = new List<Vector>();
        private List<Coordinate> _cleanedCoordinates = new List<Coordinate>();


        public void AddVector(Vector vector)
        {
            _vectorsList.Add(vector);
        }

        public int GetNumberOfVectors()
        {
            return _vectorsList.Count;
        }

        public Vector GetOneVector(int v)
        {
            return _vectorsList[v];
        }
        public Coordinate GetCurrentCoordinate()
        {
            return _currentCoordinates;
        }

        public int GetNumberOfCleanedPlaces()
        {
            return _cleanedCoordinates.Count;
        }
        public void StartSession()
        {

            GoToTheCoordinate(StartingCoordinates);
            DoCleaningCurrentPosition();

            for (int i = 0; i < NumberOfCommands; i++)
            {
                Vector v = _vectorsList[i];
                for (int j = 0; j < v.Steps; j++)
                {
                    GoToTheCoordinate(Vector.ConvertDirectionToCoordinate(v.Directon) + _currentCoordinates);
                    DoCleaningCurrentPosition();
                }
            }
        }

        private void DoCleaningCurrentPosition()
        {
            Coordinate ccc = _currentCoordinates;
            if (_cleanedCoordinates.Exists(l => l.X == ccc.X && l.Y == ccc.Y) == false)
            {
                //Robot Cleaning Right Now
                _cleanedCoordinates.Add(ccc);
            }
        }

        private void GoToTheCoordinate(Coordinate coordinate)
        {
            _currentCoordinates = coordinate;
        }

    }
}
