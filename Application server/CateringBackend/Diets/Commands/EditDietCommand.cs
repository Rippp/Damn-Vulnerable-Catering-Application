using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CateringBackend.Domain.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CateringBackend.Diets.Commands
{
    public class EditDietCommand : IRequest<(bool dietExists, bool dietEdited, string errorMessage)>
    {
        public string Name { get; set; }
        public Guid[] MealIds { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }

    public class EditDietWithDietIdCommand : EditDietCommand, IRequest<(bool dietExists, bool dietEdited, string errorMessage)>
    {
        public Guid DietId { get; set; }

        public EditDietWithDietIdCommand(EditDietCommand editDietCommand, Guid dietId)
        {
            Name = editDietCommand.Name;
            MealIds = editDietCommand.MealIds;
            Price = editDietCommand.Price;
            Description = editDietCommand.Description;
            DietId = dietId;
        }
    }

    public class EditDietWithDietIdCommandHandler : IRequestHandler<EditDietWithDietIdCommand, (bool dietExists, bool dietEdited, string errorMessage)>
    {
        private readonly IMediator _mediator;
        private readonly CateringDbContext _dbContext;

        public EditDietWithDietIdCommandHandler( IMediator mediator, CateringDbContext dbContext)
        {
            _mediator = mediator;
            _dbContext = dbContext;
        }

        public async Task<(bool dietExists, bool dietEdited, string errorMessage)> Handle(EditDietWithDietIdCommand request, CancellationToken cancellationToken)
        {
            var diet = await _dbContext.Diets
                .Where(d => d.IsAvailable)
                .FirstOrDefaultAsync(d => d.Id == request.DietId, cancellationToken);

            if (diet == default)
                return (dietExists: false, dietEdited: false, errorMessage: $"Diet of given ID: '{request.DietId}' does not exist");

            diet.MakeUnavailable();

            var addResult = await _mediator.Send(new AddDietCommand
            {
                Description = request.Description,
                MealIds = request.MealIds,
                Name = request.Name,
                Price = request.Price,
            }, cancellationToken);

            if (!addResult.dietAdded)
            {
                return (dietExists: true, dietEdited: false, errorMessage: addResult.errorMessage);
            }

            return (dietExists: true, dietEdited: true, errorMessage: null);
        }
    }
}
