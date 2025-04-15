using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OrthoSubscriber.Core.Models;

namespace OrthoSubscriber.Core.Interfaces {
    public interface IPatientRepository {
        Task<Patient> GetPatient(Guid Id);
        // Task<Patient> CreatePatient(Patient patient);
        // Task<bool> UnsubscribePatient(Guid Id);
    }
}