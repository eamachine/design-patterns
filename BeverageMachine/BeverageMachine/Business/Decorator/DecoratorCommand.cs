using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeverageMachine.Business.Decorator
{
    public abstract class DecoratorCommand : BeverageCommand
    {
        protected BeverageCommand _beverageCommand;
        public DecoratorCommand(BeverageCommand beverageCommand)
        {
            _beverageCommand = beverageCommand;
        }

        public void Execute()
        {
            _beverageCommand.Execute();
        }

        public bool IsCold()
        {
            return _beverageCommand.IsCold();
        }
    }
}
