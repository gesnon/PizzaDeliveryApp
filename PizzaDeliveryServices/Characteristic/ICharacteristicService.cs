using PizzaDeliveryServices.DTO.CharacteristicDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.Services
{
    public interface ICharacteristicService
    {
        public void CreateCharacteristic(CharacteristicCreateDTO DTO);
        public void UpdateCharacteristic(CharacteristicUpdateDTO DTO);
        public void DeleteCharacteristic(int Id);
    }
}
