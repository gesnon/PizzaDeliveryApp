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
        public void CreatePizza(PizzaCreateDTO DTO)
        {
            Pizza pizza = mapper.Map<Pizza>(DTO);
            pizza.Characteristic = context.Characteristics.FirstOrDefault(_ => _.Size == (Size)DTO.Size);

            context.Pizzas.Add(pizza);
            context.SaveChanges();
        }
        public void UpdatePizza(PizzaUpdateDTO DTO)
        {
            Pizza pizza = context.Pizzas.FirstOrDefault(_ => _.Id == DTO.Id);
            if (pizza == null)
            {
                throw new NotFoundExeption("Пицца не найдена");
            }
            pizza = mapper.Map<Pizza>(DTO);
            pizza.Characteristic = context.Characteristics.FirstOrDefault(_ => _.Size == (Size)DTO.Size);

            context.SaveChanges();
        }

        public void DeletePizza(int Id)
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
