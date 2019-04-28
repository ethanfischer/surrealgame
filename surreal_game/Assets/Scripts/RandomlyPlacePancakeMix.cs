using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Random = System.Random;

namespace Assets.Scripts
{
    public class RandomlyPlacePancakeMix
    {
        private static RandomlyPlacePancakeMix _instance = null;
        public static RandomlyPlacePancakeMix Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RandomlyPlacePancakeMix();
                }

                return _instance;
            }
        }

        private const int PRODUCTS_PER_SHELF = 32;
        private const int SHELVES_PER_AISLE = 10;
        private const int AISLES = 4;

        private static readonly int _totalBoxes = PRODUCTS_PER_SHELF * SHELVES_PER_AISLE * AISLES; //TODO figure out a less hardcoded way of doing this
        private int _boxesCloned;
        private int _pancakeNumber = new Random(DateTime.Now.GetHashCode()).Next(0, _totalBoxes);
        private GameObject _pancakeMix = GameObject.Find("PancakeMix");

        public bool TryGetPancakeMix(out GameObject go)
        {
            go = null;
            if (_boxesCloned == _pancakeNumber)
            {
                go = _pancakeMix;
                _boxesCloned++;
                return true;
            }

            _boxesCloned++;
            return false;
        }
    }
}
