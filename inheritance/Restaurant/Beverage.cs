﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Beverage : Product
    {
        public Beverage(string name, decimal price, double mililiters)
            : base(name, price)
        {
            this.Mililites = mililiters;
        }
        public double Mililites { get; set; }
    }
}