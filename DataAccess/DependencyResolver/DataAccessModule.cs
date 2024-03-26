using System;
using Core.Utilities.Tools;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Context;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.DependencyResolver;

public class DataAccessModule:ICoreModule
{

    public void Load(IServiceCollection services)
    {
        services.AddDbContext<WalletDbContext>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IClaimRepository, ClaimRepository>();
        services.AddScoped<IExpenseRepository, ExpenseRepository>();
        services.AddScoped<IIncomeReposiyory, IncomeRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
    }
}

