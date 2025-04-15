using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OrthoSubscriber.Core.Interfaces;
using OrthoSubscriber.Core.Models;
using OrthoSubscriber.Core.Models.Patient;

namespace OrthoSubscriber.Core.Services {
    public class PatientService {
        private readonly IPatientRepository _patientRepository;

        public PatientService(IPatientRepository patientRepository) {
            _patientRepository = patientRepository;
        }

        public async Task<Patient> GetPatient(Guid id) {
            return await _patientRepository.GetPatient(id);
        }
    }
}