using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeverageMachine.Business
{
    public class ChocolateCommand : BeverageCommand
    {
        Cup cup = new Cup();
        public void Execute()
        {
            cup.Fill("Cacao");
            cup.Fill("Milk");
        }

        public bool IsCold()
        {
            return true;
        }
    }
}
