using System;
using Entities.DTOs;
using Entities.Models;

namespace Business.Abstracts;

public interface IIncomeService
{
    Income? GetById(Guid id);

    Task<Income?> GetByIdAsync(Guid id);

    IList<Income> GetAll();

    Task<IList<Income>> GetAllAsync();

    Task<IList<Income>> GetAllByCategoryNameAsync(string name);

    Task<IList<Income>> GetAllByUserNameAsync(string userName);

    Task<IList<Income>> GetAllByCurrencyAsync(string name);

    Income Add(AddIncomeDTO addIncomeDto);

    Task<Income> AddAsync(AddIncomeDTO addIncomeDto);

    Income Update(AddIncomeDTO addIncomeDto);

    Task<Income> UpdateAsync(AddIncomeDTO addIncomeDto);

    void DeleteById(Guid id);

    Task DeleteByIdAsync(Guid id);
}

