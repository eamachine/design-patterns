using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeverageMachine.Business.State
{
    public class CleaningMachineState : BeverageMachineState
    {
        BeverageMachine _beverageMachine;
        public CleaningMachineState(BeverageMachine beverageMachine)
        {
            _beverageMachine = beverageMachine;
        }

        public BeverageMachineState AddBeverage(BeverageCommand Beverage)
        {
            throw new NotImplementedException();
        }

        public BeverageMachineState Clean()
        {
            throw new NotImplementedException();
        }

        public BeverageMachineState Reset()
        {
            throw new NotImplementedException();
        }

        public BeverageMachineState RunBeverageMachine()
        {
            throw new NotImplementedException();
        }
    }
}
