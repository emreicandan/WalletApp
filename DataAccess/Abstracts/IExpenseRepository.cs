using System;
using Core.Entities;
using Core.Repository;
using Entities.Models;

namespace DataAccess.Abstracts;

public interface IExpenseRepository : IRepository<Expense> , IAsyncRepository<Expense>
{
}

