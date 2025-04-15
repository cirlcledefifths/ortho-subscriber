namespace OrthoSubscriber.Core.Models {
    public class PatientPolicy {
        public Guid Id { get; set; }
        public string PolicyNumber { get; set; }
        public DateTime SubscriptionDate { get; set; }
    }
}