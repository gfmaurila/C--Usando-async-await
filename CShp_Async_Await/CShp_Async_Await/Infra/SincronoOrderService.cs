using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CShp_Async_Await.Infra
{
    public class SincronoOrderService
    {
        public static void GetCustumerOrder(int id)
        {
            List<Pedidos> pedidosList;
            pedidosList = new List<Pedidos>();
            pedidosList.Add(new Pedidos(100, 10, DateTime.Now, "Av vai e vem 910"));
            pedidosList.Add(new Pedidos(101, 10, DateTime.Now, "Av vai e vem 910"));
            pedidosList.Add(new Pedidos(102, 10, DateTime.Now, "Av vai e vem 910"));
            pedidosList.Add(new Pedidos(103, 11, DateTime.Now, "Av vai e vem 911"));
            pedidosList.Add(new Pedidos(104, 11, DateTime.Now, "Av vai e vem 911"));
            pedidosList.Add(new Pedidos(105, 11, DateTime.Now, "Av vai e vem 911"));

            var pedidos = pedidosList.Where(f => f.ClienteId == id).ToList();
            MostraPedido(pedidos);
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
