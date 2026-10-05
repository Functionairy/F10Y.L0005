using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using F10Y.T0002;


namespace F10Y.L0005.L002
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="Documentation.Project_SelfDescription" path="/summary"/>
    /// </remarks>
    [FunctionsMarker]
    public partial interface IServiceCollectionOperator
    {
        void Add_Singleton<TServiceDefinition, TServiceImplementation>(IServiceCollection services)
            where TServiceDefinition : class
            where TServiceImplementation : class, TServiceDefinition
            => services.AddSingleton<TServiceDefinition, TServiceImplementation>();

        /// <inheritdoc cref="ServiceCollectionContainerBuilderExtensions.BuildServiceProvider(IServiceCollection)"/>
        ServiceProvider Build_ServiceProvider(IServiceCollection services)
            => Instances.ServiceProviderOperator.Build_ServiceProvider(services);

        void Configure_ServiceCollection(
            IServiceCollection services,
            IEnumerable<Action<IServiceCollection>> configures)
        {
            foreach (var servicesConfigurationAction in configures)
            {
                servicesConfigurationAction(services);
            }
        }

        void Configure_ServiceCollection(
            IServiceCollection services,
            params Action<IServiceCollection>[] configures)
            => this.Configure_ServiceCollection(
                services,
                configures.AsEnumerable());

        ServiceCollection Configure_ServiceCollection(
            IEnumerable<Action<IServiceCollection>> configures)
        {
            var output = this.New();

            this.Configure_ServiceCollection(
                output,
                configures);

            return output;
        }

        ServiceCollection Configure_ServiceCollection(
            params Action<IServiceCollection>[] configures)
            => this.Configure_ServiceCollection(configures.AsEnumerable());

        Task<ServiceProvider> Configure_ServiceProvider(
            IEnumerable<Func<IServiceCollection, Task>> configures)
            => Instances.ServiceProviderOperator.Configure_ServiceProvider(configures);

        Task<ServiceProvider> Configure_ServiceProvider(
            params Func<IServiceCollection, Task>[] configures)
            => Instances.ServiceProviderOperator.Configure_ServiceProvider(configures);

        ServiceProvider Configure_ServiceProvider(
            IEnumerable<Action<IServiceCollection>> configures)
            => Instances.ServiceProviderOperator.Configure_ServiceProvider(configures);

        ServiceProvider Configure_ServiceProvider(
            params Action<IServiceCollection>[] configures)
            => Instances.ServiceProviderOperator.Configure_ServiceProvider(configures);

        public TService Get_Service<TService>(IServiceProvider serviceProvider)
            => serviceProvider.GetRequiredService<TService>();

        async Task In_ServiceProviderContext(
            Func<ServiceCollection, Task> servicesConfigurationAction,
            Func<IServiceProvider, Task> serviceProviderAction)
        {
            var services = this.New();

            await servicesConfigurationAction(services);

            await using var serviceProvider = services.BuildServiceProvider();

            await serviceProviderAction(serviceProvider);
        }

        ServiceCollection New()
           => new ServiceCollection();

        /// <summary>
        /// Useful in catching missing service dependencies.
        /// </summary>
        void Verify_AllServicesAvailable(
            IServiceCollection services,
            out ServiceDescriptor[] failedServices)
        {
            // Build a provide, and then request each service.
            using var serviceProvider = services.BuildServiceProvider();

            var failedServices_List = new List<ServiceDescriptor>();

            foreach (var serviceDescriptor in services)
            {
                // Some utter insanity is going on, in that some service implementation types are not actually assignable to their definition types.
                // This causes exceptions, and we are in the mood to hunt down exceptions.
                var implementationTypeIsAssignableToServiceType = serviceDescriptor.IsKeyedService
                    ? serviceDescriptor.ServiceType.IsAssignableFrom(serviceDescriptor.KeyedImplementationType)
                    : serviceDescriptor.ServiceType.IsAssignableFrom(serviceDescriptor.ImplementationType)
                    ;

                if (!implementationTypeIsAssignableToServiceType)
                {
                    failedServices_List.Add(serviceDescriptor);

                    continue;
                }

                try
                {
                    var service_OrDefault = serviceDescriptor.IsKeyedService
                        ? serviceProvider.GetKeyedService(
                            serviceDescriptor.ServiceType,
                            serviceDescriptor.ServiceKey)
                        : serviceProvider.GetService(serviceDescriptor.ServiceType)
                        ;

                    var isDefault = Instances.DefaultOperator.Is_Default(service_OrDefault);
                    if (isDefault)
                    {
                        failedServices_List.Add(serviceDescriptor);
                    }
                }
                catch (Exception)
                {
                    failedServices_List.Add(serviceDescriptor);
                }
            }

            failedServices = failedServices_List.ToArray();
        }
    }
}
