// <copyright file="Obstacle.cs" company="Andrejs Aleksejevs">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PlutoRover.RoverCore.Models
{
    using PlutoRover.RoverCore.Interface;

    public class Obstacle : IObstacle
    {
        public int X { get; set; }

        public int Y { get; set; }
    }
}
