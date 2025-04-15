using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OrthoSubscriber.Core.Interfaces;
using OrthoSubscriber.Core.Models;

namespace OrthoSubscriber.Infrastructure.Data.Repositories {
    public class PatientRepository : IPatientRepository {
        public PatientRepository() {
            // Instantiate db client
        }

        public async Task<Patient> GetPatient(Guid Id) {
            var patient = new Patient();
            patient.FristName = "Darrin";

            return patient;
        }
    }
}