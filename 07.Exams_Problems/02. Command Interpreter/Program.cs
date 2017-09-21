using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arrayNums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        string[] commands = Console.ReadLine().Split(' ').ToArray();
        int start;
        int end;
        List<int> smallList = new List<int>();

        while (commands[0] != "end")
        {

            if (commands[0] == "reverse")
            {
                start = int.Parse(commands[2]);
                end = int.Parse(commands[4]);
                if (start < 0 || end < 0 || start + end > arrayNums.Length - 1)//?
                {
                    Console.WriteLine("Invalid input parameters.");

                }
                else//make the reverce
                {

                    for (int i = start; i < end + start; i++)
                    {
                        smallList.Add(arrayNums[i]);//add to the small array
                    }
                    smallList.Reverse();//reverce the small list
                    int m = 0;
                    for (int i = start; i < end + start; i++)
                    {
                        arrayNums[i] = smallList[m];
                        m++;
                    }
                    smallList.Clear();
                }
            }
            else if (commands[0] == "sort")
            {

            }
            else if (commands[0] == "rollLeft")
            {


            }
            else if (commands[0] == "rollRight")
            {

                arrayNums = CyclicRotation(arrayNums, Convert.ToInt32(commands[1]));
            }
            commands = Console.ReadLine().Split(' ').ToArray();
        }

        string print = "";
        foreach (var num in arrayNums)
        {
            print += num + ", ";
        }
        print = print.Substring(0, print.Length - 2);
        Console.WriteLine("[" + print + "]");
    }
    public static int[] CyclicRotation(int[] A, int K)
    {
        //Rotate an array to the right by a given number of steps.
        // eg k= 1 A = [3, 8, 9, 7, 6] the result is [6, 3, 8, 9, 7]
        // eg k= 3 A = [3, 8, 9, 7, 6] the result is [9, 7, 6, 3, 8]

        if (A.Length == 0 || A.Length == 1)
        {
            return A;
        }
        int lastElement;
        int[] newArray = new int[A.Length];

        List<int> listOfNumbers = new List<int>();

        for (int i = 1; i < K + 1; i++)
        {

            lastElement = A[A.Length - 1];
            newArray = A.Take(A.Length - 1).ToArray();
            listOfNumbers = newArray.ToList();
            listOfNumbers.Insert(0, lastElement);

            A = listOfNumbers.ToArray();
            newArray = A;

        }
        return newArray;
    }
}

