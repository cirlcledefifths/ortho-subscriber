using System;
using System.Collections.Generic;
using OrthoSubscriber.Core.Models;

namespace OrthoSubscriber.Core.Models {
    public class Patient {
        public Guid Id {get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; } = string.Empty;
        public string Email { get; set; }
        public string Phone {get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; } // Use an Enum
        public PatientPolicy Policy { get; set; }= new PatientPolicy();
    }
}