using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OrthoSubscriber.Core.Models.Patient;

namespace OrthoSubscriber.Core.Interfaces {
    public interface IPatientRepository {
        Task<PatientData> GetPatient(Guid Id);
        Task<PatientData> SavePatient(PatientData patient);
        Task<PatientPolicy> SubscribePatient(PatientData patient);
        Task<bool> UnsubscribePatient(Guid Id);
    }
}