using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using OrthoSubscriber.Core.Interfaces;
using OrthoSubscriber.Core.Models;
using OrthoSubscriber.Core.Models.Patient;
using OrthoSubscriber.Infrastructure.Data.Entities.Patient;

namespace OrthoSubscriber.Infrastructure.Data.Repositories {
    public class PatientRepository : IPatientRepository {
        private readonly IDynamoDBContext _dynamoDbContext;
        private readonly ILogger<PatientRepository> _logger;

        public PatientRepository(IDynamoDBContext dynamoDbContext, ILogger<PatientRepository> logger) {
            // Instantiate db client
            _dynamoDbContext = dynamoDbContext ?? throw new ArgumentNullException(nameof(dynamoDbContext));

            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<PatientData> GetPatient(Guid id) {
            _logger.LogInformation("Getting patient data from db...");
            var patientEntity = await _dynamoDbContext.LoadAsync<PatientEntity>(id.ToString());
            if (patientEntity == null)
            {
                _logger.LogInformation($"Patient with ID {id} not found.");
                return null;
            }
            _logger.LogInformation($"Mapping patient data {JsonSerializer.Serialize(patientEntity)}");
            return MapPatientData(patientEntity);
        }

        public async Task<PatientData> SavePatient(PatientData patient) {
            return patient;
        }

        public async Task<PatientPolicy> SubscribePatient(PatientData patient) {
            return new PatientPolicy();
        }

        public async Task<bool> UnsubscribePatient(Guid Id) {
            return true;
        }

        private PatientData MapPatientData(PatientEntity entity)
        {
            _logger.LogInformation($"IsNull = {entity == null}");
            if (entity == null) return null;
            _logger.LogInformation($"Mapping patient entity {JsonSerializer.Serialize(entity)}");
            return new PatientData
            {
                Id = Guid.Parse(entity.Id),
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                MiddleName = entity.MiddleName
            };
        }
    }
}