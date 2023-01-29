using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryDB.Entities
{
    public class Pizza
    {
        public int Id { get; set; }
        public PizzaBase PizzaBase { get; set; }
        public int PizzaBaseID { get; set; }
        public PizzaCharacteristic PizzaCharacteristic { get; set; }
    }
}
