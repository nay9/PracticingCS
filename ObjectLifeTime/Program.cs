using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Make = "oldsmobile";
            myCar.Model = "cutlass";
            myCar.Year = 1111;
            myCar.Color = "blue";

            Car myOtherCar;
            myOtherCar = myCar;


            myOtherCar.Model = "van";

            Car myNewCar = new Car("ford", "fusion", 2012, "blue");
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }



        public Car()
        {


            this.Make = "Nissan";
        }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
    }
}
