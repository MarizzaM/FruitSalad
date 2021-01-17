using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitSalad
{
    class FruitSalad 
    {

        public FruitBase[] _fruits;


        public int GetTotalCalories()
        {
            int totalCalories = 0;

            for (int i = 0; i < _fruits.Length; i++)
            {
                totalCalories += _fruits[i]._calories;
            }

            return totalCalories;
        }

        
        public bool ContainsMyFavoriteFruit()
        {
            for (int i = 0; i < _fruits.Length; i++)
            {
                if (_fruits[i].IsThisMyFvorite())
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {

            string result = "My breakfast is: \n";
            for (int i = 0; i < _fruits.Length; i++)
            {
                result = result + _fruits.ToString() + "\n";
            }
            return result;
        }

    }
}
