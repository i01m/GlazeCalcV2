using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlazeCalcV2
{
    class Program
    {
        static void handleStandard()
        {
           
            string widthString, heightString;
            double width, height, woodLength, glassArea, x = 0;
            const double MAX_WIDTH = 5.0;
            const double MIN_WIDTH = 0.5;
            const double MAX_HEIGHT = 3.0;
            const double MIN_HEIGHT = 0.75;


            do
            {
                Console.Write("Enter the width of the window between " +
                MIN_WIDTH + " and " + MAX_WIDTH + " :\n");
                widthString = Console.ReadLine();
                if (!double.TryParse(widthString, out x))
                {
                    Console.WriteLine("{0} is not a number", widthString);
                    Console.WriteLine();
                    Console.WriteLine("Enter the width of the window between " +
                    MIN_WIDTH + " and " + MAX_WIDTH + " :\n");
                    Console.WriteLine();
                    widthString = Console.ReadLine();
                }


                width = double.Parse(widthString);
            } while (width < MIN_WIDTH || width > MAX_WIDTH);



            do
            {
                Console.Write("Enter the height of the window between " +
                MIN_HEIGHT + " and " + MAX_HEIGHT + " : \n");
                heightString = Console.ReadLine();
                height = double.Parse(heightString);
            } while (height < MIN_HEIGHT || height > MAX_HEIGHT);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
                woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
                glassArea + " square metres");

        }

        static void handlePatio()
        {
            Console.WriteLine("handlePatio method");
        }

        static void Main(string[] args)
        {
            Console.Write("type the window option : (1)patio or (2)standard  ");
            string choice = Console.ReadLine();
            string choiceNumber = Convert.ToString(choice);

            switch (choice.ToLower())
            
            {
                case "1":
                case "standard":
                    handleStandard();
                    break;
                case "2":
                case "patio":
                    handlePatio();
                    break;
                default:
                    Console.WriteLine("invalid window's option");
                    break;
            }

            Console.ReadKey();
            
            
           












        }
    }
}
