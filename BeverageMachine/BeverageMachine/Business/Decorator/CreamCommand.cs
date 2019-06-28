using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeverageMachine.Business.Decorator
{
    public class CreamCommand : DecoratorCommand
    {
        public CreamCommand(BeverageCommand beverageCommand) : base(beverageCommand)
        {
        }

        public override void ExecuteTemplate()
        {
            AddCream();
            base.ExecuteTemplate();
        }

        private void AddCream()
        {
            throw new NotImplementedException();
        }

    }
}
