using MarsRovers.Models;

namespace MarsRovers.MarsRoversCommands
{
    public class CommandFactory
    {
        private  Dictionary<char, MarsRoversCommand> Moves;

        public CommandFactory(MarsRoversModel rover)
        {
            Moves = new Dictionary<char, MarsRoversCommand>
            {
                { 'R', new RotateRightCommand(rover) },
                { 'L', new RotateLeftCommand(rover) },
                { 'M', new MoveCommand(rover) },
            };
        }

        public IEnumerable<MarsRoversCommand> Create(string commands)
        {
            var commandList = new List<MarsRoversCommand>();
            foreach (var command in commands.ToCharArray())
            {
                if (Moves.ContainsKey(command))
                    commandList.Add(Moves[command]);
                else
                    throw new Exception("command not known");
            }

            return commandList;
        }
    }
}
