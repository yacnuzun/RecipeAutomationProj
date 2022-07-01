using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebUI.Areas.Admin.Controllers
{
    public class MaterialController : Controller
    {
        IMaterialService _materialService;

        public MaterialController(IMaterialService materialService)
        {
            _materialService = materialService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public JsonResult Added(Material material)
        {

            var addMaterial = _materialService.Add(material);
            var jsonAddMaterial = JsonConvert.SerializeObject(addMaterial);
            return Json(jsonAddMaterial);
        }
        [HttpPost]
        public JsonResult Deleted(int id)
        {
            var user = _materialService.GetById(id);
            var deleteMaterial = _materialService.Delete(user.Data);
            var jsonDeleteMaterial = JsonConvert.SerializeObject(deleteMaterial.Message);
            return Json(jsonDeleteMaterial);
        }
        [HttpPost]
        public JsonResult Material(int id)
        {
            var material = _materialService.GetById(id);
            var jsonMaterial = JsonConvert.SerializeObject(material.Data);
            return Json(jsonMaterial);
        }
        [HttpPost]
        public JsonResult Updated(Material material)
        {
            var updateMaterial = _materialService.Update(material);
            var jsonUpdateMaterial = JsonConvert.SerializeObject(updateMaterial.Message);
            return Json(jsonUpdateMaterial);
        }

        [HttpPost]
        public JsonResult MaterialListele()
        {
            var material = _materialService.GetAll();
            var jsonMaterial = JsonConvert.SerializeObject(material.Data);
            return Json(jsonMaterial);
        }
    }
}
