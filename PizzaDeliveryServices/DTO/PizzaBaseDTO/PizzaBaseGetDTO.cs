using PizzaDeliveryServices.DTO.PizzaIngredient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.DTO.PizzaBaseDTO
{
    public class PizzaBaseGetDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<PizzaIngredientGetDTO> pizzaIngredientsDTO { get; set; }
        
    }
}
