﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryDB.Entities
{
    public class PizzaCharacteristic
    {
        public int Id { get; set; }
        public Size Size { get; set; }
        public int Diameter { get; set; }
        public int Weight { get; set; }    
        public decimal Price { get; set; }
    }
}
