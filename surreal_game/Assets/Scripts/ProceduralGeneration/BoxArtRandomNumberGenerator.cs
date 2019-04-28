using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.ProceduralGeneration
{

    public static class BoxArtRandomNumberGenerator
    {
        private static Random _random = new Random();

        public static int Next(int min, int max)
        {
            return _random.Next(min, max);
        }

    }
}
