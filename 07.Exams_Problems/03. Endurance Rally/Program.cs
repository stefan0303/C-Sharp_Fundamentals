using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] drivers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();//find drivers
        double[] zones = Console.ReadLine().Split(' ').Select(double.Parse).ToArray(); //find the zones
        double[] checkPoints = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();//find the check points
        double startingFuel;


        for (int i = 0; i < drivers.Length; i++)
        {
            char[] firstChar = drivers[i].Substring(0, 1).ToCharArray();//Find the first char for the Fuel
            startingFuel = (double)firstChar[0]; //The starting Fuel               

            for (int m = 0; m < zones.Length; m++)
            {

                if (checkPoints.Contains(m))//There is zone ,have to sum with in the starting fuel
                {
                    startingFuel += zones[m];

                }
                else //There is no zone you have to devide from starting fuel
                {
                    startingFuel -= zones[m];
                    if (startingFuel <= 0) //No fuel
                    {
                        startingFuel = 0;
                        Console.WriteLine(drivers[i] + " - reached " + m);//Could not finished print the zone he reached!
                        m = zones.Length - 1;

                        if (i >= drivers.Length)
                        {
                            break;
                        }
                    }
                }

            }
            if (i >= drivers.Length)
            {
                break;
            }
            if (startingFuel != 0)
            {
                Console.WriteLine(drivers[i] + " - fuel left " + string.Format("{0:0.00}", startingFuel));

            }


        }
    }
}

