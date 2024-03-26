using System;
using Core.Entities;
using Core.Repository;
using Entities.Models;

namespace DataAccess.Abstracts;

public interface ICategoryRepository:IRepository<Category>,IAsyncRepository<Category>
{
}

