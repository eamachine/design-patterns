using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeverageMachine.Business.State
{
    public interface BeverageMachineState
    {
        BeverageMachineState AddBeverage(BeverageCommand Beverage);
        BeverageMachineState RunBeverageMachine();
        BeverageMachineState Reset();
        BeverageMachineState Clean();
    }
}
