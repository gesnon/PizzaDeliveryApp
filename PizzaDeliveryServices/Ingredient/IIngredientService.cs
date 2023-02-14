using Microsoft.AspNetCore.Mvc;
using PizzaDeliveryDB.Entities;
using PizzaDeliveryServices.DTO.IngredientDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.Services
{
    public interface IIngredientService
    {
        public int Create(IngredientCreateDTO DTO);
        public void Update(IngredientUpdateDTO DTO);
        public void Delete(int Id);
        public Ingredient Get(int id);
        public List<IngredientGetDTO> GetIngredientByName(string Name);
    }
}
