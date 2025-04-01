using System;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CateringBackend.Diets.Commands;
using CateringBackend.Diets.Queries;

namespace CateringBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DietsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DietsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Authorize(Roles = "producer")]
        public async Task<IActionResult> AddDiet([FromBody] AddDietCommand addDietCommand)
        {
            var result = await _mediator.Send(addDietCommand);
            return result.dietAdded
                ? CreatedAtAction(nameof(AddDiet), "Powodzenie dodania diety")
                : BadRequest($"Niepowodzenie dodania diety - {result.errorMessage}");
        }

        [HttpGet]
        [Authorize(Roles = "client,producer")]
        public async Task<IActionResult> GetDiets([FromQuery] GetDietsQuery getDietsQuery)
        {
            var result = await _mediator.Send(getDietsQuery);
            return Ok(result);
        }

        [HttpGet("{dietId}")]
        [Authorize(Roles = "client,producer")]
        public async Task<IActionResult> GetDietDetails([FromRoute] Guid dietId)
        {
            var result = await _mediator.Send(new GetDietDetailsQuery(dietId));
            return result == default ? NotFound("") : Ok(result);
        }

        [HttpPut("{dietId}")]
        [Authorize(Roles = "producer")]
        public async Task<IActionResult> EditDiet([FromRoute] Guid dietId, [FromBody] EditDietCommand editDietCommand)
        {
            var (dietExists, dietEdited, errorMessage) = await _mediator.Send(new EditDietWithDietIdCommand(editDietCommand, dietId));
            if (!dietExists) return NotFound($"Podana dieta nie istnieje - {errorMessage}");
            if (!dietEdited) return BadRequest($"Niepowodzenie edycji diety - {errorMessage}");
            return Ok("Powodzenie edycji diety");
        }


        [HttpDelete("{dietId}")]
        [Authorize(Roles = "producer")]
        public async Task<IActionResult> DeleteDiet([FromRoute] Guid dietId)
        {
            var (dietExists, errorMessage) = await _mediator.Send(new DeleteDietCommand(dietId));
            if (!dietExists)
                return NotFound($"Podana dieta nie istnieje - {errorMessage}");
            return Ok("Powodzenie usunięcia diety");
        }
    }
}
