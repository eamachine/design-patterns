using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeverageMachine.Business
{
    public class Order
    {
        List<string> Beverages = new List<string>();
        BeverageMachine BeverageMachine = new BeverageMachine();

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
