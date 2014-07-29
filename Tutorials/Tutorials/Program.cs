using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorials.Models;

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
            Console.WriteLine("[4] Error exception");
            Console.WriteLine("[5] Generics");
            Console.WriteLine("[6] Google docs");
            Console.WriteLine("[7] Social mention");
            Console.WriteLine("[8] asdasdd");
            Console.Write("Choose option: ");

            int value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch (value)
            {

                case 1:

                    FirstChallenge("FOR LOOPS");
                    break;

                case 2:

                    SecondChallenge("Add integer");
                    break;

                case 3:

                    ThirdChallenge("Instance");
                    break;

                case 4:

                    FourthChallenge("Exception error");
                    break;

                case 5:

                    FifthChallenge("Generics");
                    break;

                case 6:

                    GoogleDocs("Google docs");
                    break;

                case 7:

                    SocialMention("Social mention");
                    break;

                case 8:

                    WebRequest("Web request");
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

        static void SecondChallenge(string option)
        {
            Console.WriteLine();
            Console.WriteLine(option);

            int numbah1;
            int numbah2;

            Console.Write("Enter numbah1: ");
            numbah1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter numbah2: ");
            numbah2 = Convert.ToInt32(Console.ReadLine());
                    

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

            SortedList<int, string> strList = new SortedList<int, string>();
            strList.Add(1, "numbah1");
            strList.Add(2, "numbah2");
            strList.Add(3, "numbah3");

            Console.WriteLine();
            //Prints the data inside the list.
            for (int i = 1; i <= strList.Count; i++)
            {
                Console.WriteLine(strList[i]);
            }

            List<string> stringlist = new List<string>();
            stringlist.Add("numbah1");
            stringlist.Add("numbah2");
            stringlist.Add("numbah3");


            Console.WriteLine();
            foreach (string asd in stringlist)
            {
                Console.WriteLine(asd);
            }

        }

        static void GoogleDocs(string option) 
        {
            Console.WriteLine();
            Console.WriteLine(option);

            Console.Write("Enter search term: ");
            var search = Console.ReadLine();
            Console.WriteLine();

            GoogleData data = new GoogleData(search);
            data.ParseData();

        }

        static void SocialMention(string option)
        {
            Console.WriteLine();
            Console.WriteLine(option);

            Console.Write("Enter search term: ");
            var search = Console.ReadLine();
            Console.WriteLine();

            SocialMention data = new SocialMention(search);
            data.ParseDataSM();

        }

        static void WebRequest(string option)
        {
            Console.WriteLine();
            Console.WriteLine(option);
            
            Console.Write("Enter search term: ");

            var search = Console.ReadLine();

            //char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

            //string[] words = search.Split(delimiterChars);
            //search = "";
            //foreach (string s in words)
            //{
            //    search = string.Concat("string1", s);
            //    search = string.Concat("string1", );
            //    System.Console.WriteLine(s);
            //}

            SocialMention data = new SocialMention(search);
            data.ParseDataSM();

            GoogleData data2 = new GoogleData(search);
            data2.ParseData();

        }
       
    }
}

