using System;
using Entities.DTOs;
using Entities.Models;

namespace Business.Abstracts;

public interface ICurrencyService
{
    Currency? GetById(Guid id);

    Task<Currency?> GetByIdAsync(Guid id);

    IList<Currency> GetAll();

    Task<IList<Currency>> GetAllAsync();

    Currency Add(AddCurrencyDTO addCurrencyDTO);

    Task<Currency> AddAsync(AddCurrencyDTO addCurrencyDTO);

    Currency Update(AddCurrencyDTO addCurrencyDTO);

    Task<Currency> UpdateAsync(AddCurrencyDTO addCurrencyDTO);

    void DeleteById(Guid id);

    Task DeleteByIdAsync(Guid id);
}

