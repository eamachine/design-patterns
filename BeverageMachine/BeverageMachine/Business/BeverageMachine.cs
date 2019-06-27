﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeverageMachine.Business
{
    public class BeverageMachine
    {
        List<BeverageCommand> Cold = new List<BeverageCommand>();

        List<BeverageCommand> Hot = new List<BeverageCommand>();

        public void AddBeverage(string Beverage)
        {
            if (Beverage.Equals("Cafe"))
            {
                Cold.Add(new CoffeCommand());
            }

            if (Beverage.Equals("Chocolate"))
            {
                Hot.Add(new ChocolateCommand());
            }
        }

        public void RunBeverageMachine()
        {
            foreach(var Beverage in Cold)
            {
                Beverage.Execute();
                Cold.Remove(Beverage);
            }

            foreach (var Beverage in Hot)
            {
                Beverage.Execute();
                Cold.Remove(Beverage);
            }
        }
    }
}