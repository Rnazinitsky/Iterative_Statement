/* Author: Robert Nazinitsky
 * Class: ISM 4300
 * Date: 9/12/19
 * Description: Takes an integer value between 1 and 100 and displays a designated message
 */using System;

namespace Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter an integer between 1 and 100: ");
                int user_Integer = int.Parse(Console.ReadLine());
                if (user_Integer >= 1 && user_Integer <= 100)
                {
                    for (int i = 1; i <= user_Integer; i++)
                    {
                        Console.WriteLine("You have entered #" + user_Integer + ". This is the current integer value in the loop: " + i);
                    }
                }
            }
            catch
            {
                Console.WriteLine("There was an error displaying the messages. Please enter an integer between 1 and 100.");
            }

        }
    }
}
