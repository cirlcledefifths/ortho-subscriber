namespace OrthoSubscriber.Core.Models {
    public class PatientPolicy {
        public PolicyType Type { get; set; } = PolicyType.Basic;
        public Guid Id { get; set; }
        public string PolicyNumber { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}