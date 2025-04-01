using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using CateringBackend.Meals.Queries;
using CateringBackend.Meals.Commands;

namespace CateringBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MealsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MealsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Authorize(Roles = "client,producer")]
        public async Task<IActionResult> GetMeals([FromQuery] GetMealsQuery getMealsQuery)
        {
            var result = await _mediator.Send(getMealsQuery);
            return Ok(result);
        }

        [HttpGet("{mealId}")]
        [Authorize(Roles = "client,producer")]
        public async Task<IActionResult> GetMealDetails([FromRoute] Guid mealId)
        {
            var result = await _mediator.Send(new GetMealDetailsQuery(mealId));
            return result == default ? NotFound("Podany posiłek nie istnieje") : Ok(result);
        }

        [HttpPost]
        [Authorize(Roles = "producer")]
        public async Task<IActionResult> AddNewMeal([FromBody] AddMealCommand addMealCommand)
        {
            var result = await _mediator.Send(addMealCommand);
            return result ? 
                CreatedAtAction(nameof(AddNewMeal), "Powodzenie dodania posiłku") :
                BadRequest("Niepowodzenie dodania posiłku");
        }

        [HttpDelete("{mealId}")]
        [Authorize(Roles = "producer")]
        public async Task<IActionResult> DeleteMeal([FromRoute] Guid mealId)
        {
            var result = await _mediator.Send(new DeleteMealCommand(mealId));

            if (result == default)
                return NotFound("Podany posiłek nie istnieje");

            return result.IsAvailable ? BadRequest("Niepowodzneie usunięcia posiłku") :
                                        Ok("Powodzenie usunięcia posiłku");
        }

        [HttpPut("{mealId}")]
        [Authorize(Roles = "producer")]
        public async Task<IActionResult> EditMeal([FromRoute] Guid mealId, [FromBody] EditMealCommand editMealCommand)
        {
            editMealCommand.MealId = mealId;
            var (mealExists, mealEdited) = await _mediator.Send(editMealCommand);

            if(!mealExists)
                return NotFound("Podany posiłek nie istnieje");
            
            if (!mealEdited)
                return BadRequest("Niepowodzneie edycji posiłku");
           
            return Ok("Powodzenie edycji posiłku");
        }
    }
}