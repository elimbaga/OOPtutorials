using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Tutorials.Models
{
    class WebData 
    {
        public string url { get; set; }
        public string searchterm { get; set; }



        public JObject DoRequest()
        {

            var webRequest = WebRequest.Create(this.url);
            using (var response = webRequest.GetResponse())
            {
                using (var content = response.GetResponseStream())
                {
                    using (var reader = new StreamReader(content))
                    {
                        var strContent = reader.ReadToEnd();
                        JObject obj = JObject.Parse(strContent);

                        return obj;
                        //var items = obj["items"].ToList();
                        //foreach (var item in items)
                        //{
                        //    var tmp = item["volumeInfo"]["title"].ToString();
                        //}
                    }
                }
            }


        }
        
    }
}
