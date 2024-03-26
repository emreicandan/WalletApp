using System;
using Core.Entities;
using Core.Repository;

namespace DataAccess.Abstracts;

public interface IUserRepository:IRepository<User> , IAsyncRepository<User>
{

}

