using System;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using F10Y.T0002;
using F10Y.T0016;


namespace F10Y.L0005.L002
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="Documentation.Project_SelfDescription" path="/summary"/>
    /// </remarks>
    [FunctionsMarker]
    public partial interface IServicesOperator
    {
        TService Get_Service<TService>(
            IServiceProvider serviceProvider,
            ServiceToken<TService> serviceToken)
            => serviceProvider.GetRequiredService<TService>();

        TService Get_Service<TService>(IServiceProvider serviceProvider)
            => serviceProvider.GetRequiredService<TService>();

        void In_ServiceContext<TService>(
            IServiceProvider serviceProvider,
            Action<TService> action)
        {
            var service = this.Get_Service<TService>(serviceProvider);

            action(service);
        }

        TOut In_ServiceContext<TService, TOut>(
            IServiceProvider serviceProvider,
            Func<TService, TOut> function)
        {
            var service = this.Get_Service<TService>(serviceProvider);

            var output = function(service);
            return output;
        }

        async Task<TOut> In_ServiceContext<TService, TOut>(
            IServiceProvider serviceProvider,
            Func<TService, Task<TOut>> function)
        {
            var service = this.Get_Service<TService>(serviceProvider);

            var output = await function(service);
            return output;
        }

        void In_ServiceContext<TService>(
            IServiceProvider serviceProvider,
            ServiceToken<TService> serviceToken,
            Action<TService> action)
        {
            var service = this.Get_Service<TService>(serviceProvider);

            action(service);
        }

        async Task In_ServiceContext<TService>(
            IServiceProvider serviceProvider,
            ServiceToken<TService> serviceToken,
            Func<TService, Task> action)
        {
            var service = this.Get_Service<TService>(serviceProvider);

            await action(service);
        }

        async Task<TOut> In_ServiceContext<TService, TOut>(
            IServiceProvider serviceProvider,
            ServiceToken<TService> serviceToken,
            Func<TService, Task<TOut>> function)
        {
            var service = this.Get_Service<TService>(serviceProvider);

            var output = await function(service);
            return output;
        }
    }
}
