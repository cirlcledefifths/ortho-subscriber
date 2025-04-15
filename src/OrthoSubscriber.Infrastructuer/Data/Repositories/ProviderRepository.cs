using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OrthoSubscriber.Core.Models;
using OrthoSubscriber.Core.Interfaces;

namespace OrthoSubscriber.Infrastructure.Data.Repositories {
    public class ProviderRepository : IProviderRepository {
        public async Task<Provider> GetProvider(Guid id) {
            return new Provider();
        }
    }
}