using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OrthoSubscriber.Core.Models;
using OrthoSubscriber.Core.Models.Patient;
using OrthoSubscriber.Core.Interfaces;

namespace OrthoSubscriber.Data.Repositories {
    public class PatientPolicyRepository : IPatientPolicyRepository  {
        public PatientPolicyRepository() {}

        public async Task<PatientPolicy> GetUserPolicy(Guid UserId) {
            return new PatientPolicy();
        }

        public async Task<DateTime> GetUserPolicySubscriptionDate(Guid UserId) {
            return DateTime.Now;
        }

        public async Task<bool> IsUserPolicyActive(Guid UserId) {
            return true;
        }

        public async Task<PatientPolicy> DeActivatePolicy(Guid UserId) {
            return new PatientPolicy();
        }
    }
}