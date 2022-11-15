﻿using Microsoft.AspNetCore.Mvc;
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
        public int CreateIngredient(IngredientCreateDTO DTO);
        public void UpdateIngredient(IngredientUpdateDTO DTO);
        public void DeleteIngredient(int Id);
        public List<IngredientGetDTO> GetIngredientByName(string Name);
    }
}
