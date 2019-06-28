using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeverageMachine.Business
{
    public class CoffeCommand : BeverageCommand
    {
        Cup cup = new Cup();
        public override void ExecuteTemplate()
        {
            cup.Fill("Coffe");
            cup.Fill("HotWatter");
        }

        public override bool IsCold()
        {
            return false;
        }
    }
}
