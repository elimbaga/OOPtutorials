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
      
        public GoogleData(string searchterm) 
        {
            //use storm as the keyword for the search
            this.searchterm = searchterm;
            this.url = @"https://www.googleapis.com/books/v1/volumes?q="+searchterm+"&key=AIzaSyAuYh918Pn760L5whpCozRFuD8JQsw_r7Q";
           
        }

        public void ParseData()
        {
            var result = this.DoRequest();

 
            var returnData = result["items"].ToList();
            
            Results ResultData = new Results();
           
            int count = 0;

            try
            {
                foreach (var item in returnData)
                {

                    count += 1;

                    ResultData.dataresult.Add(new Result()
                    {

                        id = item["id"].ToString(),
                        title = item["volumeInfo"]["title"].ToString(),
                        description = item["volumeInfo"]["description"].ToString(),
                        link = item["volumeInfo"]["infoLink"].ToString(),
                        source = item["selfLink"].ToString()

                    });
                }

                foreach (var data in ResultData.dataresult)
                {
                    Console.WriteLine("ID: " + data.id);
                    Console.WriteLine("Title: " + data.title);
                    Console.WriteLine("Description: " + data.description);
                    Console.WriteLine("Link: " + data.link);
                    Console.WriteLine("Source: " + data.source);
                    Console.WriteLine();
                    Console.WriteLine();
                }

                ResultData.searchterm = this.searchterm;
                ResultData.total = count;

                Console.WriteLine("Searched keyword:" + ResultData.searchterm);
                Console.WriteLine("Search count:" + ResultData.total);

                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Something went wrong either the returned values was to large or the searched keyword is not found on the list.");
            }
            

        
        }

    }
}
