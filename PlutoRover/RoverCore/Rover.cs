namespace PlutoRover.RoverCore
{
    using System.Linq;
    using PlutoRover.RoverCore.Exceptions;
    using PlutoRover.RoverCore.Interface;
    using PlutoRover.RoverCore.Models;

    public class Rover : IRover
    {
        private readonly IMovementsProvider movementProvider;

        private readonly IPositionState positionState;

        private char[] movementCommands;

        public Rover(IMovementsProvider movementsProvider, IPositionState positionState)
        {
            this.movementProvider = movementsProvider;
            this.positionState = positionState;
        }

        public void AddMovements(char[] movements)
        {
            this.movementCommands = movements;
        }

        public IPositionState GetCurrentState()
        {
            return this.positionState;
        }

        public void Move()
        {
            try
            {
                this.movementCommands.ToList().ForEach((c) =>
                {
                    this.MoveAction(c);
                });
            }
            catch (ObstacleException e)
            {
                this.positionState.Note = e.Message;
            }
        }

        private void MoveAction(char command)
        {
            switch (command)
            {
                case (char)ActionCommand.Forward:
                    this.movementProvider.MoveForward();
                    break;

                case (char)ActionCommand.Backward:
                    this.movementProvider.MoveBackward();
                    break;

                case (char)ActionCommand.Left:
                    this.movementProvider.MoveLeft();
                    break;

                case (char)ActionCommand.Right:
                    this.movementProvider.MoveRight();
                    break;
            }
        }
    }
}
