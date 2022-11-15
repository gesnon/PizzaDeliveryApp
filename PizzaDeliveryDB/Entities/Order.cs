﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryDB.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientID { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public List<PizzaOrder> PizzaOrders { get; set; }
    }
}
