using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstracts;
using Entities.DTOs;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _categoryService.GetAllAsync());
        }

        [HttpGet("GetAllByCategoryType/{type}")]
        public async Task<IActionResult> GetAllByCategoryType(string type)
        {
            return Ok(await _categoryService.GetAllByCategoryTypeAsync(type));
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {

            return Ok(await _categoryService.GetByIdAsync(id));
        }


        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] AddCategoryDTO addCategoryDto)
        {
            return Ok(await _categoryService.AddAsync(addCategoryDto));
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody]AddCategoryDTO addCategoryDto)
        {
            return Ok(await _categoryService.UpdateAsync(addCategoryDto));
        }

        [HttpDelete("DeleteById/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _categoryService.DeleteByIdAsync(id);
            return Ok();
        }
    }
}

