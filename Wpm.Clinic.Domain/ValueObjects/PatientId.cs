using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpm.Clinic.Domain.ValueObjects
{
    //PET ID IS CONSIDERED AS PATIENT ID AS PETS ARE THE PATIENTS
    public class PatientId
    {
        public Guid Value { get; init; }
        public PatientId(Guid value)
        {
            if (value == Guid.Empty)
            {
                throw new ArgumentNullException("value", "The identifier is not valid.");
            }
            Value = value;
        }

        public static implicit operator PatientId(Guid value)
        {
            return new PatientId(value);
        }
    }
}
