using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Serilog;

namespace DotNetOnion.Template.CrossCutting.Logging
{
    public static class SerilogExtensions
    {
        /// <summary>
        /// Configura o bootstrap logger do Serilog
        /// </summary>
        /// <returns>ILogger configurado para bootstrap</returns>
        public static ILogger CreateBootstrapLogger(IConfiguration configuration)
        {
            return new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateBootstrapLogger();
        }

        /// <summary>
        /// Adiciona e configura o Serilog no pipeline do ASP.NET Core
        /// </summary>
        /// <param name="services">IServiceCollection para adicionar o Serilog</param>
        /// <param name="configuration">Configuração da aplicação</param>
        /// <returns>IServiceCollection com Serilog configurado</returns>
        public static IServiceCollection AddSerilogConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSerilog((serviceProvider, loggerConfiguration) =>
            {
                loggerConfiguration
                    .ReadFrom.Configuration(configuration)
                    .ReadFrom.Services(serviceProvider);

                // Adicione outros sinks conforme necessário
                // Ex: WriteTo.File, WriteTo.Seq, etc.
            });

            return services;
        }

        /// <summary>
        /// Configura o middleware de registro de requisições do Serilog
        /// </summary>
        /// <param name="app">WebApplication para configurar o middleware</param>
        /// <returns>WebApplication com middleware configurado</returns>
        public static WebApplication UseSerilogRequestLoggingConfiguration(this WebApplication app)
        {
            app.UseSerilogRequestLogging();

            return app;
        }
    }
}
