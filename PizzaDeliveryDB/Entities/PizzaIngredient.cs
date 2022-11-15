using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryDB.Entities
{
    public class PizzaIngredient
    {
        public int Id { get; set; }
        public int IngredientID { get; set; }
        public Ingredient Ingredient { get; set; }  
        public int PizzaBaseID { get; set; }
        public PizzaBase PizzaBase { get; set; }
    }
}
