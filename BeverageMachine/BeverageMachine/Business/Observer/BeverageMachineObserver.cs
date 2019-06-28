using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeverageMachine.Business
{
    public interface BeverageMachineObserver
    {
        void Alert(String Msg);
    }
}
