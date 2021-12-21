using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CShp_Async_Await.Infra
{
    public class AsyncAwaitOrderService
    {
        public async static void GetCustumerOrder(int id)
        {
            using (var db = new AppDbContext("Server=localhost,1433; Database=gfmaurila; User ID=sa; Password=*****"))
            {
                var pedidos = await db.pedidos.Where(f => f.ClienteId == id).ToListAsync();
                if(pedidos!=null)
                {
                    MostraPedido(pedidos);
                }
                else
                {
                    Console.WriteLine("Nenhum resultado...");
                }
            }
        }

        public static void MostraPedido(List<Pedidos> pedidos)
        {
            Console.WriteLine("Cliente ID: "+pedidos[0].ClienteId);
            foreach (Pedidos p in pedidos)
            {
                Console.WriteLine("Id: " + p.Id + " - Data: " + p.Dt + " - Destino: " + p.Destino);
            }
            Console.ReadKey();
        }
    }
}
