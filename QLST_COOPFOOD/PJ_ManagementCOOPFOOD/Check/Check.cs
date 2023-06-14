using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kiemtra
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(CheckDigit("11332"));
            //char c = (char)92;
            //string s = c.ToString();
            //Console.WriteLine(s);
        }

        //kiểm tra chuỗi, nếu tồn tại kí tự != digit trả về false
        public static bool CheckDigit(String str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]) == false)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
