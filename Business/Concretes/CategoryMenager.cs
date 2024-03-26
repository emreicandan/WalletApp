using System;
using Business.Abstracts;
using Business.Validations;
using Core.Aspect.Autofac.Caching;
using DataAccess.Abstracts;
using Entities.DTOs;
using Entities.Models;

namespace Business.Concretes;

public class CategoryMenager : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly CategoryValidation _categoryValidation;

    public CategoryMenager(ICategoryRepository categoryRepository , CategoryValidation categoryValidation)
    {
        _categoryRepository = categoryRepository;
        _categoryValidation = categoryValidation;
    }

    public Category Add(AddCategoryDTO addCategoryDto)
    {
        var category = new Category();
        category.Name = addCategoryDto.Name;
        category.Type = addCategoryDto.Type;

        _categoryValidation.CategoryMustNotBeEmpty(category).Wait();
        _categoryValidation.CheckCategoryName(category).Wait();
        return _categoryRepository.Add(category);
    }
    [CacheRemoveAspect("Business.Concretes.CategoryMenager.AddAsync")]
    public async Task<Category> AddAsync(AddCategoryDTO addCategoryDto)
    {
        var category = new Category();
        category.Name = addCategoryDto.Name;
        category.Type = addCategoryDto.Type;

        await _categoryValidation.CategoryMustNotBeEmpty(category);
        await _categoryValidation.CheckCategoryName(category);
        return await _categoryRepository.AddAsync(category);
    }

    public void DeleteById(Guid id)
    {
        var category = _categoryRepository.Get(c => c.Id == id);
        _categoryValidation.CategoryMustNotBeEmpty(category).Wait();
        _categoryRepository.Delete(category);
    }

    public async Task DeleteByIdAsync(Guid id)
    {
        var category = _categoryRepository.Get(c => c.Id == id);
        await _categoryValidation.CategoryMustNotBeEmpty(category);
        await _categoryRepository.DeleteAsync(category);
    }

    public IList<Category> GetAll()
    {
        return _categoryRepository.GetAll().ToList();
    }

    [CacheAspect(10)]
    public async Task<IList<Category>> GetAllAsync()
    {
        var categoryList = await _categoryRepository.GetAllAsync();
        return categoryList.ToList();
    }

    public IList<Category> GetAllByCategoryType(string type)
    {
        return _categoryRepository.GetAll(c => c.Type == type).ToList();

    }
    [CacheAspect(10)]
    public async Task<IList<Category>> GetAllByCategoryTypeAsync(string type)
    {
        var categoryTypeList = await _categoryRepository.GetAllAsync(c => c.Type.ToLower() == type.ToLower());
        return categoryTypeList.ToList();
    }

    public Category? GetById(Guid id)
    {
        return _categoryRepository.Get(c => c.Id == id);
    }

    public async Task<Category?> GetByIdAsync(Guid id)
    {
        return await _categoryRepository.GetAsync(c => c.Id == id);
    }

    public Category Update(AddCategoryDTO addCategoryDto)
    {
        var category = new Category();
        category.Name = addCategoryDto.Name;
        category.Type = addCategoryDto.Type;

        _categoryValidation.CategoryMustNotBeEmpty(category).Wait();
        _categoryValidation.CheckCategoryName(category).Wait();
        return _categoryRepository.Update(category);
    }

    public async Task<Category> UpdateAsync(AddCategoryDTO addCategoryDto)
    {
        var category = new Category();
        category.Name = addCategoryDto.Name;
        category.Type = addCategoryDto.Type;

        await _categoryValidation.CategoryMustNotBeEmpty(category);
        await _categoryValidation.CheckCategoryName(category);
        return await _categoryRepository.UpdateAsync(category);
    }
}

