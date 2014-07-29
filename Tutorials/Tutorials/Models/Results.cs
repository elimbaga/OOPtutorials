using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials.Models
{
    class Results : Result
    {

        public List<Result> dataresult = new List<Result>();
        public int total;
        public string searchterm;

    }
}
