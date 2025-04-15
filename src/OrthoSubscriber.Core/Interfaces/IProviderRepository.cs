using System;
using System.Threading.Tasks;
using OrthoSubscriber.Core.Models;

namespace OrthoSubscriber.Core.Interfaces {
    public interface IProviderRepository {
        Task<Provider> GetProvider(Guid id);
    }
}