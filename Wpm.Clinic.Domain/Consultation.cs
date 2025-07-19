using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;
using Wpm.Clinic.Domain.ValueObjects;
using Wpm.SharedKernel;

namespace Wpm.Clinic.Domain
{
    /* WE DO NOT WANT ANYTHING TO BE MODIFIED ONCE THE CONSULTATION IS CLOSED */
    public class Consultation : AggregateRoot
    {
        public Consultation(PatientId patientId)
        {
            Id = Guid.NewGuid();
            PatientId = patientId;
            Status = ConsultationStatus.Open;
            StartedAt = DateTime.UtcNow;
        }


        private readonly List<DrugAdministration> adminsteredDrugs = [];


        public IReadOnlyCollection<DrugAdministration> AdminsteredDrugs => adminsteredDrugs.AsReadOnly();
        public DateTime StartedAt { private set; get; }
        public DateTime EndedAt { private set; get; }


        public Text Diagnoses { get; private set; }

        public Text Treatment { get; private set; }


        public PatientId PatientId { get; init; }

        public Weight? CurrentWeight { set; private get; }

        public ConsultationStatus Status { get; private set; }


        #region SET METHODS 

        public void SetWeight(Weight weight)
        {
            ValidateConsultationStatus();
            CurrentWeight = weight;
        }

        public void SetDiagnoses(Text diagnoses)
        {
            ValidateConsultationStatus();
            Diagnoses = diagnoses;
        }

        public void SetTreatment(Text treatment)
        {
            ValidateConsultationStatus();
            Treatment = treatment;
        }

        #endregion


        public void AdministerDrug(DrugId drugId, Dose dose)
        {
            ValidateConsultationStatus(); 
            var newDrugAdministration = new DrugAdministration(drugId, dose);
            adminsteredDrugs.Add(newDrugAdministration);    
        }


        public void End()
        {
            ValidateConsultationStatus();

            if (Diagnoses == null || Treatment == null || CurrentWeight == null)
            {
                throw new InvalidOperationException("Consultation cannot be closed without diagnoses, treatment and weight.");
            }

            Status = ConsultationStatus.Closed;
            EndedAt = DateTime.UtcNow;
        }

        public enum ConsultationStatus
        {
            Open,
            Closed
        }

        private void ValidateConsultationStatus()
        {
            if (Status == ConsultationStatus.Closed)
            {
                throw new InvalidOperationException("The consultation is already clsoed");
            }
        }
    }
}
