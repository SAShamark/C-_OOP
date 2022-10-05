using System;

namespace Lab1
{
    class Task2
    {
        static void Main(string[] args)
        {
            float I;
            float R;
            float U;

            Console.WriteLine("Set R");
            R = float.Parse(Console.ReadLine());
            Console.WriteLine("Set U");
            U = float.Parse(Console.ReadLine());

            if (R != 0)
            {
                I = U / R;
                Console.WriteLine($"Answer-{I}");
            }
            else
            {
                Console.WriteLine("R==0");
            }
        }
    }
}
