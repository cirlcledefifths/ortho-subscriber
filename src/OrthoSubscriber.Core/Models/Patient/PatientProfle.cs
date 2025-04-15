using OrthoSubscriber.Core.Models.Provider;

namespace OrthoSubscriber.Core.Models.Patient {
    public class PatientProfile {
        public string Phone {get; set; }
        public string Email { get; set; }
        public DateTime LastVisit { get; set; }
        public DateTime NextVisit { get; set; }
        public PatientProvider PrimaryProvider { get; set; }
    }
}