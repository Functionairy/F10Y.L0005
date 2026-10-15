using System;

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
    public partial interface IServiceOperations
    {
        Action<IServiceCollection> Add_ServiceCollection(out ServiceToken<IServiceCollection> serviceCollection_Token)
            => services => services.AddSingleton(services);

        Action<IServiceCollection> Add_Singleton<TService>()
            where TService : class
            => services => services.AddSingleton<TService>();

        Action<IServiceCollection> Add_Singleton<TDefinition, TImplementation>()
            where TDefinition : class
            where TImplementation : class, TDefinition
            => services => services.AddSingleton<TDefinition, TImplementation>();

        Action<IServiceCollection> Add_Singleton<TDefinition, TImplementation>(
            Func<IServiceProvider, TImplementation> constructor)
            where TDefinition : class
            where TImplementation : class, TDefinition
            => services => services.AddSingleton<TDefinition, TImplementation>(constructor);
    }
}
