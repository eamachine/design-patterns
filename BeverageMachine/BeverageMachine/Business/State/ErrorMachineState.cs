namespace BeverageMachine.Business.State
{
    public class ErrorMachineState : BeverageMachineState
    {
        private BeverageMachine _beverageMachine;

        public ErrorMachineState(BeverageMachine beverageMachine)
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