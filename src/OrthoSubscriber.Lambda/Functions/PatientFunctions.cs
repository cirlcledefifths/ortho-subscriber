using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using OrthoSubscriber.Startup;
using OrthoSubscriber.Core.Services;
using OrthoSubscriber.Core.Models;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
namespace OrthoSubscriber.Lambda.Functions
{
    public class PatientFunctions
    {
        private readonly PatientService _patientService;

        public PatientFunctions()
        {
            var serviceProvider = Configuration.BuildServices();
            _patientService = serviceProvider.GetRequiredService<PatientService>();
        }
    }
}