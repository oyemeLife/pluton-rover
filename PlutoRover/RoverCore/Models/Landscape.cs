namespace PlutoRover.RoverCore
{
    using System.Collections.Generic;
    using PlutoRover.RoverCore.Interface;
    using PlutoRover.RoverCore.Models;

    public class Landscape : ILandscape
    {
        public const int MinY = 0;

        public const int MinX = 0;

        public const int MaxY = 10;

        public const int MaxX = 10;

        public IList<Obstacle> Obstacles { get; set; } = new List<Obstacle>();
    }
}
