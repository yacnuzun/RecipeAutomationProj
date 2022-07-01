using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebUI.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        IUserService _userService;
        IRoleService _roleService;

        public UserController(IUserService userService, IRoleService roleService)
        {
            _userService = userService;
            _roleService = roleService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        
        {
            ViewBag.Role = _roleService.GetAll().Data;
            return View();
        }
        [HttpPost]
        public JsonResult Added(User user)
        {

            var addUser=_userService.Add(user);
            var jsonAddUser=JsonConvert.SerializeObject(addUser);
            return Json(jsonAddUser);
        }
        [HttpPost]
        public JsonResult Deleted(int id)
        {
            var user = _userService.GetById(id);
            var deleteUser = _userService.Delete(user.Data);
            var jsonDeleteUser = JsonConvert.SerializeObject(deleteUser.Message);
            return Json(jsonDeleteUser);
        }
        [HttpPost]
        public JsonResult User(int id)
        {
            var user = _userService.GetById(id);
            var jsonUser = JsonConvert.SerializeObject(user.Data);
            return Json(jsonUser);
        }
        [HttpPost]
        public JsonResult Updated(User user)
        {
            var updateUser = _userService.Update(user);
            var jsonUpdateUser = JsonConvert.SerializeObject(updateUser.Message);
            return Json(jsonUpdateUser);
        }
        
        [HttpPost]
        public JsonResult UserListele()
        {
            var users = _userService.GetAll();
            var jsonUsers=JsonConvert.SerializeObject(users.Data);
            return Json(jsonUsers);
        }
    }
}
