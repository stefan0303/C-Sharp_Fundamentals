﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string key = Console.ReadLine();
        string sentence = Console.ReadLine();
        string command = sentence;//check is the sentence is final
        Dictionary<string, long> teamPoints = new Dictionary<string, long>();//Dictionary with team and points
        Dictionary<string, long> teamGoals = new Dictionary<string, long>();//Dictionary with teams and goals
        while (command.ToLower() != "final")
        {
            string patternstart = Regex.Escape(key);
            string patternend = Regex.Escape(key);
            string regexexpr = patternstart + @"(.*?)" + patternend;

            Regex regex = new Regex(regexexpr);
            MatchCollection matchCollection = regex.Matches(sentence);

            string teamOne = matchCollection[0].ToString();
            teamOne = teamOne.Substring(key.Length, teamOne.Length - key.Length - key.Length);
            string teamTwo = matchCollection[1].ToString();
            teamTwo = teamTwo.Substring(key.Length, teamTwo.Length - key.Length - key.Length);

            string result = sentence.Substring(sentence.Length - 4, 4).Trim();//find the resul ot match

            long scoreFirstTeam = Convert.ToInt64(result.Substring(0, 1)); //score of firstTeam
            long scoreSecondTeam = Convert.ToInt64(result.Substring(2, 1)); //score of second team
            teamOne = ReverseString(teamOne);
            teamTwo = ReverseString(teamTwo);
            teamOne = teamOne.ToUpper();//make team UpperCase
            teamTwo = teamTwo.ToUpper();////make team UpperCase


            if (!teamPoints.ContainsKey(teamOne))
            {
                teamPoints.Add(teamOne, 0);
                teamGoals.Add(teamOne, 0);

            }

            if (!teamPoints.ContainsKey(teamTwo))
            {
                teamPoints.Add(teamTwo, 0);
                teamGoals.Add(teamTwo, 0);
            }

            if (scoreFirstTeam > scoreSecondTeam)//win first team
            {
                teamPoints[teamOne] += 3;
                teamGoals[teamOne] += scoreFirstTeam;
                teamGoals[teamTwo] += scoreSecondTeam;
            }
            else if (scoreSecondTeam > scoreFirstTeam)//win second team
            {
                teamPoints[teamTwo] += 3;
                teamGoals[teamTwo] += scoreSecondTeam;
                teamGoals[teamOne] += scoreFirstTeam;
            }
            else if (scoreFirstTeam == scoreSecondTeam) //Draw
            {
                teamPoints[teamOne] += 1;
                teamPoints[teamTwo] += 1;
                teamGoals[teamOne] += scoreFirstTeam;
                teamGoals[teamTwo] += scoreSecondTeam;
            }
            sentence = Console.ReadLine();
            command = sentence;
        }
        //Print the standings table ordered descending by points in format
        var printTeamPoints = teamPoints.OrderByDescending(p => p.Value).ThenBy(n => n.Key);//by key then by value
        Console.WriteLine("League standings:");
        int count = 1;
        foreach (var team in printTeamPoints)
        {
            Console.WriteLine(+count + ". " + team.Key + " " + team.Value);
            count++;
        }
        count = 1;
        var printTeamGoals = teamGoals.OrderByDescending(g => g.Value).ThenBy(t => t.Key).Take(3);
        Console.WriteLine("Top 3 scored goals:");
        foreach (var team in printTeamGoals)
        {
            Console.WriteLine("- " + team.Key + " -> " + team.Value);
            count++;
        }
    }
    public static string ReverseString(string s)//Reverse a string
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}
