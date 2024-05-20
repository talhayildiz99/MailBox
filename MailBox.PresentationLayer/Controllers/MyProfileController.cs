using Microsoft.AspNetCore.Mvc;

namespace MailBox.PresentationLayer.Controllers
{
    public class MyProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
