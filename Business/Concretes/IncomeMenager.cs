using System;
using Business.Abstracts;
using Business.Validations;
using DataAccess.Abstracts;
using Entities.DTOs;
using Entities.Models;

namespace Business.Concretes;

public class IncomeMenager:IIncomeService
{
    private readonly IIncomeReposiyory _incomeReposiyory;
    private readonly IncomeValidations _incomeValidations;
	public IncomeMenager(IIncomeReposiyory incomeReposiyory , IncomeValidations incomeValidations)
	{
        _incomeReposiyory = incomeReposiyory;
        _incomeValidations = incomeValidations;
	}

    public Income Add(AddIncomeDTO addIncomeDto)
    {
        var income = new Income();
        income.UserId = addIncomeDto.UserId;
        income.CategoryId = addIncomeDto.CategoryId;
        income.CurrencyId = addIncomeDto.CurrencyId;
        income.Amount = addIncomeDto.Amount;
        income.TransactionDate = addIncomeDto.TransactionDate;
        income.Description = addIncomeDto.Description;

        _incomeValidations.IncomeMustNotBeEmpty(income).Wait();
        return _incomeReposiyory.Add(income);
    }

    public async Task<Income> AddAsync(AddIncomeDTO addIncomeDto)
    {
        var income = new Income();
        income.UserId = addIncomeDto.UserId;
        income.CategoryId = addIncomeDto.CategoryId;
        income.CurrencyId = addIncomeDto.CurrencyId;
        income.Amount = addIncomeDto.Amount;
        income.TransactionDate = addIncomeDto.TransactionDate;
        income.Description = addIncomeDto.Description;

        await _incomeValidations.IncomeMustNotBeEmpty(income);
        return await _incomeReposiyory.AddAsync(income);
    }

    public void DeleteById(Guid id)
    {
        var income = _incomeReposiyory.Get(i => i.Id == id);
        _incomeValidations.IncomeMustNotBeEmpty(income).Wait();
        _incomeReposiyory.Delete(income);
    }

    public async Task DeleteByIdAsync(Guid id)
    {
        var income = _incomeReposiyory.Get(i => i.Id == id);
        await _incomeValidations.IncomeMustNotBeEmpty(income);
        await _incomeReposiyory.DeleteAsync(income);
    }

    public IList<Income> GetAll()
    {
        return _incomeReposiyory.GetAll().ToList();
    }

    public async Task<IList<Income>> GetAllAsync()
    {
        var incomeList = await _incomeReposiyory.GetAllAsync();
        return incomeList.ToList();
    }

    public async Task<IList<Income>> GetAllByCategoryNameAsync(string name)
    {
        var income = await _incomeReposiyory.GetAllAsync(i => i.Category.Name == name);
        return income.ToList();
    }

    public async Task<IList<Income>> GetAllByCurrencyAsync(string name)
    {
        var income = await _incomeReposiyory.GetAllAsync(i => i.Currency.Name == name);
        return income.ToList();
    }

    public async Task<IList<Income>> GetAllByUserNameAsync(string userName)
    {
        var income = await _incomeReposiyory.GetAllAsync(i => i.User.UserName == userName);
        return income.ToList();
    }

    public Income? GetById(Guid id)
    {
        return _incomeReposiyory.Get(i => i.Id == id);
    }

    public async Task<Income?> GetByIdAsync(Guid id)
    {
        return await _incomeReposiyory.GetAsync(i => i.Id == id);
    }

    public Income Update(AddIncomeDTO addIncomeDto)
    {
        var income = new Income();
        income.UserId = addIncomeDto.UserId;
        income.CategoryId = addIncomeDto.CategoryId;
        income.CurrencyId = addIncomeDto.CurrencyId;
        income.Amount = addIncomeDto.Amount;
        income.Description = addIncomeDto.Description;
        income.TransactionDate = addIncomeDto.TransactionDate;
        _incomeValidations.IncomeMustNotBeEmpty(income).Wait();

        return _incomeReposiyory.Update(income);
    }

    public async Task<Income> UpdateAsync(AddIncomeDTO addIncomeDto)
    {
        var income = new Income();
        income.UserId = addIncomeDto.UserId;
        income.CategoryId = addIncomeDto.CategoryId;
        income.CurrencyId = addIncomeDto.CurrencyId;
        income.Amount = addIncomeDto.Amount;
        income.Description = addIncomeDto.Description;
        income.TransactionDate = addIncomeDto.TransactionDate;

        await _incomeValidations.IncomeMustNotBeEmpty(income);
        return await _incomeReposiyory.UpdateAsync(income);
    }
}

