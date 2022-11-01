namespace MarsRovers.Models
{
    public class DirectionsModel
    {
        public static readonly DirectionsModel North = new DirectionsModel("N", "W", "E");
        public static readonly DirectionsModel East = new DirectionsModel("E", "N", "S");
        public static readonly DirectionsModel South = new DirectionsModel("S", "E", "W");
        public static readonly DirectionsModel West = new DirectionsModel("W", "S", "N");

       public static readonly List<DirectionsModel> directions = new List<DirectionsModel> {
            North, East, South, West
        };

        public string Value { get; }
        private readonly string leftValue;
        private readonly string rightValue;
        private DirectionsModel(string value, string leftValue, string rightValue)
        {
            this.Value = value;
            this.leftValue = leftValue;
            this.rightValue = rightValue;
        }

        public DirectionsModel RotateRight()
        {
            return directions.First(direction => direction.Value == this.rightValue);
        }

        public DirectionsModel RotateLeft()
        {
            return directions.First(direction => direction.Value == this.leftValue);
        }

        public CoordinatesModel Move(CoordinatesModel coordinates, DirectionsModel direction)
        {
            var y = coordinates.Y;
            var x = coordinates.X;

            if (direction == DirectionsModel.North)
                y = y + 1;

            if (direction == DirectionsModel.East)
                x = x + 1;

            if (direction == DirectionsModel.South)
                y = y - 1;

            if (direction == DirectionsModel.West)
                x = x - 1;

            return CoordinatesModel.getInstance(x, y);
        }
    }
}
