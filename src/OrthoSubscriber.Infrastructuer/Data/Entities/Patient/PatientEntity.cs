using System;
using System.Collections.Generic;
using Amazon.DynamoDBv2.DataModel;

namespace OrthoSubscriber.Infrastructure.Data.Entities.Patient {
    [DynamoDBTable("Patients")]

    public class PatientEntity {
        [DynamoDBHashKey]
        public string Id {get; set; }
        
        [DynamoDBProperty]
        public string FirstName { get; set; }

        [DynamoDBProperty]
        public string LastName { get; set; }

        [DynamoDBProperty]
        public string MiddleName { get; set; }
    }
}