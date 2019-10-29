//문제 4. 다음 프로그램의 출력을 쓰시오.

using System;

namespace Test4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 6, 1, 4, 2, 8 };
            String s = "";

            s = s + "XY";
            for (int i = 0; i < data.Length; i++)
            {
                s = s + data[i] + "X";
            }
            for (int i = data.Length - 1; i >= 0; i--)
            {
                s = s + data[i] + "Y";
            }
            s = s + "YX";

            s = s.Replace('X', ' ');
            s = s.Replace('Y', ' ');

            s = s.Trim();

            // Substring(int startIndex,int length)
            // startIndex: 시작위치, length:길이
            s = s.Substring(6, 7);

            char[] separator = new char[1];
            separator[0] = ' ';

            String[] result = s.Split(separator);

            int sum = 0;

            for (int i = 0; i < result.Length; i++)
            {
                sum = sum + int.Parse(result[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
