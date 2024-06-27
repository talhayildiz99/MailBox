using AutoMapper;
using MailBox.BusinessLayer.Abstract;
using MailBox.EntityLayer.Concrete;
using MailBox.PresentationLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MailBox.PresentationLayer.Controllers
{
    [Authorize]
    public class MailController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMailService _mailService;
        private readonly IMapper _mapper;

        public MailController(UserManager<AppUser> userManager, IMailService mailService, IMapper mapper)
        {
            _userManager = userManager;
            _mailService = mailService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Inbox()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var value = _mailService.TGetSendandReceiverMailnameListAllbyReceiverId(user.Id);
            return View(_mapper.Map<List<MailListModel>>(value));
        }
    }
}
