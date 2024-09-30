/* 
----------------------------------------------------------------
Easter Calculator
----------------------------------------------------------------
Developer:     Marshall Goins 
Creation date: 2/5/2024 
Last modified: 2/5/2024
Email address: mjgoins@senators.ws.edu
-----------------------------------------------------------------
Purpose:
This program calculates the day Easter falls on.
-----------------------------------------------------------------
*/

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

class Chapter3Lab
{
    static void Main()
    {
        //// for loop to test 20 entries.
        //for (int z = 0; z < 20;  z++)
        //{
            // Output program's purpose
            Console.WriteLine("This program calculates what day Easter falls on for a given year.\n");

            // Get input from user and convert the input to integer
            Console.Write("Year? ");

            double year = int.Parse(Console.ReadLine());

            // Anonymous Gregorian Computus algorithm
            double a = year % 19;
            double b = Math.Floor(year / 100);
            double c = year % 100;
            double d = Math.Floor(b / 4);
            double e = b % 4;
            double f = Math.Floor((b + 8) / (25));
            double g = Math.Floor((b - f + 1) / (3));
            double h = (19 * a + b - d - g + 15) % 30;
            double i = Math.Floor(c / 4);
            // why no j lol
            double k = c % 4;
            double l = (32 + 2 * e + 2 * i - h - k) % 7;
            double m = Math.Floor((a + 11 * h + 22 * l) / 451);

            double month = Math.Floor((h + l - 7 * m + 114) / 31);
            double day = 1 + ((h + l - 7 * m + 114) % 31);

            // Check what number of month Easter falls in and store in a string.
            string monthOfEaster;

            if (month == 3)
            {
                monthOfEaster = "March";
            }
            else if (month == 4)
            {
                monthOfEaster = "April";
            }
            else
            {
                throw new Exception("What's happening here?");
            } // end if
       
            // display what month and day easter falls on.
            Console.WriteLine($"In {year}, Easter falls on {monthOfEaster} {day}.");
        //}// end for

    } // end method
} // end class


