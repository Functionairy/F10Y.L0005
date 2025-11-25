using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using F10Y.T0002;


namespace F10Y.L0005.L001
{
    /// <summary>
    /// Logging operations.
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="Documentation.Project_SelfDescription" path="/summary"/>
    /// </remarks>
    [FunctionsMarker]
    public partial interface ILoggingOperator
    {
        void Add_Logging(IServiceCollection services)
        {
            services.AddLogging(loggingBuilder =>
            {
                loggingBuilder
                    .AddConsole()
                    .SetMinimumLevel(LogLevel.Information)
                    ;
            });
        }
    }
}
