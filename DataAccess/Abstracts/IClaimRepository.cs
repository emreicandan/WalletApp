using System;
using Core.Entities;
using Core.Repository;

namespace DataAccess.Abstracts;

public interface IClaimRepository:IRepository<Claim>,IAsyncRepository<Claim>
{
}

