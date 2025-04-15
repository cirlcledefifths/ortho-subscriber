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
using OrthoSubscriber.Core.Models.Patient;
using OrthoSubscriber.Core.Models;
using OrthoSubscriber.Lambda.Models.Responses;

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

        public async Task<APIGatewayProxyResponse> GetPatientDetails(APIGatewayProxyRequest request, ILambdaContext context) {
            try {
                if (!request.PathParameters.TryGetValue("id", out var idStr) || !Guid.TryParse(idStr, out var id))
                {
                    return new APIGatewayProxyResponse
                    {
                        StatusCode = (int)HttpStatusCode.BadRequest,
                        Body = JsonConvert.SerializeObject(new ErrorResponse { Message = "Invalid patient ID." }),
                        Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } }
                    };
                }

                var patientDetails = _patientService.GetPatient(id);
                
                 return new APIGatewayProxyResponse
                {
                    StatusCode = (int)HttpStatusCode.OK,
                    Body = JsonConvert.SerializeObject(patientDetails),
                    Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } }
                };
            }
            catch(Exception ex) {
                context.Logger.LogLine($"Error getting patient details: {ex.Message}");
                
                return new APIGatewayProxyResponse
                {
                    StatusCode = (int)HttpStatusCode.InternalServerError,
                    Body = JsonConvert.SerializeObject(new ErrorResponse 
                    { 
                        Message = "An error occurred while retrieving patient details."
                    }),
                    Headers = new Dictionary<string, string> { { "Content-Type", "application/json" } }
                };
            }
        }
    }
}