using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.DTO.PizzaOrderDTO
{
    public class PizzaOrderUpdateDTO
    {
        public int Id { get; set; }
        public int PizzaID { get; set; }
        public int OrderId { get; set; }
    }
}
