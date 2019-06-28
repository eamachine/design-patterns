using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeverageMachine.Business
{
    public class ChocolateCommand : BeverageCommand
    {
        Cup cup = new Cup();
        public override void ExecuteTemplate()
        {
            cup.Fill("Cacao");
            cup.Fill("Milk");
        }

        public override bool IsCold()
        {
            return true;
        }
    }
}
