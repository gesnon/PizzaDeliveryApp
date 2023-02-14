using PizzaDeliveryServices.DTO.CharacteristicDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.DTO.PizzaDTO
{
    public class PizzaCreateDTO
    {
        public int PizzaBaseID { get; set; }
        public CreatePizzaCharacteristicDTO pizzaCharacteristic { get; set; }
    }
}
