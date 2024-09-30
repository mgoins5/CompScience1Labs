/* 
----------------------------------------------------------------
Easter Calculator
----------------------------------------------------------------
Developer:     Marshall Goins 
Creation date: 2/5/2024 
Last modified: 2/6/2024
Email address: mjgoins@senators.ws.edu
-----------------------------------------------------------------
Purpose:
This program calculates the day Easter falls on.
-----------------------------------------------------------------
*/

// CalculateEasterDriver.cs
// Driver Class

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class CalculateEasterDriver
{
    static void Main()
    {
        //// for loop for easy testing
        //for (int i = 0; i < 10; i++)
        //{
            // Output program's purpose
            Console.WriteLine("This program calculates what day Easter falls on for a given year.\n");

            // Get input from user and convert the input to integer
            Console.Write("Year? ");
        
            // Assign the year from the user to a variable
            int year = int.Parse(Console.ReadLine());

            // to cast to an double put (double) before year or (double)year. same with int (int)year

            // Pass this variable into the CalculateEaster() method
            CalculateEaster myCalculation = new CalculateEaster(year);
        
            //// store the returned calculation into a string
            //string monthAndDay = myCalculation.GetEasterDate();

            //// OR find a more effecient way to do the above.
        
            // display what month and day easter falls on.
            Console.WriteLine($"\nIn {year}, Easter falls on {myCalculation.GetEasterDate()}.\n");
        //} // end for

    } // end method
} // end class