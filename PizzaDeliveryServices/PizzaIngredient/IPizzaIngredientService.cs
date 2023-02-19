using PizzaDeliveryDB.Entities;
using PizzaDeliveryServices.DTO.PizzaIngredient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.Services
{
    public interface IPizzaIngredientService
    {
        public void CreatePizzaIngredient(PizzaIngredientCreateDTO DTO);

        public void GreateAllPizzaIngredients(int PizzaId, List<int> Ingredients);
        
    }
}
