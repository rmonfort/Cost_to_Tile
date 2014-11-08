using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_to_Tile
{
    class Flooring_Estimator
    {
        public int Width { get; set; }
        public int Length { get; set; }
        public decimal CostPerUnitOfFlooring { get; set; }

        public Flooring_Estimator() { }
        public Flooring_Estimator(int width, int length, decimal costPerUnitOfFlooring)
        {
            Width = width;
            Length = length;
            CostPerUnitOfFlooring = costPerUnitOfFlooring;
        }

        public void DisplayCostOfFlooring()
        {
            Console.WriteLine("Total Cost of Flooring: {0:C}", Width * Length * CostPerUnitOfFlooring);
        }
    }
}
