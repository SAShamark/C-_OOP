using Lab9.Interface;

namespace Lab9.Abilities;

public class Painter: IDraw
{
    public void Draw()
    {
        const int _limit = 7;

        for (int i = 1; i <= _limit; i++)
        {
            for (int j = i; j > 0; j--)
                Console.Write(".");

            Console.Write("\n");
        }
    }
}