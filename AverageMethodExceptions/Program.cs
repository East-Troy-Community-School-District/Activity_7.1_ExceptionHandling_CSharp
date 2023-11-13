/*
 * Average Method Exceptions
 * Pawelski
 * 11/12/2023
 * Developing Desktop Applications
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageMethodExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] scores = { 67, 99, 23, 87, 100, 56, 88, 89, 82, 91, 44, 77, 62, 10, 90, 84 };
            int rangeStart, rangeEnd;
            double average;

            try
            {
                Console.Write("What is the starting index of the range? >> ");
                rangeStart = Convert.ToInt32(Console.ReadLine());
                Console.Write("What is the ending index of the range? >> ");
                rangeEnd = Convert.ToInt32(Console.ReadLine());
                average = Average(scores, rangeStart, rangeEnd);
                Console.WriteLine("The average of the numbers between " + rangeStart
                    + " and " + rangeEnd + " is " + average);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Values entered must be an integer.");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Calculates the average of a specific range in a data set.
        /// </summary>
        /// <param name="data">Data set of numbers.</param>
        /// <param name="start">Starting index for the range.</param>
        /// <param name="end">Ending index for the range, inclusive.</param>
        /// <returns>Average of the numbers within the given range.</returns>
        /// <exception cref="IndexOutOfRangeException">
        /// Thrown when start and end are outside the bounds of the array.
        /// </exception>
        /// /// <exception cref="ArgumentException">
        /// Thrown when the start index is after the end index.
        /// </exception>
        private static double Average(double[] data, int start, int end)
        {
            if (start < 0 || end > data.Length - 1) 
            {
                throw new IndexOutOfRangeException("Indexes outside the bounds of the array.");
            }
            if (end < start)
            {
                throw new ArgumentException("Start index is after the end index.");
            }

            double sum = 0;
            int count = 0;
            for (int i = start; i <= end; i++)
            {
                sum += data[i];
                count++;
            }
            return sum / count;
        }
    }
}
