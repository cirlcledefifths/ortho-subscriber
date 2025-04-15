using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OrthoSubscriber.Core.Models.Patient;

namespace OrthoSubscriber.Core.Interfaces {
    public interface IPatientPolicyRepository {
        Task<PatientPolicy> GetUserPolicy(Guid UserId);
        Task<DateTime> GetUserPolicySubscriptionDate(Guid UserId);
        Task<bool> IsUserPolicyActive(Guid UserId);
        Task<PatientPolicy> DeActivatePolicy(Guid UserId);
    }
}