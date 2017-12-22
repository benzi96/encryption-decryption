using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ATBMTT.mahoa
{
    public class playfair
    {
        string xoakitudacbiet(string s)
        {
            Regex rgx = new Regex("[^a-z-]");
            s = rgx.Replace(s, "");
            s = s.Replace('j', 'i');
            return s;
        }

        string chiacap(string s)
        {
            for (int i = 0; i < s.Length; i += 2)
            {
                // nếu vi trí i+1 < chiều dài chuỗi và i và i+1 giống nhau thì thêm x 
                if (((i + 1) < s.Length) && (s[i] == s[i + 1]))
                {
                    s = s.Insert(i + 1, "x");
                }
            }
            if ((s.Length % 2) > 0)
            {
                s += "x";
            }
            return s;
        }

        char[,] themkhoavaobang(string khoa)
        {
            string bangabc = "abcdefghiklmnopqrstuvwxyz";
            string bang5x5mahoa = "";
            for (int i = 0; i < khoa.Length; i++)
            {
                if ((bang5x5mahoa == null) || (!bang5x5mahoa.Contains(khoa[i])))
                {
                    bang5x5mahoa += khoa[i];// Thêm khóa vào bảng
                }
            }
            for (int i = 0; i < bangabc.Length; i++)
            {
                if (!bang5x5mahoa.Contains(bangabc[i]))
                {
                    bang5x5mahoa += bangabc[i];// Thêm cái kí tự còn lại chưa có trong từ khóa vào bảng mã
                }
            }
            
            char[,] bang5x5 = new char[5, 5];
            int k = 0;
            for (int i = 0; i < 5; ++i)
                for (int j = 0; j < 5; ++j)
                {
                    bang5x5[i, j] = bang5x5mahoa[k];
                    k++;
                }
            return bang5x5;
        }
   
        //nếu a+luachon = 5 thì a=0 nếu a+luachon=-1 thì a=4
        int vitrikituketiep(int a, int luachon)
        {
            a = (a + luachon) % 5;
            if (a < 0) a = a + 5;
            return a;
        }

        //luachon=1 để mã hóa, luachon=-1 để giải mã
        string hoanvitrenbang(char kitumot, char kituhai, char[,] bang5x5, int luachon)
        {
            string cap = "";
            int row1 = 0, row2 = 0, col1 = 0, col2 = 0;
            for (int i = 0; i < 5; ++i)
                for (int j = 0; j < 5; ++j)
                {
                    if(bang5x5[i,j]==kitumot)
                    {
                        row1 = i;
                        col1 = j;
                    }
                    else if(bang5x5[i,j]== kituhai)
                    {
                        row2 = i;
                        col2 = j;
                    }
                        
                }
            //nếu kí tự 1 và 2 cùng đòng thì lấy 2 kí tự kế tiếp của 1 và 2 cùng dòng đó, nếu là kí tự cuối thì trở về đầu
            if(row1==row2)
            {
                cap += bang5x5[row1, vitrikituketiep(col1, luachon)].ToString() + bang5x5[row2, vitrikituketiep(col2, luachon)].ToString();
            }
            //nếu kí tự 1 và 2 cùng cột thì lấy 2 kí tự kế tiếp của 1 và 2 cùng cột đó, nếu là kí tự cuối thì trở về đầu
            else if (col1==col2)
            {
                cap += bang5x5[vitrikituketiep(row1, luachon), col1].ToString() + bang5x5[vitrikituketiep(row2, luachon), col2].ToString();
            }
            //đường chéo hình chữ nhật nếu không cùng dòng và cột
            else
            {
                cap += bang5x5[row1, col2].ToString() + bang5x5[row2, col1].ToString();
            }
            return cap;
        }

        public string mahoa(string input, string khoa)
        {
            string ketqua = "";
            khoa = khoa.ToLower();
            khoa = xoakitudacbiet(khoa);
            input = xoakitudacbiet(input);
            input = chiacap(input);

            char[,] bang5x5 = new char[5, 5];
            bang5x5 = themkhoavaobang(khoa);

            for (int i = 0; i < input.Length; i += 2)
            {
                ketqua += hoanvitrenbang(input[i], input[i + 1], bang5x5, 1);
            }

            return ketqua;
        }

        public string giaima(string input, string khoa)
        {
            string ketqua = "";
            khoa = khoa.ToLower();
            khoa = xoakitudacbiet(khoa);
            input = xoakitudacbiet(input);
            input = chiacap(input);

            char[,] bang5x5 = new char[5, 5];
            bang5x5 = themkhoavaobang(khoa);

            for (int i = 0; i < input.Length; i += 2)
            {
                ketqua += hoanvitrenbang(input[i], input[i + 1], bang5x5, -1);
            }
            return ketqua;
        }
    }
}
