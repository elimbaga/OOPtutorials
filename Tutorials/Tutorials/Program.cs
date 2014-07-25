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
            Console.WriteLine("[4] Error Exception");
            Console.WriteLine("[5] Generics");
            Console.Write("Choose option: ");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (value)
            {

                case 1:
                    FirstChallenge("FOR LOOPS");
                    break;

                case 2:

                    int numbah1;
                    int numbah2;

                    Console.Write("Enter numbah1: ");
                    numbah1 = Convert.ToInt32(Console.ReadLine());
                    
                    Console.Write("Enter numbah2: ");
                    numbah2 = Convert.ToInt32(Console.ReadLine());
                    
                    SecondChallenge(numbah1 , numbah2);
                    break;

                case 3:

                    ThirdChallenge("Instance");
                    break;

                case 4:

                    FourthChallenge("Exception Error");
                    break;

                case 5:

                    FifthChallenge("Generics");
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

            Instance.Make = "Mitsubishi number 1";
            Instance.Model = "Montero";
            Instance.Color = "blue";

            Instance.DisplayInfo();
            Instance.Drive();
            Instance.Stop();

            Console.WriteLine();
        }

        static void FourthChallenge(string option)
        {
            Console.WriteLine(option);

            int intValue = 32;
            object objValue = intValue;
            string strValue;
            string errormessage;
                
            

            try
            {
               strValue = (string)objValue;
            }
            catch (Exception e)
            {
                errormessage = e.Message;

                Console.WriteLine();
                Console.WriteLine(errormessage);
            }

        }

        static void FifthChallenge(string option)
        {
            Console.WriteLine();
            Console.WriteLine(option);

            SortedList<string, string> strList = new SortedList<string, string>();
            strList.Add("1", "numbah1");
            strList.Add("2", "numbah2");
            strList.Add("3", "numbah3");
            


        }
         
       
    }
}

