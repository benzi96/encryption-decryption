using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATBMTT.mahoa
{
    public class vigenere
    {
        int[] doikituthanhso(string s)
        {
            int[] mangkitu = new int[s.Length];
            int i = 0;
            foreach (char c in s)
            {
                int temp = Convert.ToInt32(c);
                if (temp >= 97 && temp <= 122)
                {
                    mangkitu[i] = Convert.ToInt32(c) - 97;
                }
                if (temp >= 65 && temp <= 90)
                {
                    mangkitu[i] = Convert.ToInt32(c) - 65;
                }
                i++;
            }
            return mangkitu;
        }

        public string mahoa(string input, string khoa)
        {
            string ketqua = "";
            //xoa khoang trang
            input = input.Replace(" ", String.Empty);
            input = input.Trim();

            //xoa khoang trang khoa
            khoa = khoa.Replace(" ", String.Empty);
            khoa = khoa.Trim();

            int[] mangkitu = doikituthanhso(input);
            int[] mangkhoa = doikituthanhso(khoa);

            int m = khoa.Length;

            for (int i = 0; i < input.Length; i++)
            {
                // (pi + k(i mod m)) % 26
                ketqua += Convert.ToChar((mangkitu[i] + mangkhoa[i % m]) % 26 + 65);
            }
            return ketqua;
        }

        public string giaima(string input, string khoa)
        {
            string ketqua = "";
            //xoa khoang trang
            input = input.Replace(" ", String.Empty);
            input = input.Trim();

            //xoa khoang trang khoa
            khoa = khoa.Replace(" ", String.Empty);
            khoa = khoa.Trim();

            int[] mangkitu = doikituthanhso(input);
            int[] mangkhoa = doikituthanhso(khoa);

            int m = khoa.Length;

            for (int i = 0; i < input.Length; i++)
            {
                // (ci - k(i mod m)) % 26
                int temp = (mangkitu[i] - mangkhoa[i % m]) % 26;
                if (temp < 0) ketqua += Convert.ToChar(26 + temp + 65);
                else
                    ketqua += Convert.ToChar(temp + 65);
            }
            return ketqua;
        }
    }
}
