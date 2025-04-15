using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OrthoSubscriber.Core.Interfaces;
using OrthoSubscriber.Core.Models;
using OrthoSubscriber.Core.Models.Patient;

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

        public async Task<Patient> SavePatient(Patient patient) {
            return patient;
        }

        public async Task<PatientPolicy> SubscribePatient(Patient patient) {
            return new PatientPolicy();
        }

        public async Task<bool> UnsubscribePatient(Guid Id) {
            return true;
        }
    }
}