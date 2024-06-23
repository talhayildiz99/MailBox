using Microsoft.AspNetCore.Mvc;

namespace MailBox.PresentationLayer.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
