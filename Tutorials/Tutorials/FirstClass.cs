using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    class FirstClass
    {
        private string Word;
        private string Color;
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
