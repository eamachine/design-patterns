namespace BeverageMachine.Business.State
{
    public class WorkingMachineState : BeverageMachineState
    {
        private BeverageMachine _beverageMachine;

        public WorkingMachineState(BeverageMachine beverageMachine)
        {
            _beverageMachine = beverageMachine;
        }

        public BeverageMachineState AddBeverage(BeverageCommand Beverage)
        {
            throw new System.NotImplementedException();
        }

        public BeverageMachineState Clean()
        {
            throw new System.NotImplementedException();
        }

        public BeverageMachineState Reset()
        {
            throw new System.NotImplementedException();
        }

        public BeverageMachineState RunBeverageMachine()
        {
            throw new System.NotImplementedException();
        }
    }
}