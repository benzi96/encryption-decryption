using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATBMTT.mahoa
{
    class Extended_Euclid
    {
        public long Extended_GCD(long a, long b)
        {
            long a1 = 1;
            long a2 = 0;
            long a3 = a;
            long b1 = 0;
            long b2 = 1;
            long b3 = b;
            while (b3 != 0 && b3 != 1)
            {
                long q = a3 / b3;
                long r1 = a1 - q * b1;
                long r2 = a2 - q * b2;
                long r3 = a3 - q * b3;
                a1 = b1; a2 = b2; a3 = b3;
                b1 = r1; b2 = r2; b3 = r3;
            }
            if (b3 == 0)
            {
                return a3;
            }
            if (b3 == 1)
            {
                return b2;
            }
            else
            {
                return 0;
            }
        }
    }
}
