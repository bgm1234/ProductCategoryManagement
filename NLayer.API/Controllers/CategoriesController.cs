using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using NLayer.Core.Models;
using NLayer.Core.Services;

namespace NLayer.API.Controllers
{
   
    public class CategoriesController: CustomBaseController
    {
       
        private readonly ICategoryServise _categoryService;
        public CategoriesController( ICategoryServise categoryServise)
        {
           _categoryService = categoryServise;
        }

        // api/categories/GetSingleCategoryByIdWithProducts/2
        [HttpGet("[action]/{categoryId}")]
        public async Task<IActionResult> GetSingleCategoryByIdWithProductsAsync(int categoryId)
        {
            return CreateActionResult(await _categoryService.GetSingleCategoryByIdWithProductsAsync(categoryId));
        }
    }

}
