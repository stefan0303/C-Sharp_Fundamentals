using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new[] { ' ', '@' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        Dictionary<string, Dictionary<string, List<string>>> id_event_participants = new Dictionary<string, Dictionary<string, List<string>>>();
        while (input[0] != "Time")
        {
            if (input[1].Substring(0, 1) == "#")//Check the Event is starting with #
            {
                string id = input[0];

                string eventName = input[1].Substring(1, input[1].Length - 1);//Substring # from the output
                if (!id_event_participants.ContainsKey(id))
                {
                    id_event_participants.Add(id, new Dictionary<string, List<string>>());//add new Key
                    id_event_participants[id].Add(eventName, new List<string>());//Add new key in second dictionary and make new list of participaints
                    for (int i = 2; i < input.Length; i++)//starting from i=2 to escape from Id and Event Name
                    {
                        id_event_participants[id][eventName].Add(input[i]);//Add the participaints ot List
                    }

                }
                else if (id_event_participants[id].ContainsKey(eventName)) //If the Key exists check the event Name is the same
                {
                    for (int i = 2; i < input.Length; i++)//starting from i=2 to escape from Id and Event Name
                    {
                        if (!id_event_participants[id][eventName].Contains(input[i]))//if there is no such a person
                        {
                            id_event_participants[id][eventName].Add(input[i]);//Add the participaints ot List
                        }

                    }
                }
            }
            input = Console.ReadLine().Split(new[] { ' ', '@' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }

        var answer = id_event_participants.OrderByDescending(x => x.Value.Values.Sum(p => p.Count)).ThenBy(p => p.Key);
        foreach (var item in answer)
        {
            foreach (var val in item.Value)
            {
                Console.WriteLine(val.Key + " - " + val.Value.Count());
                foreach (var participant in val.Value.OrderBy(v => v))
                {
                    Console.WriteLine("@" + participant);
                }
            }
        }

    }
}

