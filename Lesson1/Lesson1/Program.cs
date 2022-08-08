using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        private static async Task ProcessRepositories(int i)
        {
            using var client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/" + i.ToString());
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            // Above three lines can be replaced with new helper method below
            // string responseBody = await client.GetStringAsync(uri);
            clID cl = JsonSerializer.Deserialize<clID>(responseBody);
            Console.WriteLine(cl.id + ";");
            Console.WriteLine(cl.userId + ";");
            Console.WriteLine(cl.title + ";");
            Console.WriteLine(cl.body + ";");
            //Запись в файл
            StreamWriter sw = new StreamWriter(Environment.CurrentDirectory.ToString()+"\\result.txt", true, Encoding.ASCII);
            sw.WriteLine(cl.id); sw.WriteLine(cl.userId); sw.WriteLine(cl.title); sw.WriteLine(cl.body);

            sw.Close();
        }

        static async Task Main(string[] args)
        {
            for (int j = 4; j < 14; j++)
            {
                await ProcessRepositories(j);
            }
        }
    }
}
