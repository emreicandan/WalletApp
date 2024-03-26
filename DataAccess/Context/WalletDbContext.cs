using System;
using Core.Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context;

public class WalletDbContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=WalletAPI;User Id=SA;TrustServerCertificate=true;Password=reallyStrongPwd123;");
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Claim> Claims { get; set; }
    public DbSet<UserClaim> UserClaims { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Expense> Expenses { get; set; }
    public DbSet<Income> Incomes { get; set; }
};

