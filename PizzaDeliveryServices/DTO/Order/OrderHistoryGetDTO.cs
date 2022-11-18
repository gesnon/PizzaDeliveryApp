using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.DTO.Order
{
    public class OrderHistoryGetDTO
    {
        public int Id { get; set; }
        public int ClientID { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
    }
}
