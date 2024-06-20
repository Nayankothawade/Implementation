﻿using Microsoft.AspNetCore.Mvc;
using SecureApp.Services;
using SecureApp.Models;
using MailKit.Net.Smtp;
using MimeKit;

namespace SecureApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthRequest model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });
            return Ok(response);
        }

        [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
   
        [HttpPost]  
        public ActionResult SendMessage()  
        {  
        
            MimeMessage message = new MimeMessage();

            MailboxAddress from = new MailboxAddress("Admin", "admin@example.com");
            message.From.Add(from);

            MailboxAddress to = new MailboxAddress("User", "user@example.com");
            message.To.Add(to);

            message.Subject = "This is email subject";
            
            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = "<h1>Hello World!</h1>";
            bodyBuilder.TextBody = "Hello World!";
            message.Body = bodyBuilder.ToMessageBody();


            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, true);
            client.Authenticate("ravi.tambade@transflower.in", "pwd_here");

            client.Send(message);
            client.Disconnect(true);
            client.Dispose();

            return Ok();
        }  

        [HttpPost]  
        public ActionResult SendSMSMessage()  
            {  
                /* Message message=new Message();
                var results = SMS.Send(new SMS.SMSRequest  
                {  
                    from = Configuration.Instance.Settings["appsettings:NEXMO_FROM_NUMBER"],  
                    to = message.To,  
                    text = message.ContentMsg  
                });   */
                return Ok();  
            }  
        }
    }