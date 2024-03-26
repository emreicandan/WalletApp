using System;
using Core.Repository;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Models;


namespace DataAccess.Concretes;

public class IncomeRepository : Repository<Income>, IIncomeReposiyory
{
    public IncomeRepository(WalletDbContext context) : base(context)
    {
    }
}

