using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OrthoSubscriber.Core.Interfaces;
using OrthoSubscriber.Core.Models;
using OrthoSubscriber.Core.Models.Patient;

namespace OrthoSubscriber.Core.Services {
    public class PatientPolicyService {
        private readonly IPatientPolicyRepository _patientPolicyRepository;

        public PatientPolicyService(IPatientPolicyRepository patientPolicyRepository) {
            _patientPolicyRepository = patientPolicyRepository;
        }

        public async Task<PatientPolicy> GetUserPolicy(Guid id) {
            return await _patientPolicyRepository.GetUserPolicy(id);
        }

        public async Task<DateTime> GetUserPolicySubscriptionDate(Guid id) {
            return await _patientPolicyRepository.GetUserPolicySubscriptionDate(id);
        }

        public async Task<bool> IsUserPolicyActive(Guid id) {
            return await _patientPolicyRepository.IsUserPolicyActive(id);
        }

        public async Task<PatientPolicy> DeActivatePolicy(Guid id) {
            return await _patientPolicyRepository.DeActivatePolicy(id);
        }
    }
}