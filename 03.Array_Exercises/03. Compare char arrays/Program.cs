using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Write the size of the char arrayOne : ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Write the size of the char arrayTwo : ");
        int m = int.Parse(Console.ReadLine());

        if (m != n)
        {
            Console.WriteLine("Array cant be compare : ");
        }
        else
        {
            string[] arrOne = new string[n];
            string[] arrTwo = new string[m];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Write element for array one at index " + i);
                arrOne[i] = Console.ReadLine();
                Console.WriteLine("Write element for array two at index " + i);
                arrTwo[i] = Console.ReadLine();
            }

            for (int i = 0; i < arrOne.Length; i++)
            {
                if (arrOne[i] != arrTwo[i])
                {
                    Console.WriteLine("The element at index " + i + " are diferent :");
                }
                else
                {
                    Console.WriteLine("The element at index " + i + " are the same :");
                }
            }
        }
    }
}


