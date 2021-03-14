namespace PlutoRover.RoverCore
{
    using PlutoRover.RoverCore.Interface;

    public interface IRover
    {
        public void Move();

        public void AddMovements(char[] movements);

        public IPositionState GetCurrentState();
    }
}
