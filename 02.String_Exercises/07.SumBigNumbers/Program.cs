using System;

class Program
{
    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();
        int bigLenght;
        if (first.Length >= second.Length)//makes zeroes in the short string
        {
            bigLenght = first.Length;
            int diference = first.Length - second.Length;
            second = new string('0', diference) + second;
        }
        else
        {
            bigLenght = second.Length;
            int diference = second.Length - first.Length;
            first = new string('0', diference) + first;
        }

        string finalResult = "";
        int sum;
        int ostatuk = 0;
        for (int i = bigLenght - 1; i >= 0; i--)//backwards
        {

            int firstNumber = (int)Char.GetNumericValue(first[i]);//make char to num
            int secondNumber = (int)Char.GetNumericValue(second[i]);
            sum = firstNumber + secondNumber + ostatuk;
            if (sum > 9)
            {
                ostatuk = sum - 10;
                finalResult = ostatuk + finalResult;
                ostatuk = 1;
            }

            else
            {
                finalResult = sum + finalResult;
                ostatuk = 0;
            }

            if (i == 0 && ostatuk == 1)
            {
                finalResult = "1" + finalResult;

            }

        }

        Console.WriteLine(finalResult.TrimStart(new char[] { '0' }));
    }
}

