using CShp_Async_Await.Infra;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CShp_Async_Await
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o Id do cliente");
            var id = Console.ReadLine();
            //SincronoOrderService.GetCustumerOrder(Convert.ToInt32(id));
            AsyncAwaitOrderService.GetCustumerOrder(Convert.ToInt32(id));
            Console.WriteLine("Aguardando ...");
            Console.ReadLine();
        }
    }

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services) => services.AddDbContext<AppDbContext>();
    }
}
