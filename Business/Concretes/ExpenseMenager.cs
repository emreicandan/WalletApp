using System;
using Business.Abstracts;
using Business.Validations;
using DataAccess.Abstracts;
using Entities.DTOs;
using Entities.Models;

namespace Business.Concretes;

public class ExpenseMenager:IExpenseService
{
	private readonly IExpenseRepository _expenseRepository;
	private readonly ExpenseValidations _expenseValidations;

	public ExpenseMenager(IExpenseRepository expenseRepository , ExpenseValidations expenseValidations)
	{
		_expenseRepository = expenseRepository;
		_expenseValidations = expenseValidations;
	}

    public Expense Add(AddExpenseDTO addExpenseDTO)
    {
        var expense = new Expense();

        expense.UserId = addExpenseDTO.UserId;
        expense.CategoryId = addExpenseDTO.CategoryId;
        expense.CurrencyId = addExpenseDTO.CurrencyId;
        expense.Amount = addExpenseDTO.Amount;
        expense.Description = addExpenseDTO.Description;
        expense.TransacitonDate = addExpenseDTO.TransacitonDate;
        _expenseValidations.ExpenseMustNotBeEmpty(expense).Wait();
        return _expenseRepository.Add(expense);
    }

    public async Task<Expense> AddAsync(AddExpenseDTO addExpenseDTO)
    {
        var expense = new Expense();

        expense.UserId = addExpenseDTO.UserId;
        expense.CategoryId = addExpenseDTO.CategoryId;
        expense.CurrencyId = addExpenseDTO.CurrencyId;
        expense.Amount = addExpenseDTO.Amount;
        expense.Description = addExpenseDTO.Description;
        expense.TransacitonDate = addExpenseDTO.TransacitonDate;
        await _expenseValidations.ExpenseMustNotBeEmpty(expense);
        return await _expenseRepository.AddAsync(expense);
    }

    public void DeleteById(Guid id)
    {
        var expense = _expenseRepository.Get(e => e.Id == id);
        _expenseValidations.ExpenseMustNotBeEmpty(expense).Wait();
        _expenseRepository.Delete(expense);
    }

    public async Task DeleteByIdAsync(Guid id)
    {
        var expense = _expenseRepository.Get(e => e.Id == id);
        await _expenseValidations.ExpenseMustNotBeEmpty(expense);
        await _expenseRepository.DeleteAsync(expense);
    }

    public Expense? GetById(Guid id)
    {
        return _expenseRepository.Get(e => e.Id == id);
    }

    public IList<Expense> GetAll()
    {
        return _expenseRepository.GetAll().ToList();
    }

    public async Task<IList<Expense>> GetAllAsync()
    {
        var expenseList = await _expenseRepository.GetAllAsync();
        return expenseList.ToList();
    }

    public async Task<IList<Expense>> GetAllByCategoryNameAsync(string name)
    {
        var expenseList = await _expenseRepository.GetAllAsync(e => e.Category.Name == name);
        return expenseList.ToList();
    }

    public async Task<IList<Expense>> GetAllByCurrencyAsync(string name)
    {
        var expenseList = await _expenseRepository.GetAllAsync(e => e.Currency.Name == name);
        return expenseList.ToList();
    }

    public async Task<IList<Expense>> GetAllByUserNameAsync(string userName)
    {
        var expenseList = await _expenseRepository.GetAllAsync(e => e.User.UserName == userName);
        return expenseList.ToList();
    }

    public Task<Expense?> GetByIdAsync(Guid id)
    {
        return _expenseRepository.GetAsync(e => e.Id == id);
    }

    public Expense Update(AddExpenseDTO addExpenseDTO)
    {
        var expense = new Expense();

        expense.UserId = addExpenseDTO.UserId;
        expense.CategoryId = addExpenseDTO.CategoryId;
        expense.CurrencyId = addExpenseDTO.CurrencyId;
        expense.Amount = addExpenseDTO.Amount;
        expense.Description = addExpenseDTO.Description;
        expense.TransacitonDate = addExpenseDTO.TransacitonDate;

        _expenseValidations.ExpenseMustNotBeEmpty(expense).Wait();
        return _expenseRepository.Update(expense);
    }

    public async Task<Expense> UpdateAsync(AddExpenseDTO addExpenseDTO)
    {
        var expense = new Expense();

        expense.UserId = addExpenseDTO.UserId;
        expense.CategoryId = addExpenseDTO.CategoryId;
        expense.CurrencyId = addExpenseDTO.CurrencyId;
        expense.Amount = addExpenseDTO.Amount;
        expense.Description = addExpenseDTO.Description;
        expense.TransacitonDate = addExpenseDTO.TransacitonDate;

        await _expenseValidations.ExpenseMustNotBeEmpty(expense);
        return await _expenseRepository.UpdateAsync(expense);
    }
}

