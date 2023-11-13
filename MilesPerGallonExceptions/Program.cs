/*
 * Miles Per Gallon Exceptions
 * Pawelski
 * 11/12/2023
 * Developing Desktop Applications
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesPerGallonExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int milesDriven, gallonsOfGas, milesPerGallon;
            try
            {
                Console.Write("How many miles were driven? >> ");
                milesDriven = Convert.ToInt32(Console.ReadLine());
                Console.Write("How many gallons of gas was purchased? >> ");
                gallonsOfGas = Convert.ToInt32(Console.ReadLine());
                milesPerGallon = milesDriven / gallonsOfGas;
            }
            catch (Exception e)
            {
                milesPerGallon = 0;
                Console.WriteLine("You cannot divide by 0!");
            }
            Console.WriteLine("You got " + milesPerGallon + " miles per gallon.");
        }
    }
}
