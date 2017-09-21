using System;

class Program
{
    static void Main()
    {
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());


        int[,] matrix =
        {
                {1, 5, 3, 4},
                {2, 6, 3, 4},
                {3, 7, 3, 4},
                {4, 8, 3, 4},
            };

        for (int i = 0; i <= row; i++)
        {
            for (int m = 0; m <= col - 1; m++)
            {
                Console.Write(matrix[i, m]);

            }
            Console.WriteLine();
        }

    }
}


