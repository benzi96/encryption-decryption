using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ATBMTT.mahoa
{
    public class RSA
    {
        BigInteger p, q, e, d;
        BigInteger n;
        BigInteger fn;
        BigInteger extendedeuclid(BigInteger e, BigInteger n)
        {

            BigInteger A1 = BigInteger.One;
            BigInteger A2 = BigInteger.Zero;
            BigInteger A3 = n;

            BigInteger B1 = BigInteger.Zero;
            BigInteger B2 = BigInteger.One;
            BigInteger B3 = e;

            while (!B3.Equals(BigInteger.Zero) && !B3.Equals(BigInteger.One))
            {
                
                BigInteger q = BigInteger.Divide(A3, B3);
                BigInteger R1 = A1 - q * B1;
                BigInteger R2 = A2 - q * B2;
                BigInteger R3 = A3 - q * B3;
                A1 = B1; A2 = B2; A3 = B3;
                B1 = R1; B2 = R2; B3 = R3;
            }
            if (B3.Equals(BigInteger.Zero))
                return A3;
            if (B3.Equals(BigInteger.One))
                return B2;
            return 0;
        }

        public BigInteger nghichdaod(BigInteger e, BigInteger n)
        {

            BigInteger t = BigInteger.Zero;
            BigInteger newt = BigInteger.One;

            BigInteger r = n;
            BigInteger newr = e;
           
            while (!newr.Equals(BigInteger.Zero))
            {

                BigInteger q = BigInteger.Divide(r, newr);
                BigInteger temp = BigInteger.Subtract(t, BigInteger.Multiply(q, newt));
                t = newt;
                newt = temp;

                temp = BigInteger.Subtract(r, BigInteger.Multiply(q, newr));
                r = newr;
                newr = temp;
                
            }
            if (r > 1) return 0;
            if (t < 0) t = t + n;
            return t;
        }

        public BigInteger privatekey()
        {
            return d;
        }

        public BigInteger xuatn()
        {
            return n;
        }

        public BigInteger xuatfn()
        {
            return fn;
        }

        public void calkey(string enhap, string pnhap, string qnhap)
        {
            p = BigInteger.Parse(pnhap);
            q = BigInteger.Parse(qnhap);

            //n = p * q
            n = BigInteger.Multiply(p, q);

            //phi(n) = (p-1)*(q-1)
            fn = BigInteger.Multiply((p - 1), (q - 1));

            e = BigInteger.Parse(enhap);

            //Compute d
            d = nghichdaod(e, fn);
        }

        public string encrypt(string input, string enhap, string pnhap, string qnhap)
        {
            string ketqua = "";
            calkey(enhap, pnhap, qnhap);
            foreach (char c in input)
            {
                BigInteger a = Convert.ToInt32(c);
                BigInteger M = BigInteger.ModPow(a, e, n);
                ketqua += M.ToString() + " ";
            }
            return ketqua;
        }

        public string decrypt(string input, string dnhap, string nnhap)
        {
            string ketqua = "";
            n = BigInteger.Parse(nnhap);
            d = BigInteger.Parse(dnhap);
            string kitumahoa = "";
            foreach (char c in input)
            {
                if (c.ToString() == " ")
                {
                    BigInteger a = BigInteger.Parse(kitumahoa);
                    BigInteger M = BigInteger.ModPow(a, d, n);
                    ketqua += (char)M;
                    kitumahoa = "";
                }
                else kitumahoa += c;
            }
            return ketqua;
        }

        public string decrypt(string input, BigInteger d,BigInteger n)
        {
               BigInteger a = BigInteger.Parse(input);
               BigInteger M = BigInteger.ModPow(a, d, n);
               return M.ToString();
        }
    }
}
