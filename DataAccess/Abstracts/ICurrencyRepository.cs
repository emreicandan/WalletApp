using System;
using Core.Repository;
using Entities.Models;

namespace DataAccess.Abstracts;

public interface ICurrencyRepository:IRepository<Currency>,IAsyncRepository<Currency>
{
}

