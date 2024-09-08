using Microsoft.AspNetCore.Mvc;

namespace Demo_Session_02_MVC_ENG_Ahmed.Nasr.Controllers
{
    public class HomeController : Controller
    {
        // Action --> Non Static

        //public string Index(int id) 
        //{
        //    return $"ID : {id}";
        //}
        //-----------------------
        //public RedirectResult Test()
        //{
        //    return Redirect("https://google.com/");
        //}
        //-------------------------
        //public ContentResult Index(int id)
        //{
        //   return Content($"id : {id}" ,"Object/Pdf");
        //}
        //=======================
        //public IActionResult Index(int id)
        //{
        //    return Content($"id : {id}", "Object/Pdf");
        //}
        //====================
        //public RedirectToActionResult Index(int id)
        //{
        //    return RedirectToAction("Test");
        //}

        /// <summary>
        ///                       ( Views )
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

    }
}
