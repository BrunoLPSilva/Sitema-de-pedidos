using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_product_orders.application.DTOs
{
    public class CriarPedidoDTO
    {
        public string Cliente { get; set; }
        public List<ItemPedidoDTO> Itens { get; set; }

        public string Status { get; set; }
    }
}
