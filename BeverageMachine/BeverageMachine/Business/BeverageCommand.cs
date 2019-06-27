using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeverageMachine.Business
{
    public interface BeverageCommand
    {
        void Execute();

        bool IsCold();
    }
}
