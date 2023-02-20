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

        [HttpGet("{Id}")]
        public ActionResult Get(int Id)
        {
            return Ok(pizzaCharacteristicService.Get(Id));
        }

        [HttpGet("{PizzaId}")]
        public ActionResult GetPizzaCharacteristric(int Id)
        {
            return Ok(pizzaCharacteristicService.GetPizzaCharacteristric(Id));
        }

    }
}