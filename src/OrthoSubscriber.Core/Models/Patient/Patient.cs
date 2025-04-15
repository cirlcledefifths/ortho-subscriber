using OrthoSubscriber.Core.Models;

namespace OrthoSubscriber.Core.Models.Patient {
    public class Patient {
        public Guid Id {get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; } = string.Empty;
        public PatientAddress Address { get; set; }
        public GenderIdentification Gender { get; set; }
        public PatientProfile Profile { get; set; } = new PatientProfile();
        public PatientInsurance Insurance { get; set; }
    }
}