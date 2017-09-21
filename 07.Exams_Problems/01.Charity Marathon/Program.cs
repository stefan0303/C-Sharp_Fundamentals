using System;

class Program
{
    static void Main()
    {
        decimal marathonDays = decimal.Parse(Console.ReadLine());//marathon in days
        decimal runnersCount = decimal.Parse(Console.ReadLine());//number of runners
        decimal averageNumberOfLabs = decimal.Parse(Console.ReadLine());//number of labs
        decimal LenghtOfTrack = decimal.Parse(Console.ReadLine());//Lenght of Track 
        decimal capacityOfTrack = decimal.Parse(Console.ReadLine());//capacity of Runners
        decimal moneyDonatedPerKm = decimal.Parse(Console.ReadLine());//money donated per km

        if (capacityOfTrack * marathonDays < runnersCount)
        {
            runnersCount = capacityOfTrack * marathonDays;//Only this count of runners can run
        }
        decimal totalMeters = runnersCount * averageNumberOfLabs * LenghtOfTrack;//in meters
        decimal totalKm = totalMeters / 1000;//find from meters the Km
        decimal allMoneyDonated = moneyDonatedPerKm * totalKm;

        Console.WriteLine("Money raised: {0:f2}", allMoneyDonated);
    }

}

