using PizzaDeliveryServices.DTO.PizzaOrderDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.DTO.Order
{
    public class OrderGetDTO
    {
        public int Id { get; set; }
        public int ClientID { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public List<PizzaOrderGetDTO> PizzaOrdersDTO { get; set; }
    }
}
