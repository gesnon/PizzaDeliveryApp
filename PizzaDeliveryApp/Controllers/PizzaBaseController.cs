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
        [HttpGet]
        public ActionResult Get(int Id)
        {
            return Ok(pizzaBaseService.Get(Id));
        }

        [HttpGet("GetDTO")]
        public ActionResult GetDTO(int Id)
        {
            return Ok(pizzaBaseService.GetDTO(Id));
        }

        [HttpPut]
        public ActionResult Update ([FromBody] PizzaBaseUpdateDTO DTO)
        {
            pizzaBaseService.Update(DTO);
            return Ok();
        }    
        
        [HttpDelete]
        public ActionResult Delete (int Id)
        {
            return Ok(pizzaBaseService.Delete(Id));
        }
    }
}
