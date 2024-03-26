using System;
using Business.Abstracts;
using Business.Validations;
using DataAccess.Abstracts;
using Entities.DTOs;
using Entities.Models;

namespace Business.Concretes;

public class CurrencyMenager:ICurrencyService
{
    private readonly ICurrencyRepository _currencyRepository;
    private readonly CurrencyValidations _currencyValidations;
	public CurrencyMenager(ICurrencyRepository currencyRepository,CurrencyValidations currencyValidations)
	{
        _currencyRepository = currencyRepository;
        _currencyValidations = currencyValidations;
	}

    public Currency Add(AddCurrencyDTO addCurrencyDTO)
    {
        var currency = new Currency();
        currency.Name = addCurrencyDTO.Name;
        _currencyValidations.CurrencyMustNotBeEmpty(currency).Wait();
        return _currencyRepository.Add(currency);
    }

    public async Task<Currency> AddAsync(AddCurrencyDTO addCurrencyDTO)
    {
        var currency = new Currency();
        currency.Name = addCurrencyDTO.Name;
        await _currencyValidations.CurrencyMustNotBeEmpty(currency);
        return await _currencyRepository.AddAsync(currency);
    }

    public void DeleteById(Guid id)
    {
        var currency = _currencyRepository.Get(c => c.Id == id);
        _currencyValidations.CurrencyMustNotBeEmpty(currency).Wait();
        _currencyRepository.Delete(currency);
    }

    public async Task DeleteByIdAsync(Guid id)
    {
        var currency = _currencyRepository.Get(c => c.Id == id);
        await _currencyValidations.CurrencyMustNotBeEmpty(currency);
        await _currencyRepository.DeleteAsync(currency);
    }

    public IList<Currency> GetAll()
    {
        var currencyList = _currencyRepository.GetAll();
        return currencyList.ToList();
    }

    public async Task<IList<Currency>> GetAllAsync()
    {
        var currencyList = await _currencyRepository.GetAllAsync();
        return currencyList.ToList();
    }

    public Currency? GetById(Guid id)
    {
        return _currencyRepository.Get(c => c.Id == id);
    }

    public async Task<Currency?> GetByIdAsync(Guid id)
    {
        return await _currencyRepository.GetAsync(c => c.Id == id);
    }

    public Currency Update(AddCurrencyDTO addCurrencyDTO)
    {
        var currency = new Currency();
        currency.Name = addCurrencyDTO.Name;
        _currencyValidations.CurrencyMustNotBeEmpty(currency).Wait();
        return _currencyRepository.Update(currency);
    }

    public async Task<Currency> UpdateAsync(AddCurrencyDTO addCurrencyDTO)
    {
        var currency = new Currency();
        currency.Name = addCurrencyDTO.Name;
        await _currencyValidations.CurrencyMustNotBeEmpty(currency);
        return await _currencyRepository.UpdateAsync(currency);
    }
}

