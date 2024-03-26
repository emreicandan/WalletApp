using System;
using Entities.DTOs;
using Entities.Models;

namespace Business.Abstracts;

public interface ICategoryService
{
    Category? GetById(Guid id);

    Task<Category?> GetByIdAsync(Guid id);

    IList<Category> GetAll();

    Task<IList<Category>> GetAllAsync();

    IList<Category> GetAllByCategoryType(string type);

    Task<IList<Category>> GetAllByCategoryTypeAsync(string type);

    Category Add(AddCategoryDTO addCategoryDto);

    Task<Category> AddAsync(AddCategoryDTO addCategoryDto);

    Category Update(AddCategoryDTO addCategoryDto);

    Task<Category> UpdateAsync(AddCategoryDTO addCategoryDto);

    void DeleteById(Guid id);

    Task DeleteByIdAsync(Guid id);
}

