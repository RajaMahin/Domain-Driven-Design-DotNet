
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Wpm.Management.Api.Infrastructure;
using Wpm.Management.Domain;

namespace Wpm.Management.Api.Application
{
    public class SetWeightCommandHandler(
        IBreedService breedService,
       ManagementDbContext dbContext

        ) : ICommandHandler<SetWeightCommand>
    {
        public async Task Handle(SetWeightCommand command)
        {
            var pet = await dbContext.Pets.FindAsync(command.Id);

            pet.SetWeight(command.Weight, breedService: breedService);

            await dbContext.SaveChangesAsync();
        }
    }
}
