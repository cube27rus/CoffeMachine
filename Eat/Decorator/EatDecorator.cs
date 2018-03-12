using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    abstract class EatDecorator : Eat
    {

        public abstract override string GetDescription();
    }
}
