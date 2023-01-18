﻿using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!\n");

            float numRolls = 0;

            Console.WriteLine("How many dice rolls would you like to simulate? ");
            numRolls = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Random rnd = new Random();
            
            int[] results = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < numRolls; i++)
            {
                int dice1 = rnd.Next(1, 7);
                int dice2 = rnd.Next(1, 7);

                int addDice = dice1 + dice2;

                results[(addDice - 2)] = (results[(addDice - 2)] + 1);
            }

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \" * \" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numRolls + ".\n");

            for (int i = 0; i < results.Length; i++)
            {
                results[i] = (int)((results[i] / numRolls) * 100);
                string percentResults = new string('*', results[i]);
                Console.Write((i + 2) + ": " + percentResults + "\n");
            }

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

        }
    }
}
