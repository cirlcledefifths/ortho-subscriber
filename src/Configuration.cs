using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Amazon.DynamoDBv2;
using Amazon.Extensions.NETCore.Setup;
using Amazon.DynamoDBv2.DataModel;
using OrthoSubscriber.Core.Interfaces;
using OrthoSubscriber.Core.Services;
using OrthoSubscriber.Infrastructure.Data.Repositories;

namespace OrthoSubscriber.Startup
{
    public static class Configuration
    {
        public static ServiceProvider BuildServices()
        {
            var configuration = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .Build();

            var serviceCollection = new ServiceCollection();

            serviceCollection.AddLogging(configure =>
            {
                configure.AddConsole();
                configure.SetMinimumLevel(LogLevel.Information); // Ensure logs at or above Information level are captured
            });

            serviceCollection.AddLogging(configure => configure.AddConsole());
            serviceCollection.AddScoped<IPatientRepository, PatientRepository>();
            serviceCollection.AddScoped<PatientService>();

            serviceCollection.AddScoped<IDynamoDBContext, DynamoDBContext>();

            return serviceCollection.BuildServiceProvider();

            // Your Lambda function entry point can now use the serviceProvider
            // Example: var myService = serviceProvider.GetService<IMyService>();
        }
    }
}