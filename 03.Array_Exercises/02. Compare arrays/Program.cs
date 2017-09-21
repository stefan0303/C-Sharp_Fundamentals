using System;

class Program
{
    static void Main()
    {
        int[] arr = new int[20];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i * 5;                 //0*5, 1*5, 2*5 ......19*5
            Console.Write(arr[i] + " ");
        }
    }
}


