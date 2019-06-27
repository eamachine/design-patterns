using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeverageMachine.Business.Decorator
{
    public class LiquorCommand : DecoratorCommand
    {
        public LiquorCommand(BeverageCommand beverageCommand) : base(beverageCommand)
        {
        }

        public void Execute()
        {
            base.Execute();
            throw new NotImplementedException();
        }

        public bool IsCold()
        {
            return base.IsCold();
        }
    }
}
