namespace PlutoRover.RoverCore.Provider
{
    using System.Linq;
    using ExtensionMethods;
    using PlutoRover.RoverCore.Exceptions;
    using PlutoRover.RoverCore.Interface;

    public class MovementsProvider : IMovementsProvider
    {
        private readonly IPositionState positionState;
        private readonly ILandscape landscape;

        public int X { get; set; }

        public int Y { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MovementsProvider"/> class.
        /// </summary>
        /// <param name="positionState">Position state.</param>
        /// <param name="landscape">Landscape.</param>
        public MovementsProvider(IPositionState positionState, ILandscape landscape)
        {
            this.positionState = positionState;
            this.landscape = landscape;
        }

        public void MoveForward()
        {
            this.UpdateCurrentCoordinates();
            this.Move(1);
            this.UpdateWrapBoundaries();
            this.CheckObstacles();

            this.positionState.X = this.X;
            this.positionState.Y = this.Y;
        }

        public void MoveBackward()
        {
            this.UpdateCurrentCoordinates();
            this.Move(-1);
            this.UpdateWrapBoundaries();
            this.CheckObstacles();

            this.positionState.X = this.X;
            this.positionState.Y = this.Y;
        }

        public void MoveRight()
        {
            this.positionState.Direction = this.positionState.Direction.Next();
        }

        public void MoveLeft()
        {
            this.positionState.Direction = this.positionState.Direction.Previous();
        }

        private void CheckObstacles()
        {
            var obstacle = this.landscape.Obstacles.FirstOrDefault(e => e.X == this.X && e.Y == this.Y);
            if (obstacle != null)
            {
                throw new ObstacleException($"Obstacle found:X:{obstacle.X}:Y:{obstacle.Y}");
            }
        }

        private void UpdateWrapBoundaries()
        {
            if (this.Y > Landscape.MaxY)
            {
                this.Y = Landscape.MinY;
            }
            else if (this.Y < Landscape.MinY)
            {
                this.Y = Landscape.MaxY;
            }

            if (this.X > Landscape.MaxX)
            {
                this.X = Landscape.MinX;
            }
            else if (this.X < Landscape.MinX)
            {
                this.X = Landscape.MaxX;
            }
        }

        private void UpdateCurrentCoordinates()
        {
            this.X = this.positionState.X;
            this.Y = this.positionState.Y;
        }

        private void Move(short move)
        {
            if (this.positionState.Direction.Equals(DirectionEnum.S))
            {
                this.Y += 1 * -1;
            }
            else if (this.positionState.Direction.Equals(DirectionEnum.N))
            {
                this.Y += move;
            }
            else if (this.positionState.Direction.Equals(DirectionEnum.E))
            {
                this.X += 1 * -1;
            }
            else if (this.positionState.Direction.Equals(DirectionEnum.W))
            {
                this.X += move;
            }
        }
    }
}