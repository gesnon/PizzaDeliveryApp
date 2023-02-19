using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PizzaDeliveryDB;
using PizzaDeliveryDB.Entities;
using PizzaDeliveryServices.DTO.PizzaBaseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.Services
{
    public class PizzaBaseService: IPizzaBaseService
    {
        private readonly ContextDB context;
        private readonly IMapper mapper;
        
        public PizzaBaseService(ContextDB context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;

        }

        public int Create(PizzaBaseCreateDTO DTO)
        {
            PizzaBase pizzaBase = mapper.Map<PizzaBase>(DTO);

            context.pizzaBases.Add(pizzaBase);            
            
            context.SaveChanges();
          
            return pizzaBase.Id;
        }

        public PizzaBase Get(int id)
        {
            PizzaBase pizzaBase = context.pizzaBases.FirstOrDefault(x => x.Id == id);
            
            if (pizzaBase == null)
            {
                throw new NotFoundExeption("Такая основа для пиццы не найдена");
            }
            return pizzaBase;
        }

        public PizzaBaseGetDTO GetDTO(int id)
        {
            PizzaBase pizzaBase = context.pizzaBases.Include(_ => _.PizzaIngredients).FirstOrDefault(x => x.Id == id);

            if (pizzaBase == null)
            {
                throw new NotFoundExeption("Такая основа для пиццы не найдена");
            }
            PizzaBaseGetDTO dto = mapper.Map<PizzaBaseGetDTO>(pizzaBase);
            return dto;
        }

        public void Update(PizzaBaseUpdateDTO DTO)
        {
            PizzaBase pizzaBase = context.pizzaBases.Include(_=>_.PizzaIngredients).FirstOrDefault(_ => _.Id == DTO.Id);
            if (pizzaBase == null)
            {
                throw new NotFoundExeption("Такая основа для пиццы не найдена");
            }
            pizzaBase = mapper.Map<PizzaBase>(DTO);

            context.SaveChanges();

            
        }

        public int Delete(int Id)
        {
            PizzaBase pizzaBase = context.pizzaBases.FirstOrDefault(_ => _.Id ==Id);
            if (pizzaBase == null)
            {
                throw new NotFoundExeption("Такая основа для пиццы не найдена");
            }
            context.pizzaBases.Remove(pizzaBase);

            context.SaveChanges();
            return pizzaBase.Id;
        }
    }
}
