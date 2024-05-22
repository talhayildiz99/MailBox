using Microsoft.AspNetCore.Mvc;

namespace MailBox.PresentationLayer.Controllers
{
    public class InboxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
