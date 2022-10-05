using System;

namespace Lab5
{
    class Task17
    {
        enum MirrorType
        {
            HorizontalAxisSymmetry = 0,
            VerticalAxisSymmetry = 1,
            MainDiagonal = 2,
            LateralDiagonalMatrix = 3,
        }
        static void Main(string[] args)
        {

            int maxRowNumber = 3;
            int maxColumnNumber = 3;
            int[,] matrix = new int[maxRowNumber, maxColumnNumber];

            SetMatrix(matrix);

            WriteMatrix(matrix);

            Console.WriteLine(
                $"{MirrorType.HorizontalAxisSymmetry} = 0 \n" +
                $"{MirrorType.VerticalAxisSymmetry} = 1 \n" +
                $"{MirrorType.MainDiagonal} = 2 \n" +
                $"{MirrorType.LateralDiagonalMatrix} = 3 \n" +
                $"Write something value");

            while (true)
            {
                int mirrorValue = int.Parse(Console.ReadLine());
                switch ((MirrorType)mirrorValue)
                {
                    case MirrorType.HorizontalAxisSymmetry:
                        HorizontalAxisSymmetry(matrix, maxRowNumber, maxColumnNumber);
                        break;
                    case MirrorType.VerticalAxisSymmetry:
                        VerticalAxisSymmetry(matrix, maxRowNumber, maxColumnNumber);
                        break;

                    case MirrorType.MainDiagonal:
                        MainDiagonal(matrix);
                        break;
                    case MirrorType.LateralDiagonalMatrix:
                        LateralDiagonalMatrix(matrix);
                        break;
                }
            }
        }

        static void HorizontalAxisSymmetry(int[,] _matrix, int maxRowNumber, int maxColumnNumber)
        {
            int tmp = 0;
            for (int column = 0; column < maxColumnNumber; column++)
            {
                for (int row = 0; row < maxRowNumber / 2; row++)
                {

                    tmp = _matrix[row, column];
                    _matrix[row, column] = _matrix[(maxRowNumber - 1) - row, column];
                    _matrix[(maxRowNumber - 1) - row, column] = tmp;
                }
            }
            WriteMatrix(_matrix);
        }
        static void VerticalAxisSymmetry(int[,] _matrix, int maxRowNumber, int maxColumnNumber)
        {
            int tmp = 0;
            for (int row = 0; row < maxRowNumber; row++)
            {
                for (int column = 0; column < maxColumnNumber / 2; column++)
                {
                    tmp = _matrix[row, column];
                    _matrix[row, column] = _matrix[row, (maxColumnNumber - 1) - column];
                    _matrix[row, (maxColumnNumber - 1) - column] = tmp;
                }
            }
            WriteMatrix(_matrix);
        }
        static void MainDiagonal(int[,] _matrix)
        {
            for (int row = 0; row < _matrix.GetLength(0); row++)
            {
                for (int column = row + 1; column < _matrix.GetLength(1); column++)
                {
                    var tmp = _matrix[row, column];
                    _matrix[row, column] = _matrix[column, row];
                    _matrix[column, row] = tmp;
                }
            }
            WriteMatrix(_matrix);
        }
        static void LateralDiagonalMatrix(int[,] _matrix)
        {
            for (int column = 0; column < _matrix.GetLength(1); column++)
            {
                for (int row = column + 1; row < _matrix.GetLength(0); row++)
                {

                    var tmp = _matrix[row, column];
                    _matrix[row, column] = _matrix[row, column];
                    _matrix[column, row] = tmp;
                }
            }
            WriteMatrix(_matrix);
        }

        static int[,] SetMatrix(int[,] _matrix)
        {

            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    Console.WriteLine($"Y:{i} X:{j}");
                    _matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return _matrix;
        }
        static void WriteMatrix(int[,] _matrix)
        {
            Console.WriteLine();

            for (int y = 0; y < _matrix.GetLength(0); y++)
            {
                for (int x = 0; x < _matrix.GetLength(1); x++)
                {
                    Console.Write(_matrix[y, x] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
