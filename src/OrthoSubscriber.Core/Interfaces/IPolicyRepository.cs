using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OrthoSubscriber.Core.Models;

namespace OrthoSubscriber.Core.Interfaces {
    public interface IPolicyRepository {
        Task<PatientPolicy> GetUserPolicy(Guid UserId);
        Task<PatientPolicy> GetUserPolicySubscriptionDate(Guid UserId);
        Task<bool> IsUserPolicyActive(Guid UserId);
    }
}