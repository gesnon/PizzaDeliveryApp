using AutoMapper;
using PizzaDeliveryDB;
using PizzaDeliveryDB.Entities;
using PizzaDeliveryServices.DTO.PizzaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly ContextDB context;
        private readonly IMapper mapper;

        public PizzaService(ContextDB context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public int Create(PizzaCreateDTO DTO)
        {
            Pizza pizza = mapper.Map<Pizza>(DTO);
            
            context.Pizzas.Add(pizza);
            context.SaveChanges();

            return pizza.Id;
        }
        public void Update(PizzaUpdateDTO DTO)
        {
            Pizza pizza = context.Pizzas.FirstOrDefault(_ => _.Id == DTO.Id);
            if (pizza == null)
            {
                throw new NotFoundExeption("Пицца не найдена");
            }
            pizza = mapper.Map<Pizza>(DTO);            

            context.SaveChanges();
        }

        public void Delete(int Id)
        {
            Pizza pizza = context.Pizzas.FirstOrDefault(_ => _.Id == Id);
            if (pizza == null)
            {
                throw new NotFoundExeption("Пицца не найдена");
            }
            context.Pizzas.Remove(pizza);
            context.SaveChanges();
        }

    }
}
