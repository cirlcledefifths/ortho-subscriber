using System;
using System.Collections.Generic;

namespace OrthoSubscriber.Core.Models {
    public class Provider {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LicenseId { get; set; }
    }
}
