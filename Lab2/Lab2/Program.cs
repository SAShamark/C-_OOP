using System;

namespace Lab2
{
    class Task3
    {

        static void Main(string[] args)
        {
            int k;
            int nk;
            int nn;
            double result = 0;

            do
            {
                Console.WriteLine("Set nn");
                nn = int.Parse(Console.ReadLine());
            }
            while (nn <= 0);
            do
            {
                Console.WriteLine("Set nk");
                nk = int.Parse(Console.ReadLine());
            }
            while (nk <= nn);

            for (k = nn; k < nk; k++)
            {
                var up = Math.Pow(k, 2) - (Math.Pow(-1, k + 1) * Math.Pow(k, 3));
                var down = Math.Pow(k, 2) + k + 1;
                result += up / down;
            }
            Console.WriteLine(result);
        }

    }
}
