using System;
using Core.CrossCuttingConcerns.Caching;
using Core.Utilities.Tools;
using Microsoft.Extensions.DependencyInjection;

namespace Core.DependencyResolver;

public class CoreModule : ICoreModule
{
    public void Load(IServiceCollection services)
    {
        services.AddMemoryCache();
        services.AddSingleton<ICacheService, MicrosoftCacheMenager>();
    }
}

