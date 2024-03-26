using System;
using Business.Tools.Exceptions;
using Entities.Models;

namespace Business.Validations;

public class CurrencyValidations
{
    public async Task CurrencyMustNotBeEmpty(Currency currency)
    {
        if(currency == null)
        {
            throw new ValidationException("Currency must not be empty");
        }

        await Task.CompletedTask;
    }
}

