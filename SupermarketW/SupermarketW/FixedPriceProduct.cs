﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketW
{
    public class FixedPriceProduct : Product
    {

        public override decimal ValueToPay()
        {
            return Price;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tValueToPay: {ValueToPay()}";
        }
    }
}
