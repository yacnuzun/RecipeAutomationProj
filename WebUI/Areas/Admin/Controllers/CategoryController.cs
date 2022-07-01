using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebUI.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public JsonResult Added(Category category)
        {

            var addCategory = _categoryService.Add(category);
            var jsonAddCategory = JsonConvert.SerializeObject(addCategory);
            return Json(jsonAddCategory);
        }
        [HttpPost]
        public JsonResult Deleted(int id)
        {
            var category = _categoryService.GetById(id);
            var deleteMaterial = _categoryService.Delete(category.Data);
            var jsonDeleteCategory = JsonConvert.SerializeObject(deleteMaterial.Message);
            return Json(jsonDeleteCategory);
        }
        [HttpPost]
        public JsonResult Category(int id)
        {
            var category = _categoryService.GetById(id);
            var jsonCategory = JsonConvert.SerializeObject(category.Data);
            return Json(jsonCategory);
        }
        [HttpPost]
        public JsonResult Updated(Category category)
        {
            var updateMaterial = _categoryService.Update(category);
            var jsonUpdateCategory = JsonConvert.SerializeObject(updateMaterial.Message);
            return Json(jsonUpdateCategory);
        }

        [HttpPost]
        public JsonResult CategoryListele()
        {
            var category = _categoryService.GetAll();
            var jsonCategory = JsonConvert.SerializeObject(category.Data);
            return Json(jsonCategory);
        }
    }
}
