using System;

namespace Lab4
{
    class Task17
    {
        static void Main(string[] args)
        {
            int R;
            const int N = 5;
            int[] array;
            array = new int[N];

            Console.WriteLine($"Enter a random number for R");
            R = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Enter a random number №{i}/{N - 1}");
                array[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
