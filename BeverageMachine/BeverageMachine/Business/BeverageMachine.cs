using BeverageMachine.Business.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeverageMachine.Business
{
    public class BeverageMachine
    {
        List<BeverageCommand> Cold = new List<BeverageCommand>();

        List<BeverageCommand> Hot = new List<BeverageCommand>();

        List<BeverageMachineObserver> Observers = new List<BeverageMachineObserver>();

        BeverageMachineState MachineState;

        public BeverageMachine()
        {
            Observers.Add(new UIAlertObserver());
            Observers.Add(new MobileAlertObserver());
            MachineState = new ReadyMachineState(this);
        }

        public void AddBeverage(BeverageCommand Beverage)
        {
            MachineState = MachineState.AddBeverage(Beverage);
        }

        //Preparar bevidas
        public void RunBeverageMachine()
        {
            MachineState = MachineState.RunBeverageMachine();
        }
        public void Clean()
        {
            MachineState = MachineState.Clean();
        }
        public void Reset()
        {
            MachineState = MachineState.Reset();
        }
        public void Alert(String Msg)
        {
            foreach (var Observer in Observers)
            {
                Observer.Alert(Msg);
            }
        }

        public void CleanBase()
        {
            Alert("cleaning");
        }
        public void ResetBase()
        {
            Alert("reseting");
        }

        public void AddBeverageBase(BeverageCommand Beverage)
        {
            if (Beverage.IsCold())
            {
                Cold.Add(Beverage);
            }
            else
            {
                Hot.Add(Beverage);
            }
        }
        public void RunBeverageMachineBase()
        {
            foreach (var Beverage in Cold)
            {
                Beverage.Execute();
                Alert("Added");
                Cold.Remove(Beverage);
            }

            foreach (var Beverage in Hot)
            {
                Beverage.Execute();
                Alert("Added");
                Cold.Remove(Beverage);
            }
        }
    }
}