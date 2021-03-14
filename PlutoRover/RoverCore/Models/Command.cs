// <copyright file="Command.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PlutoRover.RoverCore.Models
{
    using System.Collections.Generic;

    public class Command
    {
        public string[] Movements { get; set; }

        public IList<Obstacle> Obstacles { get; set; }
    }
}
