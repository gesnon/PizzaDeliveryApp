using Microsoft.AspNetCore.Mvc;
using PizzaDeliveryServices.DTO.PizzaBaseDTO;
using PizzaDeliveryServices.Services;

namespace PizzaDeliveryApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaBaseController : BaseController
    {
        private readonly IPizzaBaseService pizzaBaseService;

        public PizzaBaseController(IPizzaBaseService pizzaBaseService)
        {
            this.pizzaBaseService = pizzaBaseService;
        }


        [HttpPost("Create")]
        public ActionResult Create([FromBody] PizzaBaseCreateDTO DTO)
        {
            return Ok(pizzaBaseService.Create(DTO));
        }
    }
}
