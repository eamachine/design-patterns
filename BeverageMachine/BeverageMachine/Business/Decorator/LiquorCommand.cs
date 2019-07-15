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

        public override void ExecuteTemplate()
        {
            AddLiquor();
            base.Execute();
        }

        private void AddLiquor()
        {
            throw new NotImplementedException();
        }
    }
}
