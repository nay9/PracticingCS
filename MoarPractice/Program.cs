using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoarPractice
{
    class Program
      {
          static void Main(string[] args)
        /* First section of code starts
         * simple IF statements
           {
             Console.WriteLine("Nay's Giveaway");
             Console.Write("Choose a door: 1 2 3:");
             string message = "";

             string userValue = Console.ReadLine();
             if (userValue == "1")
             {
                  message = "You win a new Tomato themed Car!";
             }
             else if (userValue == "2")
             {
                  message = "You win a used 1920s Boat!!";
             }
             else if (userValue == "3")
             {
                  message = "You win a blender, but the blades are warped.";
             } else
             {
                  message = "you must enter a 1, a 2, or a 3.";
             }

             Console.WriteLine(message);



             Console.ReadLine();


        }   First section of code ends
            
         */

        /*
         * start of code
    {
        Console.WriteLine("What is your name?");
        Console.Write("Type your first name in: ");
        string myFirstName = Console.ReadLine();

        Console.Write("Type your last name in: ");
        string myLastName = Console.ReadLine();

        Console.WriteLine("Hello, " + myFirstName + " "  + myLastName);



    }  end of code
        */

        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 9)
                 {
                    Console.WriteLine("This will be the last number");
                    break;
                }

            }
            Console.WriteLine("The loop has finished");
            Console.ReadLine();
        }
      }


}
