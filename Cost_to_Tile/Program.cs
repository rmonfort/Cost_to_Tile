using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_to_Tile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks user for width of area and validate input
            Console.Write("Please enter the width of the area you intend to tile: ");
            string userInput = Console.ReadLine();
            int width;
            while (!Int32.TryParse(userInput, out width))
            {
                Console.WriteLine("You've entered an invalid input.\n");
                Console.Write("Please enter the width of the area you intend to tile: ");
                userInput = Console.ReadLine();
            }

            // Asks user for length of area and validate input
            int length;
            Console.Write("Please enter the length of the area you intend to tile: ");
            userInput = Console.ReadLine();
            while (!Int32.TryParse(userInput, out length))
            {
                Console.WriteLine("You've entered an invalid input.\n");
                Console.Write("Please enter the length of the area you intend to tile: ");
                userInput = Console.ReadLine();
            }

            // Asks user for cost per one unit of flooring and validate input
            decimal costPerUnitOfFlooring;
            Console.Write("Please enter the cost per one unit of flooring: ");
            userInput = Console.ReadLine();
            while (!decimal.TryParse(userInput, out costPerUnitOfFlooring))
            {
                Console.WriteLine("You've entered an invalid input.\n");
                Console.Write("Please enter the cost per one unit of flooring: ");
                userInput = Console.ReadLine();
            }

            // Create Flooring Estimator object, load values obtained into it, and display the total cost of flooring
            Flooring_Estimator floor = new Flooring_Estimator(width, length, costPerUnitOfFlooring);
            floor.DisplayCostOfFlooring();
        }
    }
}
