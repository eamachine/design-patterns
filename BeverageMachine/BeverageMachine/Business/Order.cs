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
        public void RunBeverageMachine()
        {
            foreach(var Beverage in Beverages)
            {
                if (Beverage.Equals("Cafe"))
                {
                    BeverageMachine.MakeCoffe();
                }

                if (Beverage.Equals("Chocolate"))
                {
                    BeverageMachine.MakeChocolate();
                }
            }
        }
        
    }
}
