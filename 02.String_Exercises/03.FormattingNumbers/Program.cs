using System;
using System.Linq;

class Program
{
    static void Main()
    {
        //To DO make it with PadLeft and PadRight
        char[] splitter = new char[] { ' ', '\t', '\n' };
        string[] input = Console.ReadLine().Split(splitter, StringSplitOptions.RemoveEmptyEntries).ToArray();
        int a = Convert.ToInt32(input[0]);
        double b = Convert.ToDouble(input[1]);
        double c = Convert.ToDouble(input[2]);

        string hexValueA = a.ToString("X");//a to hexadecimal
        string binaryA = Convert.ToString(a, 2);//a to binary

        string bTotwoPoint = Convert.ToString(string.Format("{0:0.00}", b));
        string cTothreePoint = Convert.ToString(string.Format("{0:0.000}", c));//

        string resultPrint = "|" + hexValueA + new string(' ', 10 - hexValueA.Length)
           + "|" + new string('0', 10 - binaryA.Length) + binaryA + "|" + new string(' ', 10 - bTotwoPoint.Length) + bTotwoPoint + "|" + cTothreePoint + new string(' ', 10 - cTothreePoint.Length) + "|";
        Console.WriteLine(resultPrint);

    }
}

