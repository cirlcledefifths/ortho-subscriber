using OrthoSubscriber.Core.Models;

namespace OrthoSubscriber.Core.Models.Patient {
    public class PatientPolicy {
        public PolicyType Type { get; set; } = PolicyType.Basic;
        public Guid Id { get; set; }
        public string PolicyNumber { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}