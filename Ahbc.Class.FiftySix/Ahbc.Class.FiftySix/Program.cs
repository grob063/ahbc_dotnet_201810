using System;
using System.Net.Http;

namespace Ahbc.Class.FiftySix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What does Chuck say?");

            var client = new HttpClient();
            var result = client.GetAsync("https://api.chucknorris.io/jokes/random").Result;
            result.EnsureSuccessStatusCode();

            //// This would just return raw json.  Hard to parse :(
            //var content = result.Content.ReadAsStringAsync().Result;
            //Console.WriteLine(content);

            // This parse the json into our object
            var content = result.Content.ReadAsAsync<ChuckNorrisResponse>().Result;
            Console.WriteLine($"content.Value = {content.Value}");
            Console.WriteLine($"content.Url = {content.Url}");
            Console.WriteLine($"content.Id = {content.Id}");
            Console.ReadKey();
        }
    }

    public class ChuckNorrisResponse
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public string Value { get; set; }
    }
}
