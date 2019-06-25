using DesignPatterns.Business.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Business
{
    public abstract class Client
    {
        public abstract DiscountStrategy GetDiscountStrategy();
    }
}
