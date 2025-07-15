using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Wpm.Management.Domain.ValueObjects;
using Wpm.SharedKernel;

namespace Wpm.Management.Domain.Entiities
{
    public class Breed : Entity
    {
        public string? Name { get; set; }

        public WeightRange? MaleIdealWeight { get; set; }
        public WeightRange? FemaleIdealWeight { get; set; }

        public Breed( Guid id, string? name, WeightRange? maleIdealWeight, WeightRange? femaleIdealWeight)
        {
            Id = id; 
            Name = name;
            MaleIdealWeight = maleIdealWeight;
            FemaleIdealWeight = femaleIdealWeight;
        }
    }

 
}
