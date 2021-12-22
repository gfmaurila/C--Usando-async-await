using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CShp_Task_T_e_Await
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Informe a url: ");
            var url = Console.ReadLine();

            // Ex 1: 
            //var resultado = await GetHtml(url);

            //Console.WriteLine(resultado.Substring(0, 150));
            //Console.ReadKey();

            // Ex 2
            //Task<string> minhaTask = GetHtml(url);
            //await minhaTask;
            //var resultado = minhaTask.Result;

            //Console.WriteLine(resultado.Substring(0, 150));
            //Console.ReadKey();

            // Ex 3
            (bool sucesso, string html) = await GetHtmlTupla(url);
            if(sucesso)
            {
                Console.WriteLine(html.Substring(0, 150));
                Console.ReadKey();
            }
        }

        static async Task<string> GetHtml(string url)
        {
            Console.WriteLine("Informe a url: ");
            if (string.IsNullOrEmpty(url))
            {
                return null;
            }

            string html = await new HttpClient().GetStringAsync(url);
            Console.WriteLine("Retornando de GetHtml");
            return html;
        }

        static async Task<(bool, string)> GetHtmlTupla(string url)
        {
            Console.WriteLine("Informe a url: ");
            if (string.IsNullOrEmpty(url))
            {
                return (false, null);
            }

            string html = await new HttpClient().GetStringAsync(url);
            Console.WriteLine("Retornando de GetHtml");
            return (true, html);
        }
    }
}
