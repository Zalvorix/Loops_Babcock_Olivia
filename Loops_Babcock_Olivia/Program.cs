using System;

namespace Loops_Babcock_Olivia
{
    class Program
    {
        static void Main(string[] args)
        {   /// Asks the user if they want to make games. 
            Console.WriteLine("Why do you want to make games?");
            string response = Console.ReadLine();
            /// Tells the amount of spaces in the response sentence.
            Console.WriteLine($"The sentence,\"{response}\" has {CountNumberofSpaces(response)} spaces in it.");

            /// Asks the user to enter a whole number.
            Console.WriteLine("Please enter a whole number!");
            string response2 = Console.ReadLine();
            /// Gives the user the sum of the number they entered.
            Console.WriteLine($"The sum of the individual digits of {response2} is {SumOfDigits(response2)}!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sentence">The sentence to count number of spaces</param>
        /// <returns>Number of spaces in the sentence</returns>
        static int CountNumberofSpaces(string sentence)
        {
            int numberOfSpaces = 0;
            foreach(char character in sentence)
            {
                if(character == ' ')
                {
                    numberOfSpaces++;
                }
            }
            return numberOfSpaces;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number">The number to find the sum of</param>
        /// <returns>Sum of the number entered</returns>
        static int SumOfDigits(string number)
        {
            int sum = 0;
            foreach(char digit in number)
            {
                sum += (int)Char.GetNumericValue(digit);
            }
            return sum;
        }
    }
}
