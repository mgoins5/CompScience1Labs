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

// CalculateEaster.cs
// A simple CalculateEaster class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CalculateEaster
{
    // an int throws an exception on line 40. a double makes the exception go away
    // The previous lab used a double. does it have to be an int?
    private int _year;

    // Constructor for the CalculateEaster class
    public CalculateEaster(int year)
    {
        this.Year = year;
    } // end method

    public int Year
    {
        get 
        {
            return _year;
        } // end get
        set
        {
            if (value <= 0)
            {
                throw new Exception("Invalid year. Please enter a common era year.");
            }
            else
            {
                _year = value;
            } // end if
        } // end set
    } // end property


    public string GetEasterDate()
    {
        // Anonymous Gregorian Computus algorithm
        double a = this.Year % 19;
        double b = Math.Floor(this.Year / 100d); // I found dividing by 100d, instead of 100, here fixes the error and lets the program run
        double c = this.Year % 100;
        double d = Math.Floor(b / 4);
        double e = b % 4;
        double f = Math.Floor((b + 8) / (25));
        double g = Math.Floor((b - f + 1) / (3));
        double h = (19 * a + b - d - g + 15) % 30;
        double i = Math.Floor(c / 4);
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

        return ($"{monthOfEaster} {day}");
    } // end method
} // end class