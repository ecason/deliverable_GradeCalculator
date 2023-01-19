// Name: Edward Cason
// Date: 1-19-2023
// Project: C# Grade Calculator 

using System;

namespace deliverable_GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a numeric value.");
            Console.WriteLine(" ");
            try
            {
                decimal grade = decimal.Parse(Console.ReadLine());

                string letter;

                if (grade >= 90)
                {
                    letter = "A";
                    Console.WriteLine("Your grade in the class is " + letter);

                }
                else if (grade >= 80 && grade < 90)
                {
                    letter = "B";
                    Console.WriteLine("Your grade in the class is " + letter);

                }
                else if (grade >= 70 && grade > 80)
                {
                    letter = "C";
                    Console.WriteLine("Your grade in the class is " + letter);
                }
                else if (grade >= 60 && grade > 70)
                {
                    letter = "D";
                    Console.WriteLine("Your grade in the class is " + letter);
                }
                else
                {
                    letter = "F";
                    Console.WriteLine("Your grade in the class is " + letter);
                }
            }
            catch
            {
                Console.WriteLine("A numeric value was not inputted. Try again.");

            }
        }
    }
}