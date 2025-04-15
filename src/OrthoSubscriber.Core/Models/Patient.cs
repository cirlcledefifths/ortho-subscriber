using System;
using System.Collections.Generic;

namespace OrthoSubscriber.Core.Models {
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