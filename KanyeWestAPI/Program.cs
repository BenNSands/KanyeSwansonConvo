using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeWestAPI
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Kanye: ");
                Console.WriteLine(QuoteGenerator.GetKanye());
                Console.WriteLine();
                Console.WriteLine("Swanson:");
                Console.WriteLine(QuoteGenerator.GetSwanson());
                Console.WriteLine();
            }
            
        }
    }
}
