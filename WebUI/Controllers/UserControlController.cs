using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class UserControlController : Controller
    {
        IUserService _userService;

        public UserControlController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UserControl(User user)
        {
            var result=_userService.UserControl(user.UserName,user.Password);
            if (result.Data == null)
            {
                return Redirect("/Repice/Index");
            }
            return Redirect("/Admin/Recipe/Index");
        }
    }
}
