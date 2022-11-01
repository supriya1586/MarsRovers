using MarsRovers.MarsRoversCommands;

namespace MarsRovers.Models
{
    public class MarsRoversModel
    {
        private DirectionsModel direction = DirectionsModel.North;
        private CoordinatesModel coordinate = CoordinatesModel.getInstance(0, 0);
        private string[] commandarray;

        private IEnumerable<MarsRoversCommand> commandList = new MarsRoversCommand[0];

        public string OriginalPosition => $"{coordinate.X},{coordinate.Y},{direction.Value}";


        public void Execute(string commands)
        {
            SplitCommand(commands);
            SetCommands();
            ExecuteCommands();
        }

        public void SplitCommand(string command)
        {
            commandarray = command.Split("|");
            string[] coordinatesanddirections = commandarray[0].Split(" ");

            coordinate =  CoordinatesModel.getInstance(Convert.ToInt32(coordinatesanddirections[0]), Convert.ToInt32(coordinatesanddirections[1]));
            switch (coordinatesanddirections[2])
            {
                case "N":
                    direction = DirectionsModel.North;
                    break;
                case "E":
                    direction = DirectionsModel.East;
                    break;
                case "W":
                    direction = DirectionsModel.West;
                    break;
                case "S":
                    direction = DirectionsModel.South;
                    break;
            }

        }
        private void SetCommands()
        {
            var commandFactory = new CommandFactory(this);
           commandList = commandFactory.Create(commandarray[1]);
        }

        private void ExecuteCommands()
        {
            foreach (var command in commandList)
                command.Execute();
        }
        public void RotateRight()
        {
            direction = direction.RotateRight();
        }

        public void RotateLeft()
        {
            direction = direction.RotateLeft();
        }

        public void Move()
        {
            coordinate = direction.Move(coordinate, direction);

        }


    }
}
