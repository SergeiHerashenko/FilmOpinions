using FilmOpinions.Domain.ViewModels.HomePage_Model;
using Microsoft.AspNetCore.Mvc;

namespace FilmOpinions.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult HomePage()
        {
            HomePageModel model = new HomePageModel();
            return View(model);
        }

        // Перенаправлення на сторінку входу / Redirect to the login page
        [HttpPost]
        public IActionResult RedirectToLoginPage()
        {
            return RedirectToAction("LoginPage", "LoginPage");
        }
    }
}
