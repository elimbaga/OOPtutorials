using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Options");
            Console.WriteLine("[1] Loops");
            Console.WriteLine("[2] Add using a function");
            Console.WriteLine("[3] Instance");
            Console.Write("Choose option: ");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (value)
            {

                case 1:
                    FirstChallenge("FOR LOOPS");
                    break;

                case 2:
                    Console.Write("Enter numbah1: ");
                    int numbah1 = Convert.ToInt32(Console.ReadLine());
                    
                    Console.Write("Enter numbah2: ");
                    int numbah2 = Convert.ToInt32(Console.ReadLine());
                    
                    SecondChallenge(numbah1 , numbah2);
                    break;

                case 3:

                    ThirdChallenge("Instance");
                    break;

                default:
                    Console.WriteLine("Value not present");
                    break;

            }
            

       
            
        }

        static void FirstChallenge(string option)
        {
            Console.WriteLine(option);
            for (int counter = 1; counter < 11; counter++)
            {
                Console.WriteLine(counter);


            }
        }

        static void SecondChallenge(int numbah1 , int numbah2)
        {
            int sum = numbah1 + numbah2;
            Console.WriteLine();
            Console.WriteLine("The sum is: "+ sum);
            Console.WriteLine();
            
        }

        static void ThirdChallenge(string option)  
        {
            Console.WriteLine(option);

            Car Instance = new Car();

            Instance.Make = "Mitsubishi";
            Instance.Model = "Montero";
            Instance.Color = "blue";

            Instance.DisplayInfo();
            Instance.Drive();
            Instance.Stop();

            Console.WriteLine();
        }
    }
}
