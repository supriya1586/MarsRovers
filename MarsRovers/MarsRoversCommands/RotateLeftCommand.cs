using MarsRovers.Models;

namespace MarsRovers.MarsRoversCommands
{
    public class RotateLeftCommand : MarsRoversCommand
    {
        public RotateLeftCommand(MarsRoversModel rover) : base(rover)
        { }

        public override void Execute()
        {
            MarsRoversModel.RotateLeft();
        }

    }
}
