using Microsoft.AspNetCore.Mvc;

namespace MailBox.PresentationLayer.ViewComponents.Member
{
    public class _MemberLayoutNavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
