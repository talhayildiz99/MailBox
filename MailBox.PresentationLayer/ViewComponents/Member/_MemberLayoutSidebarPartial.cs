using Microsoft.AspNetCore.Mvc;

namespace MailBox.PresentationLayer.ViewComponents.Member
{
    public class _MemberLayoutSidebarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        } 
    }
}
