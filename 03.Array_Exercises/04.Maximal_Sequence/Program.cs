using System;

//Problem 4. Maximal sequence
//Write a program that finds the maximal sequence of equal elements in an array.


class Program
{
    static void Main()
    {
        Console.WriteLine("Write the leght of the array : ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        int len = 0;    //the length of the current sequence, start from 1;

        int bestStart = 0;// The best start;
        int bestLen = 0;  //The best len;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Write element " + i + " of the array : ");
            arr[i] = int.Parse(Console.ReadLine());

        }
        for (int a = 0; a < arr.Length - 1; a++)
        {
            if (arr[a] == arr[a + 1])
            {
                var start = arr[a]; //the index of the start of the current subset of the same elements, start from 0;
                len++;
                if (len > bestLen)
                {
                    bestLen = len;
                    bestStart = start;
                }
            }
            else if (arr[a] != arr[a + 1])
            {

                len = 1;
            }
            for (int i = 0; i < bestLen; i++)
            {

                Console.WriteLine("{0}, ", bestStart);
            }
            Console.WriteLine();
        }

    }
}


