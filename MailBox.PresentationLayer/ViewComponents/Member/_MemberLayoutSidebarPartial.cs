using MailBox.BusinessLayer.Abstract;
using MailBox.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MailBox.PresentationLayer.ViewComponents.Member
{
    public class _MemberLayoutSidebarPartial : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMailService _mailService;
        public _MemberLayoutSidebarPartial(UserManager<AppUser> userManager, IMailService mailService)
        {
            _userManager = userManager;
            _mailService = mailService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.user = user.Name + " " + user.Surname;
            ViewBag.email = user.Email;
            ViewBag.ImageUrl = user.ImageUrl;
            var Inbox = _mailService.TGetSendandReceiverMailnameListAllbyReceiverId(user.Id).Count();
            ViewBag.Inbox = Inbox;

            var Sendbox = _mailService.TGetSendandReceiverMailnameListAllbySenderId(user.Id).Count();
            ViewBag.Sendbox = Sendbox;

            var Draft = _mailService.TGetSendandReceiverMailnameListAllbyDraftSenderId(user.Id).Count();
            ViewBag.Draft = Draft;

            var Starred = _mailService.TGetSendandReceiverMailnameListAllbyStarredId(user.Id).Count();
            ViewBag.Starred = Starred;

            var Deleted = _mailService.TGetSendandReceiverMailnameListAllbyDeletedId(user.Id).Count();
            ViewBag.Deleted = Deleted;

            var Spam = _mailService.TGetSendandReceiverMailnameListAllbySpamId(user.Id).Count();
            ViewBag.Spam = Spam;

            return View();
        } 
    }
}
