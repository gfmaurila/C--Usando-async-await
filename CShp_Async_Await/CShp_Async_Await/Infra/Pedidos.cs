using System;
using System.Collections.Generic;
using System.Text;

namespace CShp_Async_Await.Infra
{
    public class Pedidos
    {
        public Pedidos(int id, int clienteId, DateTime dt, string destino)
        {
            this.Id = id;
            this.ClienteId = clienteId;
            this.Dt = dt;
            this.Destino = destino;
        }

        public int Id { get; set; }
        public int ClienteId { get; set; }
        public DateTime Dt { get; set; }
        public string Destino { get; set; }
    }
}
