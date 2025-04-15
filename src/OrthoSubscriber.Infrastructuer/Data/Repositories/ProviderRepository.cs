using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OrthoSubscriber.Core.Models;
using OrthoSubscriber.Core.Models.Provider;
using OrthoSubscriber.Core.Interfaces;

namespace OrthoSubscriber.Infrastructure.Data.Repositories {
    public class ProviderRepository : IProviderRepository {
        public async Task<PatientProvider> GetProvider(Guid id) {
            return new PatientProvider();
        }
    }
}