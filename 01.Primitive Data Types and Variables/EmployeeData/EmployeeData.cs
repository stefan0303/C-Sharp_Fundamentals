﻿using System;

/*
    Problem 10. Employee Data
    A marketing company wants to keep record of its employees. Each record would have the following characteristics:
    First name
    Last name
    Age (0...100)
    Gender (m or f)
    Personal ID number (e.g. 8306112507)
    Unique employee number (27560000…27569999)
    Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
    Use descriptive names. Print the data at the console.
*/

class EmployeeData
{
    static void Main()
    {

        Console.WriteLine("First name:");
        string FirstName = Console.ReadLine();
        Console.WriteLine("Last name:");
        string LastName = Console.ReadLine();
        Console.Write("Age (0 - 100): ");
        byte Age = byte.Parse(Console.ReadLine());
        Console.Write("Gender (m or f): ");
        char Gender = Console.ReadLine()[0];
        Console.Write("ID Number (e.g. 8306112507): ");
        long PersonalIDnumber = long.Parse(Console.ReadLine());
        Console.Write("Unique employee number (27560000…27569999): ");
        int EmployeeNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Employee information");
        Console.WriteLine();
        Console.WriteLine("First name: {0}", FirstName);
        Console.WriteLine("Last name: {0}", LastName);
        Console.WriteLine("Age: {0}", Age);
        Console.WriteLine("Gender: {0}", Gender);
        Console.WriteLine("Personal ID number: {0}", PersonalIDnumber);
        Console.WriteLine("Unique employee number: {0}", EmployeeNumber);

    }
}

