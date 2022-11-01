using MarsRovers.Models;

namespace MarsRovers.MarsRoversCommands
{
    public abstract  class MarsRoversCommand
    {
        public MarsRoversModel MarsRoversModel;
        protected MarsRoversCommand(MarsRoversModel rover)
        {
            MarsRoversModel = rover;
        }
        public abstract void Execute();
    }

   
}
