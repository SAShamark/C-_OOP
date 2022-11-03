using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab6
{
    public static class Program
    {
        private static void Main()
        {
            //Console.WriteLine(ReverseInt(35413));
            //Console.WriteLine(ReverseString("35413"));
            //Console.WriteLine(ReverseDouble(354.13));
            //Console.WriteLine(MagicReverse("354.13",'.'));

            string[] strings = { "saf", "agfa", "fahs", "hse" };
            //UniversalReverser(strings);
            //ReverserArray(strings);

            var ints = new List<int>
            {
                1,
                2,
                3,
                4
            };

            Console.WriteLine(ints.Count);
            SizeArrayChanger(ref ints, 6);
        }

        //1111
        private static int ReverseInt(int value)
        {
            var result = 0;
            while (value > 0)
            {
                result = result * 10 + value % 10;
                value /= 10;
            }

            return result;
        }
        //1111

        //2222
        private static string ReverseString(string value)
        {
            string result = string.Empty;
            for (var i = value.Length - 1; i > -1; i--)
            {
                result += value[i];
            }

            return result;
        }
        //2222

        //3333
        private static string ReverseDouble(double value)
        {
            string[] stringArray = value.ToString().Split(',');
            string result = string.Empty;

            foreach (var i in stringArray)
            {
                var temp = int.Parse(i);
                while (temp != 0)
                {
                    result += temp % 10;
                    temp /= 10;
                }

                result += ".";
            }


            return result.Substring(0, result.Length - 1);
        }
        //3333

        //4444
        private static string MagicReverse(string value, char magicSign)
        {
            string[] stringArray = value.Split(magicSign);
            string result = string.Empty;
            foreach (var i in stringArray)
            {
                result += ReverseString(i) + magicSign;
            }

            return result.Substring(0, result.Length - 1);
        }
        //4444

        //5555
        private static void UniversalReverser<T>(IEnumerable<T> array)
        {
            var reverseArray = array.Reverse();

            foreach (var reverse in reverseArray)
            {
                Console.WriteLine(reverse);
            }
        }
        //5555

        //7777
        private static void ReverserArray(string[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
        //7777

        //8888
        private static void SizeArrayChanger(ref List<int> array, int sizeValue)
        {
            if (array.Count < sizeValue)
            {
                var countForNewElement = sizeValue - array.Count;
                for (int i = 0; i < countForNewElement; i++)
                {
                    array.Add(0);
                }
            }

            Console.WriteLine(array.Count);
        }
        //8888
    }
}