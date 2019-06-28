using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeverageMachine.Business
{
    public abstract class BeverageCommand
    {
        public void Execute()
        {
            CleanCup();
            AddStirrer();
            ExecuteTemplate();
        }

        private void CleanCup()
        {
            throw new NotImplementedException();
        }

        private void AddStirrer()
        {
            throw new NotImplementedException();
        }

        public abstract void ExecuteTemplate();

        public abstract bool IsCold();
    }
}
