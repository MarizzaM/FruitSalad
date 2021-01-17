using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitSalad
{
    abstract class FruitBase
    {
        public string _name;
        public int _calories;

        public abstract bool IsThisMyFvorite();

        public override string ToString()
        {
            IsThisMyFvorite();
            return $" Number Of Fruit : {_name} Calories : {_calories} ";
        }
    }
}
