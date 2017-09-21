using System;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        decimal overalProfit = 0;
        decimal averageprofit = 0;


        for (int i = 0; i < input; i++)
        {
            int adultPassenger = int.Parse(Console.ReadLine());
            decimal adulTickeprize = decimal.Parse(Console.ReadLine());

            int youhtPassengers = int.Parse(Console.ReadLine());
            decimal youhtTicketprize = decimal.Parse(Console.ReadLine());

            decimal fuelPrizeHour = decimal.Parse(Console.ReadLine());
            decimal fuemConsumhour = decimal.Parse(Console.ReadLine());

            int flightDuration = int.Parse(Console.ReadLine());

            decimal income = (adultPassenger * adulTickeprize) + (youhtPassengers * youhtTicketprize);
            decimal expences = (decimal)(flightDuration * fuemConsumhour * fuelPrizeHour);

            decimal profit = income - expences;
            overalProfit = overalProfit + (income - expences);
            averageprofit = overalProfit / input;
            if (income >= expences)
            {
                Console.WriteLine("You are ahead with {0:f3}$.", profit);
            }
            else if (income < expences)
            {
                Console.WriteLine("We've got to sell more tickets! We've lost {0:f3}$.", profit);
            }
        }
        Console.WriteLine("Overall profit -> {0:f3}$.", overalProfit);
        Console.WriteLine("Average profit -> {0:f3}$.", averageprofit);
    }
}

