using System;

namespace Lab3
{
    class Task12
    {
        static void Main(string[] args)
        {
            int[] values = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter a random number №{i}/2");
                values[i] = int.Parse(Console.ReadLine());
            }

            if (values[0] != values[1] && values[1] != values[2] && values[2] != values[0])
            {
                Console.WriteLine("nice");
            }
            else
            {
                Console.WriteLine("bad");
            }
        }
    }
}
