using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    class FirstClass
    {
        private string word;
        private string color;
        private int numbah;

        public int Numbah
        {
            get { return this.numbah; }
            
            set 
            {
                if (value > 0)
                {
                    this.numbah = value;
                }
                else
                {
                    Console.WriteLine("Number Must not be less then 0");
                }
                
            
            }
        }

        public string Word
        {
            get { return this.word; }

            set 
            {

                try
                {
                    this.word = value;
                }
                catch(Exception ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }

        public string Color
        {
            get { return this.color; }

            set
            {

                try
                {
                    this.color = value;
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }
            }
        }

        public void function1()
        {
            Console.WriteLine("Function numbah1");
            Console.WriteLine();
        }

        public void function2() 
        { 
            Console.WriteLine("Function numbah2");
            Console.WriteLine();
        }

    }
}
