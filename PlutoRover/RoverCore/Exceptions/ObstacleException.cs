namespace PlutoRover.RoverCore.Exceptions
{
    using System;

    public class ObstacleException : Exception
    {
        public ObstacleException(string message)
            : base(message)
        {
        }
    }
}
