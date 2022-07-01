using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using Entities.DTO_s;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebUI.Controllers
{
    public class RepiceController : Controller
    {
        ISpecificationService _specificationService;
        ICategoryService _categoryService;

        public RepiceController(ISpecificationService specificationService, ICategoryService categoryService)
        {
            _specificationService = specificationService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            ViewBag.categories = _categoryService.GetAll().Data;
            ViewBag.specifications=_specificationService.GetAll().Data;
            return View();
        }
        public JsonResult GetAll()
        {            
            var result=_specificationService.GetAll();
            var jsonResult=JsonConvert.SerializeObject(result.Data.ToList());
            return Json(jsonResult);
        }
        public JsonResult GetCategory()
        {
            var result=_categoryService.GetAll();
            var jsonResult = JsonConvert.SerializeObject(result.Data.ToList());
            return Json(jsonResult);
        }
        public IActionResult RepiceGetDetail(int id)
        {
            var recipeDetails = _specificationService.GetById(id).Data;
            ViewBag.recipeMetarials = _specificationService.GetByMetarialDetailAll(id).Data;
            return View(recipeDetails);
        }
        public IActionResult GetRepiceByCategory(int id)
        {
            ViewBag.repices = _specificationService.GetSpecifacationByCategory(id).Data;
            ViewBag.category = _categoryService.GetById(id).Data;
            return View();
        }
        [HttpGet]
        public IActionResult AddRecipe()
        {
            //_specificationManager.Add();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRecipe(IFormFile file)
        {
            if (file != null)
            {
                string fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/{fileName}");
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            };
            //_specificationManager.Add();
            return View(nameof(GetAll));
        }
    }
}
