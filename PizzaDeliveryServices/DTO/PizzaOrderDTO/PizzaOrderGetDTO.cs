using PizzaDeliveryServices.DTO.PizzaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.DTO.PizzaOrderDTO
{
    public class PizzaOrderGetDTO
    {
        public int Id { get; set; }
        public int PizzaID { get; set; }
        public PizzaGetDTO PizzaDTO { get; set; }
    }
}
