﻿using AutoMapper;
using PizzaDeliveryDB;
using PizzaDeliveryDB.Entities;
using PizzaDeliveryServices.DTO.PizzaIngredient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.Services
{
    public class PizzaIngredientService: IPizzaIngredientService
    {
        private readonly ContextDB context;
        private readonly IMapper mapper;

        public PizzaIngredientService(ContextDB context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public void CreatePizzaIngredient(PizzaIngredientCreateDTO DTO)
        {
            PizzaIngredient pizzaIngredient = mapper.Map<PizzaIngredient>(DTO);
            
            context.PizzaIngredients.Add(pizzaIngredient);

            context.SaveChanges();
        }

        public void GreateAllPizzaIngredients(int PizzaId, List<int> Ingredients)
        {
            PizzaIngredientCreateDTO dto = new PizzaIngredientCreateDTO();
            foreach (int i in Ingredients)
            {
                dto.PizzaBaseID = PizzaId;
                dto.IngredientID = i;
                PizzaIngredient pizzaIngredient = mapper.Map<PizzaIngredient>(dto);
                context.PizzaIngredients.Add(pizzaIngredient);
            }
            context.SaveChanges();
        }
    }
}
