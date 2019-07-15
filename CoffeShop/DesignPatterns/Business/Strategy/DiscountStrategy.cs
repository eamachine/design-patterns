using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Business.Strategy
{
    public interface DiscountStrategy
    {
        double Calculate(double subtotal);
    }
}
