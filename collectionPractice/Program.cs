using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "toyota";
            car1.Model = "supra";

            Car car2 = new Car();
            car1.Make = "subaru";
            car1.Model = "brz";

            Book b1 = new Book();
            b1.Author = "rob";
            b1.Title = "book title";
            b1.ISBN = "00-000-000";

            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);


            //Dictionary<TKey, Tvalue>
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();

            myDictionary.Add(car1.Vin, car1);
            myDictionary.Add(car2.Vin, car2);


            Car car3 = new Car() { Make = "bmw", Model = "z4", Vin = "sfasfasdfsa" };


        }


        class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public string Vin { get; set; }
        }

        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
        }
    }
}
