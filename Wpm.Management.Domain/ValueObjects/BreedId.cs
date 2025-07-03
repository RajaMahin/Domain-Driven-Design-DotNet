using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpm.Management.Domain.ValueObjects
{
    public record BreedId
    {
        private readonly IBreedService _breedService;
        public Guid Value { set; get; }

        public BreedId(Guid value, IBreedService breedService)
        {
            _breedService = breedService;
            Value = value;

            ValidateBreed(value);
        }

        private void ValidateBreed(Guid value)
        {
            if (_breedService.GetBreed(value) == null)
            {
                throw new ArgumentException("GUID NOT VALID");
            }

        }
    }
}
