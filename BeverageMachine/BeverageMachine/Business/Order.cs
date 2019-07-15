using BeverageMachine.Business.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeverageMachine.Business
{
    public class Order
    {
        List<BeverageCommand> Beverages = new List<BeverageCommand>();
        BeverageMachine BeverageMachine = new BeverageMachine();

        public Order()
        {
            Beverages.Add(new CreamCommand(new LiquorCommand(new CoffeCommand())));
        }

        //Execute order one at time
        public void AddCommands()
        {
            foreach(var Beverage in Beverages)
            {
                BeverageMachine.AddBeverage(Beverage);
            }
        }

        public void PrepareBeverage()
        {
            BeverageMachine.RunBeverageMachine();
        }
        
    }
}
