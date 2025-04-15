using OrthoSubscriber.Core.Models;

namespace OrthoSubscriber.Core.Models.Patient {
    public class PatientAddress : Address {
        public bool AllowEmails { get; set; }
    }
}