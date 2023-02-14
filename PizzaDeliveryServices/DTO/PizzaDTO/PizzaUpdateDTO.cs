using PizzaDeliveryServices.DTO.CharacteristicDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.DTO.PizzaDTO
{
    public class PizzaUpdateDTO
    {
        public int Id { get; set; }
        public int PizzaBaseID { get; set; }
        public PizzaCharacteristicDTO pizzaCharacteristic { get; set; }
    }
}
