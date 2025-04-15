using System;
using System.Collections.Generic;
using OrthoSubscriber.Core.Models;

namespace OrthoSubscriber.Core.Models.Provider {
    public class PatientProvider {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LicenseId { get; set; }
    }
}
