using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATBMTT.mahoa
{
    class binhphuonglientiep
    {
        public long modulo(int a, int b, int n)
        {
            long x = 1, y = a;
            while (b > 0)
            {
                if (b % 2 == 1)
                {
                    x = (x * y) % n;
                }
                y = (y * y) % n; // squaring the base
                b /= 2;
            }
            return x % n;
        }
    }
}
