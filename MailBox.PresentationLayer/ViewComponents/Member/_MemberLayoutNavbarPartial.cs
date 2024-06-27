using MailBox.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MailBox.PresentationLayer.ViewComponents.Member
{
    public class _MemberLayoutNavbarPartial : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _MemberLayoutNavbarPartial(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.user = user.Name + " " + user.Surname;
            ViewBag.ImageUrl = user.ImageUrl;
            return View();
        }
    }
}
