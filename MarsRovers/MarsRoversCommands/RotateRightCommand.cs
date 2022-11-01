using MarsRovers.Models;

namespace MarsRovers.MarsRoversCommands
{
    public class RotateRightCommand : MarsRoversCommand
    {
        public RotateRightCommand(MarsRoversModel rover) : base(rover)
        { }

        public override void Execute()
        {
            MarsRoversModel.RotateRight();
        }
    }
}
