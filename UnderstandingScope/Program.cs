using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;

            for (int i = 0; i < 10; i++)
            {
                j = i;
                Console.WriteLine(i);
            }
            Console.WriteLine(j);
            Car myCar = new Car();
            myCar.DoSomething();
        }
    }

    class Car 
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }

        private string helperMethod()
        {
            return "hello";
        }
    }



}
