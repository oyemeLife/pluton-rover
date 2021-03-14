// <copyright file="IMovementsProvider.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PlutoRover.RoverCore.Interface
{
    public interface IMovementsProvider
    {
        public void MoveForward();

        public void MoveBackward();

        public void MoveLeft();

        public void MoveRight();
    }
}
