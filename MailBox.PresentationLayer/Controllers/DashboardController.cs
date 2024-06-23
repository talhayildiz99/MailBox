using MailBox.BusinessLayer.Abstract;
using MailBox.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MailBox.PresentationLayer.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IMailService _mailService;
        private readonly UserManager<AppUser> _userManager;

        public DashboardController(IMailService mailService, UserManager<AppUser> userManager)
        {
            _mailService = mailService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.TodayDate = DateTime.Now.ToString("d MMMM yyyy");
            ViewBag.Time = DateTime.Now.ToString("HH:mm:ss");
            ViewBag.Total = _mailService.TGetListAll().Count();
            ViewBag.IsRead = _mailService.TGetSendandReceiverMailnameListAllbyReadId(user.Id).Count();
            ViewBag.IsStarred = _mailService.TGetSendandReceiverMailnameListAllbyStarredId(user.Id).Count();
            ViewBag.Draft = _mailService.TGetSendandReceiverMailnameListAllbyDraftSenderId(user.Id).Count();
            ViewBag.Delete = _mailService.TGetSendandReceiverMailnameListAllbyDeletedId(user.Id).Count();
            ViewBag.Spam = _mailService.TGetSendandReceiverMailnameListAllbySpamId(user.Id).Count();
            return View();
        }
    }
}
