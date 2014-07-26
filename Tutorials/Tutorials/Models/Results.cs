using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials.Models
{
    class Results : Result
    {

        private List<Result> dataresult = new List<Result>();
        private int total;
        private string searchterm;




        public void sample()
        {
            foreach (Result asd in this.dataresult)
            {
                Console.WriteLine("asdasd");
                Console.WriteLine(asd);
            }
        }
    }
}
