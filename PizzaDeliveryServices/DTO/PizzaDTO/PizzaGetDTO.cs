using PizzaDeliveryServices.DTO.CharacteristicDTO;
using PizzaDeliveryServices.DTO.PizzaBaseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDeliveryServices.DTO.PizzaDTO
{
    public class PizzaGetDTO
    {
        public PizzaBaseGetDTO PizzaBaseDTO { get; set; }
        public CharacteristicGetDTO CharacteristicDTO { get; set; }
    }
}
