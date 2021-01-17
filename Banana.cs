using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitSalad
{
    class Banana : FruitBase
    {
        public bool _hasBlackSpots;
        public bool _isGreen;
        public float _size;

        public Banana(bool hasBlackSpots, bool isGreen, float size)
        {
            _hasBlackSpots = hasBlackSpots;
            _isGreen = isGreen;
            _size = size;
        }

        public override bool IsThisMyFvorite()
        {
            if (_hasBlackSpots || _isGreen)
            {
                return false;
            } else
            {
                return true;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} Has Black Spots? : {_hasBlackSpots} Is Green? : {_isGreen} Size: {_size}";
        }

    }
}
