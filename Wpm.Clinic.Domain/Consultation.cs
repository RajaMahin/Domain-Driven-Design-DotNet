using System.Diagnostics.CodeAnalysis;
using Wpm.Clinic.Domain.ValueObjects;
using Wpm.SharedKernel;

namespace Wpm.Clinic.Domain
{
    public class Consultation : AggregateRoot
    {
        public Text? Diagnoses { get; private set; }

        public Text? Treatment { get; private set; }


        public PatientId PatientId { get; init; }



        public Weight? CurrentWeight { set; private get; }
        
        

        public ConsultationStatus Status { get; private set; }

        public void SetWeight(Weight weight)
        {
            CurrentWeight = weight;
        }


        public enum ConsultationStatus
        {
            Open,
            Closed
        }
    }
}
