using System;
using Core.Entities;
using Core.Repository;
using DataAccess.Abstracts;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concretes;

public class ClaimRepository : Repository<Claim>, IClaimRepository
{
    public ClaimRepository(WalletDbContext context) : base(context)
    {
    }
}

