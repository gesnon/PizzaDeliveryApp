using PizzaDeliveryServices.DTO.CharacteristicDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.Services
{
    public interface IPizzaCharacteristicService
    {
        public int Create(CreatePizzaCharacteristicDTO DTO);
    }
}
