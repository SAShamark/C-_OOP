using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        //1111
        static void ReverseInt(int value)
        {
            int result = 0;
            while (value > 0)
            {
                result = result * 10 + value % 10;
                value /= 10;
            }
            Console.WriteLine(result);
        }
        //1111

        //2222
        static void ReverseString(string value)
        {
            string result = String.Empty;
            for (int i = value.Length - 1; i > -1; i--)
            {
                result += value[i];
            }
            Console.WriteLine(result);
        }
        //2222

        //3333
       /* static void ReverseDouble(double value)
        {
            string[] strArr = value.ToString().Split(',');
            string result = String.Empty;

            int temp;
            foreach (string i in strArr)
            {
                temp = int.Parse(i);
                while (temp != 0)
                {
                    result += temp % 10;
                    temp /= 10;
                }

                result += ".";
            }


            Console.WriteLine(result.Substring(0, result.Length - 1));
        }*/
        //3333
    }
}
