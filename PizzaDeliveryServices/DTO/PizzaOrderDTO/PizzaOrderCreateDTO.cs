using PizzaDeliveryDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.DTO.PizzaOrderDTO
{
    public class PizzaOrderCreateDTO
    {
        public int PizzaBazeID { get; set; }
        public Size Size { get; set; }
        public int OrderId { get; set; }
    }
}
