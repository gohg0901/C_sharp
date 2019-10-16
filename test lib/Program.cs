

//문제 4. 다음 프로그램의 출력을 쓰시오.

using System;
using System.Linq;

namespace Test4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 3, 4, 5 };
            char[] separator = new char[data.Length + 1];
            String s = "";
            s = s + "바보X";

            for (int i = 0; i < data.Length; i++)
            {
                separator[i] = (char)('0' + i * 2 + 1); // '0'는 숫자 zero 문자상수임
                for (int j = 0; j < data[i]; j++)
                {
                    s = s + data[i];
                }
            }
            separator[data.Length] = 'X';
            s = s + "X바보";
            s = s.Replace("바보", "천재");
            String[] ans = s.Split(separator);
            for (int i = 0; i < ans.Length; i++)
            {
                if ((i == 0) || (i == ans.Length - 1)) Console.Write(ans[i]);
                else if (ans[i].Length > 0) Console.Write(ans[i].ElementAt(0));
            }
            Console.WriteLine();
        }
    }
}