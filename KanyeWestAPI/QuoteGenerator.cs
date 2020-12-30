using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json.Linq;


namespace KanyeWestAPI
{
    class QuoteGenerator
    {
        public static string GetKanye()
        {
            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest/";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            return kanyeQuote;
        }

        public static string GetSwanson()
        {
            var client = new HttpClient();
            var swansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var swansonResponse = client.GetStringAsync(swansonURL).Result;
            //Console.WriteLine(kanyeResponse);

            var swansonQuote = JArray.Parse(swansonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            //var swansonQuote = JObject.Parse(swansonResponse).GetValue("quote").ToString();
            return swansonQuote;
        }
    }
}
