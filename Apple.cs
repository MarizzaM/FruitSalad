using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitSalad
{
    class Apple : FruitBase
    {
        public string _color;
        public bool _pinkLady;

        public Apple(string color, bool pinkLady)
        {
            _color = color;
            _pinkLady = pinkLady;
        }

        public override bool IsThisMyFvorite()
        {
            if (_pinkLady)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} Color : {_color} Is Pink Lady? : {_pinkLady}";
        }
    }
}
