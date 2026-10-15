using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using F10Y.T0002;


namespace F10Y.L0005.L002
{
    [FunctionsMarker]
    public partial interface IServiceProviderOperator
    {
        /// <inheritdoc cref="ServiceCollectionContainerBuilderExtensions.BuildServiceProvider(IServiceCollection)"/>
        ServiceProvider Build_ServiceProvider(IServiceCollection services)
            => services.BuildServiceProvider();

        async Task<ServiceProvider> Configure_ServiceProvider(
            IEnumerable<Func<IServiceCollection, Task>> servicesConfigurationActions)
        {
            var serviceCollection = Instances.ServiceCollectionOperator.New();

            foreach (var servicesConfigurationAction in servicesConfigurationActions)
            {
                await servicesConfigurationAction(serviceCollection);
            }

            var output = this.Build_ServiceProvider(serviceCollection);
            return output;
        }

        Task<ServiceProvider> Configure_ServiceProvider(
            params Func<IServiceCollection, Task>[] configures)
            => this.Configure_ServiceProvider(
                configures.AsEnumerable());

        ServiceProvider Configure_ServiceProvider_Synchronous(
            IEnumerable<Action<IServiceCollection>> configures)
        {
            var serviceCollection = Instances.ServiceCollectionOperator.Configure_ServiceCollection(configures);

            var output = this.Build_ServiceProvider(serviceCollection);
            return output;
        }

        ServiceProvider Configure_ServiceProvider_Synchronous(
            params Action<IServiceCollection>[] configures)
            => this.Configure_ServiceProvider_Synchronous(
                configures.AsEnumerable());

        ServiceProvider Configure_ServiceProvider(
            IEnumerable<Action<IServiceCollection>> configures)
            => this.Configure_ServiceProvider_Synchronous(configures);

        ServiceProvider Configure_ServiceProvider(
            params Action<IServiceCollection>[] configures)
            => this.Configure_ServiceProvider(
                configures.AsEnumerable());
    }
}
