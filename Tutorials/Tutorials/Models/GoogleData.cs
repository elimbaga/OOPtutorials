using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorials.Models;

namespace Tutorials.Models
{
    class GoogleData : WebData
    {
      


        public GoogleData() 
        {
            this.url = @"https://www.googleapis.com/books/v1/volumes?q=storm&key=AIzaSyAuYh918Pn760L5whpCozRFuD8JQsw_r7Q";
        }

        public void ParseData()
        {
            var result = this.DoRequest();

            var returnData = result["items"].ToList();

            List<Result> ResultsList = new List<Result>();

            foreach (var item in returnData)
            {

                ResultsList.Add(new Result() {

                    id = item["id"].ToString(),
                    title = item["volumeInfo"]["title"].ToString(),
                    description = item["volumeInfo"]["description"].ToString(),
                    link = item["volumeInfo"]["infoLink"].ToString(),
                    source = item["selfLink"].ToString()

                });
            }

            foreach (var asd in ResultsList)
            {
                Console.WriteLine("ID: " + asd.id);
                Console.WriteLine("Title: " + asd.title);
                Console.WriteLine("Description: " + asd.description);
                Console.WriteLine("Link: " + asd.link);
                Console.WriteLine("Source: " + asd.source);
                Console.WriteLine();
                Console.WriteLine();
            }
        }

    }
}
