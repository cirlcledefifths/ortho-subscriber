namespace OrthoSubscriber.Core.Models {
    public class PatientProfile {
        public string Phone {get; set; }
        public string Email { get; set; }
        public DateTime LastVisit { get; set; }
        public DateTime NextVisit { get; set; }
        public Provider PrimaryProvider { get; set; }
    }
}