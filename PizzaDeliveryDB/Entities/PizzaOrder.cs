using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryDB.Entities
{
    public class PizzaOrder
    {
        public int Id { get; set; }
        public int PizzaID { get; set; }
        public Pizza Pizza { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
