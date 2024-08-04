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

        // Yeni bir mail oluşturma
        [HttpGet]
        public async Task<IActionResult> Compose(int? id)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var draft = _mailService.TGetDraftMailbyId(id);
            if (draft != null)
            {
                var receiver = await _userManager.FindByIdAsync(draft.ReceiverId.ToString());
                var draftMail = new MailListModel
                {
                    MailId = draft.MailId,
                    MailContent = draft.MailContent,
                    MailSubject = draft.MailSubject,
                    ReceiverId = draft.ReceiverId,
                    ReceiverEmail = receiver?.Email
                };
                return View(draftMail);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Compose(MailListModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var mail = _mapper.Map<Mail>(model);
            mail.SenderId = user.Id;
            var receiverUser = await _userManager.FindByEmailAsync(model.ReceiverEmail);
            if (receiverUser != null)
            {
                mail.ReceiverId = receiverUser.Id;
            }
            mail.MailDate = DateTime.Now;
            mail.MailTime = DateTime.Now.TimeOfDay;
            if (mail.ReceiverId == user.Id)
            {
                ViewBag.EmailError = "Kendinize mail gönderemezsiniz.";
                return View(model);
            }
            mail.Sender = null;
            mail.Receiver = null;
            mail.MailId = 0;
            _mailService.TInsert(mail);
            _mailService.TDraftDeletebyId(model.MailId);
            return RedirectToAction("SentMails", "Mail");
        }

        [HttpPost]
        public async Task<IActionResult> DraftAdd(MailListModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var mail = _mapper.Map<Mail>(model);
            mail.SenderId = user.Id;
            var receiverUser = await _userManager.FindByEmailAsync(model.ReceiverEmail);
            if (receiverUser != null)
            {
                mail.ReceiverId = receiverUser.Id;
            }
            mail.MailDate = DateTime.Now;
            mail.MailTime = DateTime.Now.TimeOfDay;
            if (mail.ReceiverId == user.Id)
            {
                ViewBag.EmailError = "Kendinize mail gönderemezsiniz.";
                return View(model);
            }
            mail.IsDraft = true;
            mail.Sender = null;
            mail.Receiver = null;
            _mailService.TInsert(mail);
            return RedirectToAction("Draft", "Mail");
        }

        // IsStarred özelliğini değiştir
        [HttpPost]
        public IActionResult ToggleStarred(int id)
        {
            var mail = _mailService.TGetById(id);
            if (mail != null)
            {
                mail.IsStarred = !mail.IsStarred;
                _mailService.TUpdate(mail);
            }
            return RedirectToAction("Inbox");
        }

        // Mail okuma
        [HttpGet]
        public async Task<IActionResult> ReadMail(int id)
        {
            var mail = _mailService.TGetById(id);
            if (mail == null)
            {
                // Eğer mail bulunamazsa bir hata mesajı göster veya yönlendirme yap
                return NotFound("Mail not found.");
            }

            var sender = await _userManager.FindByIdAsync(mail.SenderId.ToString());
            if (sender != null)
            {
                ViewBag.SenderName = sender.Name + " " + sender.Surname;
                ViewBag.SenderImageUrl = sender.ImageUrl; // Varsayılan profil resmi
            }

            mail.IsRead = true;
            _mailService.TUpdate(mail);

            var values = _mailService.TGetByIddto(id);
            var model = _mapper.Map<MailListModel>(values);

            return View(model);
        }

        // Gelen kutusu
        public async Task<IActionResult> Inbox()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var mails = _mailService.TGetSendandReceiverMailnameListAllbyReceiverId(user.Id);
            var sortedMails = mails.OrderByDescending(m => m.MailDate).ToList();
            var mailModels = _mapper.Map<List<MailListModel>>(sortedMails);
            return View(mailModels);
        }

        // Gönderilen mailler
        public async Task<IActionResult> SentMails()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var mails = _mailService.TGetSendandReceiverMailnameListAllbySenderId(user.Id);
            var mailModels = _mapper.Map<List<MailListModel>>(mails);
            return View(mailModels);
        }

        // Taslaklar sayfası
        public async Task<IActionResult> Draft()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var mails = _mailService.TGetSendandReceiverMailnameListAllbyDraftSenderId(user.Id);
            return View(_mapper.Map<List<MailListModel>>(mails));
        }

        // Yıldızlı mailler
        [HttpGet]
        public async Task<IActionResult> Starred()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var mails = _mailService.TGetSendandReceiverMailnameListAllbyStarredId(user.Id);
            return View(_mapper.Map<List<MailListModel>>(mails));
        }

        // Spam mailler
        [HttpGet]
        public async Task<IActionResult> Junk()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var mails = _mailService.TGetSendandReceiverMailnameListAllbySpamId(user.Id);
            return View(_mapper.Map<List<MailListModel>>(mails));
        }

        // Maili spam yapma
        [HttpPost]
        public async Task<IActionResult> MakeJunk(int id, string redirectAction)
        {
            var mail = _mailService.TGetById(id);
            mail.IsSpam = true;
            _mailService.TUpdate(mail);
            return Json("Ok");
        }

        // Maili çöp kutusuna taşıma
        [HttpPost]
        public async Task<IActionResult> Delete(int id, string redirectAction)
        {
            var mail = _mailService.TGetById(id);
            if (mail != null)
            {
                mail.IsDeleted = true;
                _mailService.TUpdate(mail);
                return RedirectToAction(redirectAction);
            }
            return NotFound();
        }

        // Silinen mailleri listeleme
        [HttpGet]
        public async Task<IActionResult> DeletedMails()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var mails = _mailService.TGetSendandReceiverMailnameListAllbyDeletedId(user.Id);
            return View(_mapper.Map<List<MailListModel>>(mails));
        }


        // Maili kalıcı olarak silme
        [HttpPost]
        public async Task<IActionResult> PermanentlyDelete(int id)
        {
            var mail = _mailService.TGetById(id);
            if (mail != null)
            {
                _mailService.TDelete(id);
                return RedirectToAction("DeletedMails");
            }
            return NotFound();
        }




    }
}
