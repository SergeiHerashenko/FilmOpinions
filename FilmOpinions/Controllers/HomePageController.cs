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
    }
}
