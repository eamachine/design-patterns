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

        public override void ExecuteTemplate()
        {
            _beverageCommand.ExecuteTemplate();
        }

        public override bool IsCold()
        {
            return _beverageCommand.IsCold();
        }
    }
}
