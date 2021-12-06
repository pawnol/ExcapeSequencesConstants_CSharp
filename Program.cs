/* 
 * Escape Sequences and Constants
 * Pawelski
 * 12/5/2021
 * This program shows how to use escape sequences and constants.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeSequenceConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a constant. It is like a variable as
            // it is a named memory location. Unlike a variable,
            // constants cannot be changed after initializing.
            const double TAX_RATE = 0.0515;
            double itemCost = 5.50;
            double totalCost = itemCost * TAX_RATE;
            Console.WriteLine("Total: $" + totalCost);

            // Here are the common escape sequences in C#.
            Console.WriteLine("this\tthat\nhere\tthere");
            Console.WriteLine("This inserts a double quote \"");
            Console.WriteLine("This inserts a single quote \'");
            Console.WriteLine("This inserts a backslash \\");
            Console.WriteLine("This makes an alert sound\a");
        }
    }
}
