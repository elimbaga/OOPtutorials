using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials.Models
{
    class SocialMention : WebData
    {
        public SocialMention(string searchterm)
        {
            //gift+lasta
            this.searchterm = searchterm;
            this.url = @"http://api2.socialmention.com/search?q="+searchterm+"&f=json&t=all";
        }

        public void ParseDataSM()
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
                        title = item["title"].ToString(),
                        description = item["description"].ToString(),
                        link = item["link"].ToString(),
                        source = item["source"].ToString()

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
                Console.WriteLine("Something went wrong, either the value returned is too long or the searched keyword was not found on the list.");
            }
           

        }
    }
}
