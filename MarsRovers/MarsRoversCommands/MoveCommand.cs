using MarsRovers.Models;

namespace MarsRovers.MarsRoversCommands
{
    public class MoveCommand : MarsRoversCommand
    {
        public MoveCommand(MarsRoversModel rover) : base(rover)
        { }

        public override void Execute()
        {
            MarsRoversModel.Move();
        }
    }
}
