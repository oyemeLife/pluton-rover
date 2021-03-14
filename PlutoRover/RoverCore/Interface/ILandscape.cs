// <copyright file="ILandscape.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PlutoRover.RoverCore.Interface
{
    using System.Collections.Generic;
    using PlutoRover.RoverCore.Models;

    public interface ILandscape
    {
        public IList<Obstacle> Obstacles { get; set; }
    }
}
