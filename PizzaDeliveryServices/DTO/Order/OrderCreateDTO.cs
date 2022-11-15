using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.DTO.Order
{
    public class OrderCreateDTO
    {
        public int ClientID { get; set; }        
        public DateTime Date { get; set; }
        public List<int> PizzaOrders { get; set; }
    }
}
