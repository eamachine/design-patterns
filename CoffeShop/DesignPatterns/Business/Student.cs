﻿using DesignPatterns.Business.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Business
{
    public class Student : Client
    {
        public override DiscountStrategy GetDiscountStrategy()
        {
            return new StateStrategy();
        }
    }
}
