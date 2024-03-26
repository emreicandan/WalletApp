using System;
using Core.Repository;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Models;


namespace DataAccess.Concretes;

public class ExpenseRepository : Repository<Expense>, IExpenseRepository
{
    public ExpenseRepository(WalletDbContext context) : base(context)
    {
    }
}

