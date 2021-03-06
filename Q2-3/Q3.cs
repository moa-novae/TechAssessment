﻿/* Multiplication can be thought of as a repeated addition
 * 4 * 3 = 4 + 4 + 4
 * We can implement this in recursion to avoid using loops since we are repeatedly adding the multiplier.
 * The number of times which we repeatedly add the multiplier is equal to the multiplicand.
 * Multiply(4, 3) = 4 + Multiply(4, 2) = 4 + 4 + Multiply(4, 1) = 4 + 4 + 4 + Multiply(4, 0)
*/
using System;

namespace TechAssessment
{
    public class Q3
    {
        /// <summary>
        /// Multiply two doubles with recursion and addition
        /// </summary>
        /// <param name="multiplier">double type</param>
        /// <param name="multiplicand">double type</param>
        /// <returns>a double as the result</returns>
        public static double Multiply(double multiplier = 1, double multiplicand = 1)
        {
            // Base case is achieved when multiplicand is 0
            if (multiplicand == 0)
            {
                return 0;
            }
            // Add multiplier to total while decreasing multiplicand by 1
            else if (multiplicand >= 1)
            {
                return (multiplier + Multiply(multiplier, multiplicand - 1));
            }
            // Handle case when multiplicand has decimal
            else if (multiplicand < 1 && multiplicand > 0)
            {
                // multiplier needs to be multiplied with the multiplicand since we are no longer decreasing the multiplicand by 1.
                // Set the multiplicand to 0 to reach the base case
                return (multiplier * multiplicand + Multiply(multiplier, 0));
            }
            // Handle case when multiplicand is negative and cannot be decremented to 0
            // 4 * -3 = - (4 * 3)
            if (multiplicand < 0)
            {
                return -Multiply(multiplier, -multiplicand);
            }
            // If anything else happens, returns -1 as error
            else
            {
                return Convert.ToDouble(-1);
            }
        }

        // Additional overloaded methods that accepts arguments other than int and double can be implemented

        /// <summary>
        /// Multiply two int with recursion and addition
        /// </summary>
        /// <param name="multiplier">int type</param>
        /// <param name="multiplicand">int type</param>
        /// <returns>a double as the result</returns>
        public static double Multiply(int multiplier = 1, int multiplicand = 1)
        {
            double m1 = Convert.ToDouble(multiplier);
            double m2 = Convert.ToDouble(multiplicand);
            return Multiply(m1, m2);
        }

        /// <summary>
        /// Multiply two doubles with recursion and addition
        /// </summary>
        /// <param name="multiplier">int type</param>
        /// <param name="multiplicand">int type</param>
        /// <returns>a double as the result</returns>
        public static double Multiply(string multiplier = "1", string multiplicand = "1")
        {
            double m1 = Convert.ToDouble(multiplier);
            double m2 = Convert.ToDouble(multiplicand);
            return Multiply(m1, m2);
        }
    }
}
