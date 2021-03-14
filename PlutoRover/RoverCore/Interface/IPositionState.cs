namespace PlutoRover.RoverCore.Interface
{
    public interface IPositionState
    {
        public int Y { get; set; }

        public int X { get; set; }

        public DirectionEnum Direction { get; set; }

        public string Note { get; set; }
    }
}
