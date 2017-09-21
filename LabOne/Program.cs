using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            do
            {
                double length;
                double width;
                double area;
                double perimeter;
                string calculateAgain;

                Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

                //Prompt the user to enter the values for the length and width of the classroom
                Console.Write("Enter length: ");
                length = double.Parse(Console.ReadLine());
                Console.Write("Enter width: ");
                width = double.Parse(Console.ReadLine());

                //Calculate area
                area = length * width;

                //Calculate perimeter
                perimeter = 2 * (length + width);

                //Display the area and perimeter to the user
                Console.WriteLine("The area is: " + area);
                Console.WriteLine("The perimeter is: " + perimeter);
                
                //Prompt the user to see if they would like to continue
                Console.Write("Would you like to continue? Enter Y/N ");
                calculateAgain = Console.ReadLine();
                if ((calculateAgain == "Y") || (calculateAgain == "y"))
                {
                    repeat = true;
                }
                else if ((calculateAgain == "N") || (calculateAgain == "n"))
                {
                    repeat = false;
                }

                Console.WriteLine();

            } while (repeat == true);
        }
    }
}
