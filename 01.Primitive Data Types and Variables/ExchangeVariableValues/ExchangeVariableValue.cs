using System;
//Problem 9. Exchange Variable Values



    class ExchangeVariableValue
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Integer a = " + a + ", integer b = " + b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("After the exchange: a = " + a + ", b = " + b);

        }
    }

