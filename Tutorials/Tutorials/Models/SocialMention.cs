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
            this.url = @"http://api2.socialmention.com/search?q=" +searchterm + "&f=json&t=all";
        }

        public void ParseDataSM()
        {
            var result = this.DoRequest();

            var returnData = result["items"].ToList();

            Results ResultData = new Results();

            int count = 0;

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

            foreach (var asd in ResultData.dataresult)
            {
                Console.WriteLine("ID: " + asd.id);
                Console.WriteLine("Title: " + asd.title);
                Console.WriteLine("Description: " + asd.description);
                Console.WriteLine("Link: " + asd.link);
                Console.WriteLine("Source: " + asd.source);
                Console.WriteLine();
                Console.WriteLine();
            }

            ResultData.searchterm = this.searchterm;
            ResultData.total = count;

            Console.WriteLine("Searched keyword:" + ResultData.searchterm);
            Console.WriteLine("Search count:" + ResultData.total);

            Console.WriteLine();

        }
    }
}
