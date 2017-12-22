using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBMTT.mahoa
{
    public class A51
    {
        public byte[] toBytes;
        public string msg;
        public int msglength;
        public int[] s;

        public int[] x = new int[19];
        public int[] y = new int[22];
        public int[] z = new int[23];

        #region chung
        public int[] doithanhchuoibit(string input)
        {
            toBytes = Encoding.ASCII.GetBytes(input);
            msg = "";
            foreach (byte b in toBytes)
            {
                msg = msg + Convert.ToString(b, 2).PadLeft(8, '0');
            }
            msglength = msg.Length;
            s = new int[msglength];
            return s;
        }

        string doisanghex(string kq)
        {

            string a = "";
            StringBuilder result = new StringBuilder(kq.Length / 8 + 1);
            for (int i = 0; i < kq.Length; i++)
            {
                a += kq[i];
                if (a.Length == 8)
                {
                    Console.WriteLine(a);

                    result.AppendFormat("{0:X2}", Convert.ToByte(a, 2));
                    a = "";
                }
            }
            return result.ToString();
        }

        string hexsangbinary(string hexstring)
        {
            string binarystring = String.Join(String.Empty,
            hexstring.Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
            return binarystring;
        }

        string binarytochar(string b)
        {
            string a = "";
            string kq = "";
            for (int i = 0; i < b.Length; i++)
            {
                a += b[i];
                if (a.Length == 8)
                {
                    kq += (char)Convert.ToInt32(a, 2);
                    a = "";
                }
            }
            return kq;
        }

        #endregion

        public void gankhoa(string str)
        {
            for (int i = 0; i < 19; i++)
                x[i] = Int16.Parse(str[i].ToString());

            for (int i = 0; i < 22; i++)
                y[i] = Int16.Parse(str[i + 19].ToString());

            for (int i = 0; i < 23; i++)
                z[i] = Int16.Parse(str[i + 19 + 22].ToString());

        }

        int maj(int x, int y, int z)
        {
            int m = 0;
            if (x == y || x == z)
                m = x;
            else if (y == z)
                m = y;
            return m;
        }

        void quayx()
        {
            int t = x[13] ^ x[16] ^ x[17] ^ x[18];
            for (int i = 18; i > 0; i--)
                x[i] = x[i - 1];
            x[0] = t;
        }

        void quayy()
        {
            int t = y[20] ^ y[21];
            for (int i = 21; i > 0; i--)
                y[i] = y[i - 1];
            y[0] = t;
        }

        void quayz()
        {
            int t = z[7] ^ z[20] ^ z[21] ^ z[22];
            for (int i = 22; i > 0; i--)
                z[i] = z[i - 1];
            z[0] = t;
        }

        void calarrays()
        {
            int m = 0;
            for(int j=0; j<msglength; j++)
            {
                m = maj(x[8], y[10], z[10]);
                if (x[8] == m) quayx();
                if (y[10] == m) quayy();
                if (z[10] == m) quayz();
                s[j] = x[18] ^ y[21] ^ z[22];
            }
        }

        public string encrypt(string input, string key)
        {
            doithanhchuoibit(input);
            gankhoa(key);
            int[] enc = new int[msglength];
            string kq = "";
            calarrays();
            for (int i = 0; i < msglength; i++)
            {
                enc[i] = Int16.Parse(msg[i].ToString()) ^ s[i];
                kq += enc[i];
            }
            return doisanghex(kq);
        }

        public string decrypt(string input, string key)
        {
            input = hexsangbinary(input);
            gankhoa(key);
            msg = input;
            msglength = msg.Length;
            s = new int[msglength];
            calarrays();
            string kq = "";
            int[] dec = new int[msglength];
            for (int i = 0; i < msglength; i++)
            {
                dec[i] = Int16.Parse(msg[i].ToString()) ^ s[i];
                kq += dec[i];
            }
            return binarytochar(kq);
        }

    }
}
