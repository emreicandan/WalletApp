using System;
using Business.Tools.Exceptions;
using Entities.Models;

namespace Business.Validations;

public class ExpenseValidations
{
    public async Task ExpenseMustNotBeEmpty(Expense? expense)
    {
        if(expense == null)
        {
            throw new ValidationException("Expense must not be empty");
        }
        await Task.CompletedTask;
    }
}

