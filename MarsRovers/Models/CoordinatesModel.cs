namespace MarsRovers.Models
{
    public class CoordinatesModel
    {
        public int X { get; set; }
        public int Y { get; set; }
        public CoordinatesModel(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static CoordinatesModel getInstance(int x, int y)
        {
            return new CoordinatesModel(x, y);
        }

    }
}
