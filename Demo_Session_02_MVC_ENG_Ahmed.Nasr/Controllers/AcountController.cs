using Microsoft.AspNetCore.Mvc;

namespace Demo_Session_02_MVC_ENG_Ahmed.Nasr.Controllers
{
    public class AcountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
