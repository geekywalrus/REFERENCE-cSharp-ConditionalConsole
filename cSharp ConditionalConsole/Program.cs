using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_ConditionalConsole // Oooo fancy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How old are you? Type age: "); // Ask user what their age is
            int age = Convert.ToInt32(Console.ReadLine()); // Store their input for later use
            // Check if age is less than or equal to 18
            if (age < 18)
            { // If it is, inform them they are not allowed.
                Console.WriteLine(); // New blank line because it's pretty
                Console.WriteLine("o no bby u r 2 yung srry bye bye :ccc"); // Sarcastic response
                Console.ReadKey(); // Wait for user input before closing console
                                   // Extra check. Essentially: "If user is less than 18, no. If user inputs exactly 18 then do below code.
            }
            else if (age == 18)
            { // User says age is 18
                Console.WriteLine(); // New blank line because it's pretty
                Console.WriteLine("Saying that is like clicking 'I'm over 18' on rule34. You know you're not, but you can't help but lie."); // Sarcastic response
                Console.ReadKey(); // Wait for user input before closing console
                                   // If age is higher than and NOT equal to 18, they're old so be sarcastic.
            }
            else
            {
                Console.WriteLine(); // New blank line because it's pretty
                Console.WriteLine("hi old dood, welcome."); // Sarcastic response
                Console.ReadKey(); // Wait for user input before closing console
            }
        }
    }
}
