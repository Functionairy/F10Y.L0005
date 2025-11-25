using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using F10Y.T0016;


namespace F10Y.L0005.L001
{
    public static partial class IServiceCollectionExtensions
    {
        public static IServiceCollection Add_Logging(this IServiceCollection services,
#pragma warning disable IDE0060 // Remove unused parameter
            out ServiceToken<ILogger> logger_Token)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            Instances.LoggingOperator.Add_Logging(services);

            return services;
        }
    }
}
