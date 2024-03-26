﻿using System;
namespace Entities.DTOs;

public class AddIncomeDTO
{
    public Guid UserId { get; set; }
    public Guid CategoryId { get; set; }
    public Guid CurrencyId { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; }
    public DateTime TransactionDate { get; set; }
}

