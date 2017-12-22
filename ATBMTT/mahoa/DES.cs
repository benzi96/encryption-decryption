using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBMTT.mahoa
{
    public class DES
    {
        #region sbox
        private static byte[] sbox1 = {
    14, 4, 13, 1, 2, 15, 11, 8, 3, 10, 6, 12, 5, 9, 0, 7,
    0, 15, 7, 4, 14, 2, 13, 1, 10, 6, 12, 11, 9, 5, 3, 8,
    4, 1, 14, 8, 13, 6, 2, 11, 15, 12, 9, 7, 3, 10, 5, 0,
    15, 12, 8, 2, 4, 9, 1, 7, 5, 11, 3, 14, 10, 0, 6, 13
};

        private static byte[] sbox2 = {
    15, 1, 8, 14, 6, 11, 3, 4, 9, 7, 2, 13, 12, 0, 5, 10,
    3, 13, 4, 7, 15, 2, 8, 14, 12, 0, 1, 10, 6, 9, 11, 5,
    0, 14, 7, 11, 10, 4, 13, 1, 5, 8, 12, 6, 9, 3, 2, 15,
    13, 8, 10, 1, 3, 15, 4, 2, 11, 6, 7, 12, 0, 5, 14, 9
};

        private static byte[] sbox3 = {
    10, 0, 9, 14, 6, 3, 15, 5, 1, 13, 12, 7, 11, 4, 2, 8,
    13, 7, 0, 9, 3, 4, 6, 10, 2, 8, 5, 14, 12, 11, 15, 1,
    13, 6, 4, 9, 8, 15, 3, 0, 11, 1, 2, 12, 5, 10, 14, 7,
    1, 10, 13, 0, 6, 9, 8, 7, 4, 15, 14, 3, 11, 5, 2, 12
};

        private static byte[] sbox4 = {
    7, 13, 14, 3, 0, 6, 9, 10, 1, 2, 8, 5, 11, 12, 4, 15,
    13, 8, 11, 5, 6, 15, 0, 3, 4, 7, 2, 12, 1, 10, 14, 9,
    10, 6, 9, 0, 12, 11, 7, 13, 15, 1, 3, 14, 5, 2, 8, 4,
    3, 15, 0, 6, 10, 1, 13, 8, 9, 4, 5, 11, 12, 7, 2, 14
};

        private static byte[] sbox5 = {
    2, 12, 4, 1, 7, 10, 11, 6, 8, 5, 3, 15, 13, 0, 14, 9,
    14, 11, 2, 12, 4, 7, 13, 1, 5, 0, 15, 10, 3, 9, 8, 6,
    4, 2, 1, 11, 10, 13, 7, 8, 15, 9, 12, 5, 6, 3, 0, 14,
    11, 8, 12, 7, 1, 14, 2, 13, 6, 15, 0, 9, 10, 4, 5, 3
};

        private static byte[] sbox6 = {
    12, 1, 10, 15, 9, 2, 6, 8, 0, 13, 3, 4, 14, 7, 5, 11,
    10, 15, 4, 2, 7, 12, 9, 5, 6, 1, 13, 14, 0, 11, 3, 8,
    9, 14, 15, 5, 2, 8, 12, 3, 7, 0, 4, 10, 1, 13, 11, 6,
    4, 3, 2, 12, 9, 5, 15, 10, 11, 14, 1, 7, 6, 0, 8, 13
};

        private static byte[] sbox7 = {
    4, 11, 2, 14, 15, 0, 8, 13, 3, 12, 9, 7, 5, 10, 6, 1,
    13, 0, 11, 7, 4, 9, 1, 10, 14, 3, 5, 12, 2, 15, 8, 6,
    1, 4, 11, 13, 12, 3, 7, 14, 10, 15, 6, 8, 0, 5, 9, 2,
    6, 11, 13, 8, 1, 4, 10, 7, 9, 5, 0, 15, 14, 2, 3, 12
};

        private static byte[] sbox8 = {
    13, 2, 8, 4, 6, 15, 11, 1, 10, 9, 3, 14, 5, 0, 12, 7,
    1, 15, 13, 8, 10, 3, 7, 4, 12, 5, 6, 11, 0, 14, 9, 2,
    7, 11, 4, 1, 9, 12, 14, 2, 0, 6, 10, 13, 15, 3, 5, 8,
    2, 1, 14, 7, 4, 10, 8, 13, 15, 12, 9, 0, 3, 5, 6, 11
};
        #endregion

        #region hoanvi
                int[] hoanvikhoitao = {57, 49, 41, 33, 25, 17, 9, 1,
                                       59, 51, 43, 35, 27, 19, 11, 3,
                                       61, 53, 45, 37, 29, 21, 13, 5,
                                       63, 55, 47, 39, 31, 23, 15, 7,
                                       56, 48, 40, 32, 24, 16,  8, 0,
                                       58, 50, 42, 34, 26, 18, 10, 2,
                                       60, 52, 44, 36, 28, 20, 12, 4,
                                       62, 54, 46, 38, 30, 22, 14, 6};

                int[] hoanviketthuc =  {39,  7, 47, 15, 55, 23, 63, 31,
                                            38,  6, 46, 14, 54, 22, 62, 30,
                                            37,  5, 45, 13, 53, 21, 61, 29,
                                            36,  4, 44, 12, 52, 20, 60, 28,
                                            35,  3, 43, 11, 51, 19, 59, 27,
                                            34,  2, 42, 10, 50, 18, 58, 26,
                                            33,  1, 41,  9, 49, 17, 57, 25,
                                            32,  0, 40,  8, 48, 16, 56, 24};

                int[] expandi =  {31,  0,  1,  2,  3,  4,
                                     3,  4,  5,  6,  7,  8,
                                     7,  8, 9, 10, 11, 12,
                                    11, 12, 13, 14, 15, 16,
                                    15, 16, 17, 18, 19, 20,
                                    19, 20, 21, 22, 23, 24,
                                    23, 24, 25, 26, 27, 28,
                                    27, 28, 29, 30, 31,  0};
                int[] pboxi = {15,  6, 19, 20,
                                            28, 11, 27, 16,
                                             0, 14, 22, 25,
                                             4, 16, 30, 9,
                                             1,  7, 23, 13,
                                            31, 26,  2,  8,
                                            18, 12, 29,  5,
                                            21, 10,  3, 24};

                int[] hoanvikhoa = {57, 49,  41, 33,  25,  17,  9,
                                         1, 58,  50, 42,  34,  26, 18,
                                        10,  2,  59, 51,  43,  35, 27,
                                        19, 11,   3, 60,  52,  44, 36,
                                        63, 55,  47, 39,  31,  23, 15,
                                         7, 62,  54, 46,  38,  30, 22,
                                        14,  6,  61, 53,  45,  37, 29,
                                        21, 13,   5, 28,  20,  12,  4};

                int[] compressi =    {14, 17, 11, 24,  1,  5,
                                         3, 28, 15,  6, 21, 10,
                                        23, 19, 12,  4, 26,  8,
                                        16,  7, 27, 20, 13,  2,
                                        41, 52, 31, 37, 47, 55,
                                        30, 40, 51, 45, 33, 48,
                                        44, 49, 39, 56, 34, 53,
                                        46, 42, 50, 36, 29, 32};

        #endregion

        #region chung
        string tobitstring(string input)
        {
            byte[] toBytes = Encoding.ASCII.GetBytes(input);
            msg = "";
            foreach (byte b in toBytes)
            {
                msg = msg + Convert.ToString(b, 2).PadLeft(8, '0');
            }
            input = msg;
            msg = "";
            return input;
        }

        public string getbitstring(string input)
        {
            msg = input;
            return msg;
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
            for(int i=0;i<b.Length;i++)
            {
                a += b[i];
                if(a.Length==8)
                {
                    kq += (char)Convert.ToInt32(a, 2);
                    a = "";
                }
            }
            return kq;
        }
        #endregion

        #region des

        string msg;
        string keylr;
        string[] L = new string[17];
        string[] R = new string[17];
        string[] KL = new string[17];
        string[] KR = new string[17];

        string xor(string l, string f, int n)
        {
            string r = "";
            for (int i = 0; i < n; i++)
            {
                int xor;
                xor = Convert.ToInt16(l[i]) ^ Convert.ToInt16(f[i]);
                r = r + xor;
            }
            return r;
        }

        //dich trai 1 bit
        public string dichtrai(string a, int n)
        {
            string kq = "";
            string t = "";
            t = t + a[0];
            for (int i = 0; i < n; i++)
            {
                kq = kq + a[i + 1];
            }
            kq = kq + t;
            return kq;
        }

        //khoi tao khóa trái 28 bit, khóa phải 28 bit
        public void keyL0R0(string str)
        {
            KL[0] = str.Substring(0, 28);
            KR[0] = str.Substring(28, 28);
        }

        //khoi tao chia 64 bit thành trái 32 bit, phải 32 bit
        public void inputL0R0(string str)
        {
            L[0] = str.Substring(0, 32);
            R[0] = str.Substring(32, 32);
        }

        public void taokhoacho16vong()
        {
            for (int i = 0; i < 16; i++)
            {
                KL[i + 1] = dichtrai(KL[i], 27);
                KR[i + 1] = dichtrai(KR[i], 27);

                //dịch trái khóa trái, khóa phải 2 lần nếu i không = 0 1 8 15
                if (i != 0 && i != 1 && i != 8 && i != 15)
                {
                    KL[i + 1] = dichtrai(KL[i + 1], 27);
                    KR[i + 1] = dichtrai(KR[i + 1], 27);
                }
            }
        }

        //mở rộng R 32 bit lên 48 bit
        string expand(string r)
        {
            string expandr = "";
            for (int i = 0; i < 48; i++)
                expandr = expandr + r[expandi[i]];
            return expandr;
        }

        //nén khóa 56 bit bit xuống 48 bit
        string compress(string K)
        {
            string compressk = "";
            for (int i = 0; i < 48; i++)
                compressk = compressk + K[compressi[i] - 1];
            return compressk;
        }

        //lay expand của R 48 bit xor voi compress của khóa 48 bit
        string exorc(string e, string c)
        {
            int[] xor = new int[48];
            string x = "";
            for (int i = 0; i < 48; i++)
            {
                xor[i] = Convert.ToInt16(e[i]) ^ Convert.ToInt16(c[i]);
                x = x + xor[i];
            }
            return x;
        }

        //tính toán vị trí của 8 chuỗi 6 bit(48 bit) trên sbox
        string cal6bit(string xor)
        {
            string x = "";
            x = x + xor[0] + xor[5] + xor[1] + xor[2] + xor[3] + xor[4];
            return x;
        }

        //48 bit => 32 bit
        string sbox(string xor)
        {
            string x = "";
            string s1 = cal6bit(xor.Substring(0, 6));
            string s2 = cal6bit(xor.Substring(6, 6));
            string s3 = cal6bit(xor.Substring(12, 6));
            string s4 = cal6bit(xor.Substring(18, 6));
            string s5 = cal6bit(xor.Substring(24, 6));
            string s6 = cal6bit(xor.Substring(30, 6));
            string s7 = cal6bit(xor.Substring(36, 6));
            string s8 = cal6bit(xor.Substring(42, 6));

            int a = Convert.ToInt32(s1, 2);
            int b = Convert.ToInt32(s2, 2);
            int c = Convert.ToInt32(s3, 2);
            int d = Convert.ToInt32(s4, 2);
            int e = Convert.ToInt32(s5, 2);
            int f = Convert.ToInt32(s6, 2);
            int g = Convert.ToInt32(s7, 2);
            int h = Convert.ToInt32(s8, 2);

            x = x + Convert.ToString(sbox1[a], 2).PadLeft(4, '0');
            x = x + Convert.ToString(sbox2[b], 2).PadLeft(4, '0');
            x = x + Convert.ToString(sbox3[c], 2).PadLeft(4, '0');
            x = x + Convert.ToString(sbox4[d], 2).PadLeft(4, '0');
            x = x + Convert.ToString(sbox5[e], 2).PadLeft(4, '0');
            x = x + Convert.ToString(sbox6[f], 2).PadLeft(4, '0');
            x = x + Convert.ToString(sbox7[g], 2).PadLeft(4, '0');
            x = x + Convert.ToString(sbox8[h], 2).PadLeft(4, '0');
            
            return x;
        }

        //hoán vị pbox của 32 bit
        string pbox(string s)
        {
            string p = "";
            for (int i = 0; i < 32; i++)
                p = p + s[pboxi[i]];
            return p;
        }

        public string encrypt(string input, string key)
        {
            key = hexsangbinary(key);
            input = tobitstring(input);
            
            //hoán vị khi bắt đầu
            for (int i = 0; i < 64; i++)
            {
                msg = msg + input[hoanvikhoitao[i]];
            }
            
            //hoán vị khóa từ 64 bit còn 56 bit
            for (int i = 0; i < 56; i++)
            {
                keylr = keylr + key[hoanvikhoa[i] - 1];
            }
            inputL0R0(msg);
            keyL0R0(keylr);
            taokhoacho16vong();
            for (int i = 0; i < 16; i++)
            {
                L[i + 1] = R[i];

                string expandr = "", compressk = "";
                expandr = expand(R[i]);
                string k = KL[i + 1] + KR[i + 1];
                
                compressk = compress(k);

                //tính F
                string f = pbox(sbox(exorc(expandr, compressk)));

                R[i + 1] = xor(L[i], f, 32);
            }

            string kqtam = L[16] + R[16];
            string kq = "";
            //hoán vị khi kết thúc
            for (int i = 0; i < 64; i++)
            {
                kq = kq + kqtam[hoanviketthuc[i]];
            }
            return doisanghex(kq);
        }

        //khoi tao chia 64 bit thành trái 32 bit, phải 32 bit
        public void inputL16R16(string str)
        {
            L[16] = str.Substring(0, 32);
            R[16] = str.Substring(32, 32);
        }

        public string decrypt(string input, string key)
        {
            input = hexsangbinary(input);
            key = hexsangbinary(key);
            msg = input;
            StringBuilder sb = new StringBuilder(msg);
            
            //hoán vị ket thuc nguoc lai
            for (int i = 0; i < 64; i++)
            {
                sb[hoanviketthuc[i]] = input[i];
            }
            msg = sb.ToString();

            //hoán vị khóa từ 64 bit còn 56 bit
            for (int i = 0; i < 56; i++)
            {
                keylr = keylr + key[hoanvikhoa[i] - 1];
            }

            inputL16R16(msg);
            keyL0R0(keylr);
            taokhoacho16vong();
            for (int i = 16; i > 0; i--)
            {
                R[i - 1] = L[i];

                string expandr = "", compressk = "";
                expandr = expand(R[i - 1]);

                string k = KL[i] + KR[i];

                compressk = compress(k);

                //tính F
                string f = pbox(sbox(exorc(expandr, compressk)));

                L[i - 1] = xor(R[i], f, 32);
            }

            string kqtam = L[0] + R[0];
            string kq = "";
            //hoán vị lại ban đầu
            StringBuilder sk = new StringBuilder(kqtam);

            for (int i = 0; i < 64; i++)
            {
                sk[hoanvikhoitao[i]] = kqtam[i];
            }
            kq = sk.ToString();
            return binarytochar(kq);
        }
        #endregion
    }
}
