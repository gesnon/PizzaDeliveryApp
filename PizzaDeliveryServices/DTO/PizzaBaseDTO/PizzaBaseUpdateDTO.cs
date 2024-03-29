﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.DTO.PizzaBaseDTO
{
    public class PizzaBaseUpdateDTO
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public List<int> Ingredients { get; set; } 
    }
}
