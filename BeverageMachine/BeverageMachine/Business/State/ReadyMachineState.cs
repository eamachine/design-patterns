using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeverageMachine.Business.State
{
    public class ReadyMachineState : BeverageMachineState
    {
        BeverageMachine _beverageMachine;
        public ReadyMachineState(BeverageMachine beverageMachine)
        {
            _beverageMachine = beverageMachine;
        }

        public BeverageMachineState AddBeverage(BeverageCommand Beverage)
        {
            _beverageMachine.AddBeverageBase(Beverage);
            return this;
        }

        public BeverageMachineState Clean()
        {
            _beverageMachine.CleanBase();
            return new CleaningMachineState(_beverageMachine);
        }

        public BeverageMachineState Reset()
        {
            _beverageMachine.ResetBase();
            return new ErrorMachineState(_beverageMachine);
        }

        public BeverageMachineState RunBeverageMachine()
        {
            _beverageMachine.RunBeverageMachineBase();
            return new WorkingMachineState(_beverageMachine);
        }
    }
}
