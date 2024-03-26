using System;
using Core.Entities;
using Core.Repository;

namespace Entities.Models;

public class Income:Entity<Guid>
{
    public Guid UserId { get; set; }
    public Guid CategoryId { get; set; }
    public Guid CurrencyId { get; set; }
    public decimal Amount { get; set; }
    public decimal ExchangeRate { get; set; }
    public string Description { get; set; }
    public DateTime TransactionDate { get; set; }
    public virtual User User { get; set; }
    public virtual Category Category { get; set; }
    public virtual Currency Currency { get; set; } 
}

