using System;
using Business.Tools.Exceptions;
using Entities.Models;

namespace Business.Validations;

public class IncomeValidations
{
    public async Task IncomeMustNotBeEmpty(Income? income)
    {
        if(income == null)
        {
            throw new ValidationException("Income cannot be empty");
        }

        await Task.CompletedTask;
    }
}

