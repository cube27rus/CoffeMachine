﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    abstract class CoffeDecorator: Drink
    {      
        public abstract override string GetDescription();
    }
}
