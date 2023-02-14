using Microsoft.AspNetCore.Mvc;
using PizzaDeliveryServices.DTO.CharacteristicDTO;
using PizzaDeliveryServices.Services;

namespace PizzaDeliveryApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaCharacteristicController : BaseController
    {
        private readonly IPizzaCharacteristicService pizzaCharacteristicService;
        public PizzaCharacteristicController(IPizzaCharacteristicService pizzaCharacteristicService)
        {
            this.pizzaCharacteristicService = pizzaCharacteristicService;
        }

        [HttpPost("Create")]
        public ActionResult Create([FromBody] CreatePizzaCharacteristicDTO DTO)
        {
            return Ok(pizzaCharacteristicService.Create(DTO));
        }
    }
}