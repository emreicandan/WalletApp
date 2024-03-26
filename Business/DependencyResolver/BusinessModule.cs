using System;
using Business.Abstracts;
using Business.Concretes;
using Business.Validations;
using Core.Utilities.Tools;
using Microsoft.Extensions.DependencyInjection;

namespace Business.DependencyResolver;

public class BusinessModule : ICoreModule
{
    public void Load(IServiceCollection services)
    {
        services.AddScoped<CategoryValidation>();
    }
}

