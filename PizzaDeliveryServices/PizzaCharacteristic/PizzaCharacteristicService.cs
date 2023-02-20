using AutoMapper;
using PizzaDeliveryDB;
using PizzaDeliveryDB.Entities;
using PizzaDeliveryServices.DTO.CharacteristicDTO;


namespace PizzaDeliveryServices.Services
{
    public class PizzaCharacteristicService : IPizzaCharacteristicService
    {
        private readonly ContextDB context;
        private readonly IMapper mapper;

        public PizzaCharacteristicService(ContextDB context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public int Create(CreatePizzaCharacteristicDTO DTO)
        {
            PizzaCharacteristic pizzaCharacteristic = mapper.Map<PizzaCharacteristic>(DTO);

            context.PizzaCharacteristic.Add(pizzaCharacteristic);

            context.SaveChanges();

            return pizzaCharacteristic.Id;
        }

        public PizzaCharacteristicDTO Get(int Id)
        {
            PizzaCharacteristic pizzaCharacteristic = context.PizzaCharacteristic.FirstOrDefault(x => x.Id == Id);
            if(pizzaCharacteristic == null)
            {
                throw new NotFoundExeption("Характеристика не найдена");
            }

            PizzaCharacteristicDTO result = mapper.Map<PizzaCharacteristicDTO>(pizzaCharacteristic);
            
            return result;
        
        }

        public PizzaCharacteristicDTO GetPizzaCharacteristric(int PizzaId)
        {
            PizzaCharacteristic pizzaCharacteristic = context.Pizzas.FirstOrDefault(x => x.Id == PizzaId).PizzaCharacteristic;
            if (pizzaCharacteristic == null)
            {
                throw new NotFoundExeption("Характеристика не найдена");
            }

            PizzaCharacteristicDTO result = mapper.Map<PizzaCharacteristicDTO>(pizzaCharacteristic);

            return result;
        }
    }
}
