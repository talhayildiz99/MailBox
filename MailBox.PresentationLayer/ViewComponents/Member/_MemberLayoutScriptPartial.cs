﻿using Microsoft.AspNetCore.Mvc;

namespace MailBox.PresentationLayer.ViewComponents.Member
{
    public class _MemberLayoutScriptPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
