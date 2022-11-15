using AutoMapper;
using PizzaDeliveryDB;
using PizzaDeliveryDB.Entities;
using PizzaDeliveryServices.DTO.CharacteristicDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.Services
{
    public class CharacteristicService
    {
        private readonly ContextDB context;
        private readonly IMapper mapper;

        public CharacteristicService(ContextDB context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public void CreateCharacteristic(CharacteristicCreateDTO DTO)
        {
            Characteristic characteristic = mapper.Map<Characteristic>(DTO);
            context.Characteristics.Add(characteristic);
            context.SaveChanges();
        }

        public void UpdateCharacteristic(CharacteristicUpdateDTO DTO)
        {
            Characteristic characteristic = context.Characteristics.FirstOrDefault(_ => _.Id == DTO.Id);
            if(characteristic == null)
            {
                throw new NotFoundExeption("Характеристика не найдена");
            }
            characteristic = mapper.Map<Characteristic>(DTO);

            context.SaveChanges();
        }

        public void DeleteCharacteristic(int Id)
        {
            Characteristic characteristic = context.Characteristics.FirstOrDefault(_ => _.Id ==Id);
            if (characteristic == null)
            {
                throw new NotFoundExeption("Характеристика не найдена");
            }

            context.Characteristics.Remove(characteristic);
            context.SaveChanges();
        }

    }
}
