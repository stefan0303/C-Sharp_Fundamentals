using System;

class Program
{
    static void Main()
    {
        decimal cash = decimal.Parse(Console.ReadLine());
        int guests = int.Parse(Console.ReadLine());
        decimal bananas = decimal.Parse(Console.ReadLine());
        decimal eggs = decimal.Parse(Console.ReadLine());
        decimal berries = decimal.Parse(Console.ReadLine());

        int portinsMore = 6;
        decimal portinos = 1;
        if (guests <= portinsMore)
        {
            portinos = 1;

        }
        else if (guests > portinsMore)
        {
            portinos = (int)Math.Ceiling(guests / 6.0);//14 18 //use Math.Celing//


        }
        decimal portinosMoney = ((2 * bananas) + (4 * eggs) + (decimal)(berries / 5));
        if (portinosMoney * portinos <= cash)
        {
            Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", portinosMoney * portinos);
        }
        else if (portinosMoney * portinos > cash)
        {
            Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", Math.Abs(cash - (portinosMoney * portinos)));
        }

    }
}

