using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials.Models
{
    class SampleModelClass
    {

        private int numbah = 123;
        private string letah = "string";

        public int Numbah
        {
            get { return this.numbah; }
            set {
                    if (value.GetType() == typeof(int))
                    {
                        this.numbah = value;
                    }
                    else 
                    {
                        Console.WriteLine("Please input integer values only");
                    }
                }
        }

        public string Letah
        {
            get { return this.letah; }
            set
            {
                if (value.GetType() == typeof(string))
                {
                    this.letah = value;
                }
                else
                {
                    Console.WriteLine("Please input string values only");
                }
            }
        }

    }
}
