using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebUI.Areas.Admin.Controllers
{
    public class RecipeController : Controller
    {
        ISpecificationService _specificationService;
        ICategoryService _categoryService;
        ISpecificationMaterialService _specificationMaterialService;
        IMaterialService _materialService;

        public RecipeController(ISpecificationService specificationService, ICategoryService categoryService, ISpecificationMaterialService specificationMaterialService, IMaterialService materialService)
        {
            _specificationService = specificationService;
            _categoryService = categoryService;
            _specificationMaterialService = specificationMaterialService;
            _materialService = materialService;
        }

        public class SpecificationMetarialDto
        {
            public  int SpecificationId { get; set; }
            public  int CategoryId { get; set; }
            public  int MaterialId { get; set; }
            public string Description { get; set; }
            public  int Slug { get; set; }
            public  string Gauger { get; set; }
            public  string Image { get; set; }
            public  DateTime DateTime { get; set; }
        }

        public class RecipeMaterial
        {
            public int MaterialId { get; set; }
            public int Slug { get; set; }
            public string Gauger { get; set; }
        }
        public static List<RecipeMaterial> specificationMaterials = new List<RecipeMaterial>();

        public IActionResult Index()
        {
            ViewBag.categories=_categoryService.GetAll().Data;
            ViewBag.materials=_materialService.GetAll().Data;
            return View();
        }
        [HttpPost]
        public JsonResult Added(SpecificationMetarialDto specification)
        {
            Specification spec=new Specification();
            SpecificationMaterial specificationMaterial=new SpecificationMaterial();
            spec.ViewCount = 0;
            spec.DateTime = DateTime.Now;
            spec.Description = specification.Description;
            spec.CategoryId = specification.CategoryId;
            var addSpecification = _specificationService.Add(spec);
            var result = _specificationService.GetById(addSpecification);
            specificationMaterial.SpecificationId = result.Data.Id;
            foreach (RecipeMaterial item in specificationMaterials)
            {
                specificationMaterial.MaterialId = item.MaterialId;
                specificationMaterial.Gauger = item.Gauger;
                specificationMaterial.Slug=item.Slug;
                _specificationMaterialService.Add(specificationMaterial);
            }
            var smListResult = _specificationMaterialService.GetAllBySpecificationId(addSpecification);
            spec.SpecificationMaterial=smListResult.Data;
            var jsonAddUser = JsonConvert.SerializeObject("Eklendi.");
            return Json(jsonAddUser);
        }
        [HttpGet]
        public void AddMaterial(RecipeMaterial recipeMaterial)
        {
            specificationMaterials.Add(recipeMaterial);
        }
        [HttpPost]
        public JsonResult Deleted(int id)
        {
            var specification = _specificationService.GetById(id);
            var deleteSpecification = _specificationService.Delete(specification.Data);
            var jsonDeleteUser = JsonConvert.SerializeObject(deleteSpecification.Message);
            return Json(jsonDeleteUser);
        }
        [HttpPost]
        public JsonResult User(int id)
        {
            var specification = _specificationService.GetById(id);
            var jsonUser = JsonConvert.SerializeObject(specification.Data);
            return Json(jsonUser);
        }
        [HttpPost]
        public JsonResult Updated(Specification specification)
        {
            var updateSpecification = _specificationService.Update(specification);
            var jsonUpdateUser = JsonConvert.SerializeObject(updateSpecification.Message);
            return Json(jsonUpdateUser);
        }

        [HttpPost]
        public JsonResult SpicificationListele()
        {
            var users = _specificationService.GetBySpecificationDetailsAll();
            var jsonUsers = JsonConvert.SerializeObject(users.Data);
            return Json(jsonUsers);
        }
    }
}
