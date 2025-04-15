using System;
using System.Threading.Tasks;
using OrthoSubscriber.Core.Models.Provider;

namespace OrthoSubscriber.Core.Interfaces {
    public interface IProviderRepository {
        Task<PatientProvider> GetProvider(Guid id);
    }
}