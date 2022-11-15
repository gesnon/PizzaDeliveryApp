using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.DTO.PizzaIngredient
{
    public class PizzaIngredientCreateDTO
    {
        public int IngredientID { get; set; }
        public int PizzaBaseID { get; set; }
    }
}
