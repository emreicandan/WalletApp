using System;
using Core.Entities;
using Core.Repository;
using DataAccess.Abstracts;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concretes;

public class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(WalletDbContext context) : base(context)
    {
    }
}

