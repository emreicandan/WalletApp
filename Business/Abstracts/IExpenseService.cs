using System;
using Entities.DTOs;
using Entities.Models;

namespace Business.Abstracts;

public interface IExpenseService
{
    Expense? GetById(Guid id);

    Task<Expense?> GetByIdAsync(Guid id);

    IList<Expense> GetAll();

    Task<IList<Expense>> GetAllAsync();
    
    Task<IList<Expense>> GetAllByCategoryNameAsync(string name);

    Task<IList<Expense>> GetAllByUserNameAsync(string name);

    Task<IList<Expense>> GetAllByCurrencyAsync(string name);

    Expense Add(AddExpenseDTO addExpenseDTO);

    Task<Expense> AddAsync(AddExpenseDTO addExpenseDTO);

    Expense Update(AddExpenseDTO addExpenseDTO);

    Task<Expense> UpdateAsync(AddExpenseDTO addExpenseDTO);

    void DeleteById(Guid id);

    Task DeleteByIdAsync(Guid id);
}

