using Microsoft.Extensions.Configuration;

namespace DotNetOnion.Template.CrossCutting.Utils.Configuration
{
    public static class ConfigurationExtensions
    {
        public static string GetDatabaseConnectionString(this IConfiguration configuration)
        {
            return configuration.GetRequiredConfiguration(ConfigurationKeys.DefaultConnectionEnv, ConfigurationKeys.DefaultConnectionConfig);
        }

        public static string GetRedisConnectionString(this IConfiguration configuration)
        {
            return configuration.GetRequiredConfiguration(ConfigurationKeys.RedisConnectionEnv, ConfigurationKeys.RedisConnectionConfig);
        }

        private static string GetRequiredConfiguration(this IConfiguration configuration, string envVariable, string configKey)
        {
            var value = Environment.GetEnvironmentVariable(envVariable)
                        ?? configuration.GetValue<string>(configKey);

            if (string.IsNullOrWhiteSpace(value))
            {
                throw new InvalidOperationException($"Configuração obrigatória ausente: '{configKey}' ou variável de ambiente '{envVariable}'");
            }

            return value;
        }
    }
}
