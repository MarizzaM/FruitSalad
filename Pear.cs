using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitSalad
{
    class Pear : FruitBase
    {
        public override bool IsThisMyFvorite()
        {
            return true;
        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}
