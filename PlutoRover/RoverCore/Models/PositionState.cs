// <copyright file="PositionState.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PlutoRover.RoverCore.Models
{
    using System.Text.Json.Serialization;
    using PlutoRover.RoverCore.Interface;

    public class PositionState : IPositionState
    {
        /// <inheritdoc/>
        public int X { get; set; } = 0;

        /// <inheritdoc/>
        public int Y { get; set; } = 0;

        /// <inheritdoc/>
        [JsonConverter(typeof(JsonStringEnumConverter))]

        public DirectionEnum Direction { get; set; } = DirectionEnum.N;

        /// <inheritdoc/>
        public string Note { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"X:{this.X}:Y:{this.Y}|{this.Direction}|{this.Note}";
        }
    }
}
