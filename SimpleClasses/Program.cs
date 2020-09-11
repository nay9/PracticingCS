using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Car myCar = new Car();
            myCar.Make = "oldsmobile";
            myCar.Model = "Cutlass Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            decimal value = DetermineMarketValue(myCar);
            Console.WriteLine(value);
        }

        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 100.00M;

            return carValue;
        }



    }


    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }
}
