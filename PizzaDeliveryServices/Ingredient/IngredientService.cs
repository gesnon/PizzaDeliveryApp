using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PizzaDeliveryDB;
using PizzaDeliveryDB.Entities;
using PizzaDeliveryServices.DTO.IngredientDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.Services
{
    public class IngredientService: IIngredientService
    {
        private readonly ContextDB context;
        private readonly IMapper mapper;

        public IngredientService(ContextDB context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public int CreateIngredient(IngredientCreateDTO DTO)
        {
            Ingredient ingredient = mapper.Map<Ingredient>(DTO);

            context.Ingredients.Add(ingredient);

            context.SaveChanges();

            return ingredient.Id;
        }

        public void UpdateIngredient(IngredientUpdateDTO DTO)
        {
            Ingredient ingredient = context.Ingredients.FirstOrDefault(_ => _.Id == DTO.Id);

            if (ingredient == null)
            {
                throw new NotFoundExeption("Ингридиент не найден");
            }
            ingredient.Name = DTO.Name;
            context.SaveChanges();
        }
        public void DeleteIngredient(int Id)
        {
            Ingredient ingredient = context.Ingredients.FirstOrDefault(_ => _.Id == Id);

            if (ingredient == null)
            {
                throw new NotFoundExeption("Ингридиент не найден");
            }
            context.Ingredients.Remove(ingredient);
            context.SaveChanges();
        }
        public List<IngredientGetDTO> GetIngredientByName(string Name)
        {
            var query = context.Ingredients.AsQueryable();

            if (!string.IsNullOrEmpty(Name))
            {
                query = query.Where(_ => _.Name.Contains(Name));
            }

            List<IngredientGetDTO> list = query.Select(_ => mapper.Map<IngredientGetDTO>(_)).ToList();

            return list;
        }
        public Ingredient GetIngredient(int id)
        {
            Ingredient result = context.Ingredients.FirstOrDefault(_ => _.Id == id);
            if (result == null)
            {
                throw new NotFiniteNumberException("Ингридиент не найден");
            }
            return result;
        }

    }
}
