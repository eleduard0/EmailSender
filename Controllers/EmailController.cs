﻿using EmailSender.Models;
using EmailSender.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmailSender.Controllers
{
    public class EmailController : Controller
    {
        private readonly IEmailService _emailService;
        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }
        [HttpGet]
        public IActionResult SendEmail()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendEmail(EmailDTO request)
        {
            _emailService.SendEmail(request);
            ViewBag.msg = "El correo se envió correctamente, Gracias!";
            return View();
        }
    }
}
