using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OrthoSubscriber.Core.Models;
using OrthoSubscriber.Core.Interfaces;

namespace OrthoSubscriber.Core.Services {
    public class ProviderService {
        private readonly IProviderRepository _providerRepository;

        public ProviderService() {}

        public async Task<Provider> GetProvider(Guid id) {
            return await _providerRepository.GetProvider(id);
        }
    }
}