using Microsoft.AspNetCore.Mvc;
using PizzaDeliveryServices.DTO.PizzaDTO;
using PizzaDeliveryServices.Services;

namespace PizzaDeliveryApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : BaseController
    {
        private readonly IPizzaService pizzaService;

        public PizzaController(IPizzaService pizzaService)
        {
            this.pizzaService = pizzaService;
        }


        [HttpPost("Create")]
        public ActionResult Create([FromBody] PizzaCreateDTO DTO)
        {
            return Ok(pizzaService.Create(DTO));
        }
    }
}
