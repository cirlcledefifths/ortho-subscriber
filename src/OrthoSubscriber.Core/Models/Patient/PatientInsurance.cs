using OrthoSubscriber.Core.Models;

namespace OrthoSubscriber.Core.Models.Patient {
    public class PatientInsurance {
        public PatientPolicy Policy { get; set; } = new PatientPolicy();
    }
}