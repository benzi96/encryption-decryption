using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATBMTT.mahoa
{
    public class caesar
    {
        int kiemtrakhoalaso(string khoa)
        {
            int k = 0;
            int.TryParse(khoa, out k);
            return k;
        }

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

            //gan khoa
            int k = kiemtrakhoalaso(khoa);
            if (k == 0) return input;

            //xoa khoang trang
            input = input.Replace(" ", String.Empty);
            input = input.Trim();

            int[] mangkitu = doikituthanhso(input);

            for (int i = 0; i < mangkitu.Length; i++)
            {
                //(p+k) mod 26
                mangkitu[i] = ((mangkitu[i] + k) % 26) + 65;
                ketqua += (char)mangkitu[i];
            }
            return ketqua;
        }

        public string giaima(string input, string khoa)
        {
            string ketqua = "";
            //gan khoa
            int k = kiemtrakhoalaso(khoa);
            if (k == 0) return input;

            //xoa khoang trang
            input = input.Replace(" ", String.Empty);
            input = input.Trim();

            int[] mangkitu = doikituthanhso(input);
            for (int i = 0; i < mangkitu.Length; i++)
            {
                //(c-k) mod 26
                if (mangkitu[i] - k < 0) mangkitu[i] = (26 + (mangkitu[i] - k) % 26) + 65;
                else
                    mangkitu[i] = ((mangkitu[i] - k) % 26) + 65;

                ketqua += (char)mangkitu[i];
            }
            return ketqua;
        }
    }
}
