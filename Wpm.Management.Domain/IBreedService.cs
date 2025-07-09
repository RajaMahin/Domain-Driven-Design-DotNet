using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpm.Management.Domain.Entiities;
using Wpm.Management.Domain.ValueObjects;

namespace Wpm.Management.Domain
{
    public interface IBreedService
    {
        Breed? GetBreed(Guid id);
    }

    public class FakeBreedService : IBreedService
    {
        public readonly List<Breed> breeds = [
            new Breed(
                Guid.NewGuid(),
                "Beagle",
                new WeightRange(10m, 29m),
                new WeightRange(11m, 19m)
                ),

              new Breed(
                Guid.NewGuid(),
                "Staffoshire",
                new WeightRange(28m, 31m),
                new WeightRange(11m, 19m)
                )

        ];

        public Breed? GetBreed(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new NotImplementedException();

            }

            var result = breeds.Find(x => x.Id == id);
            return result;
        }
    }
}
