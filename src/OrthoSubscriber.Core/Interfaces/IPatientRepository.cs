using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OrthoSubscriber.Core.Models.Patient;

namespace OrthoSubscriber.Core.Interfaces {
    public interface IPatientRepository {
        Task<Patient> GetPatient(Guid Id);
        Task<Patient> SavePatient(Patient patient);
        Task<PatientPolicy> SubscribePatient(Patient patient);
        Task<bool> UnsubscribePatient(Guid Id);
    }
}