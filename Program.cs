using System;
using System.Reflection.Metadata;
using System.Text;
using System.Globalization;

namespace NumberGuesser
{

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Insert number: ");

            int userInput = int.Parse(Console.ReadLine());

            int sum = 0;
            int? maxValue = null;



            while (userInput != 0)
            {
                if (maxValue == null || userInput > maxValue)
                {
                    maxValue = userInput;

                }
                sum += userInput;

                userInput = int.Parse(Console.ReadLine());

            }

            Console.WriteLine($"Sum of numbers = {sum}");
            if (maxValue != null)
            {
                Console.WriteLine($"MaxValue = {maxValue}");

            }
            else
            {
                Console.WriteLine("MaxValue isn't correct");
            }


        }
    }
}