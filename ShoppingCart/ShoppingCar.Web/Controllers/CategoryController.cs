using Microsoft.AspNetCore.Mvc;
using ShoppingCar.Data.Model;
using ShoppingCar.Service.Infraestructure;
using System;
using System.Threading.Tasks;

namespace ShoppingCar.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategory _category;

        public CategoryController(ICategory category)
        {
            _category = category;
        }


        public IActionResult Index()
        {
            return View(_category.GetAllCategories());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                await _category.InsertCategoryAsync(category);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

           var category = await _category.GetCategoryByIdAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Category category, int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                await _category.UpdateCategoryAsync(category);

                try
                {

                }
                catch (Exception)
                {

                    ModelState.AddModelError(string.Empty, "");
                }
                return RedirectToAction(nameof(Index));
            }

            return View();


        }
    }
}
