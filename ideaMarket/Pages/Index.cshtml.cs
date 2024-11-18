using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ideaMarket.Data;
using ideaMarket.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MailKit.Net.Smtp;
using MimeKit;
using MailKit.Security;

namespace ideaMarket.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext db, UserManager<ApplicationUser> userManager,
                                 SignInManager<ApplicationUser> signInManager,
                                 RoleManager<IdentityRole> roleManager)
        {
            _logger = logger;
            this.db = db;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }



        public int TotalInvestors { get; set; }
        public int TotalIdeaOwners { get; set; }
        public int TotalMembers { get; set; }
        public int TotalIdeas { get; set; }

        //mail
        [BindProperty]
        public Emails mails { get; set; }


        public void OnGet()
        {
            TotalMembers = db.Users.Count();
            TotalInvestors = db.UserRoles.Where(m => m.RoleId == "a505bf43-f7d7-4861-ab30-be717662f824").Count();
            TotalIdeaOwners = db.UserRoles.Where(m => m.RoleId == "f27463a3-c79c-463c-823f-4429a4c8786d").Count();
            TotalIdeas = db.Ideas.Count();
        }

        public async Task<IActionResult> OnPost()
        {
            var msg = new MimeMessage();
            msg.To.Add(new MailboxAddress("Idea Market", "ideamarket.ict@gmail.com"));
            msg.From.Add(new MailboxAddress("Idea Market Web", mails.From));
            msg.Subject = mails.Subject + " From " +mails.From;


            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = mails.Body;
            bodyBuilder.TextBody = "Idea Market!";
            msg.Body = bodyBuilder.ToMessageBody();

            using (var smtp = new SmtpClient())
            {

                smtp.Connect("smtp.gmail.com", 25);
                smtp.Authenticate("ideamarket.ict@gmail.com", "th1nkb1g");
               
                smtp.Send(msg);
                smtp.Disconnect(true);


            }

            TempData["Message"] = "EmailSent";
            return RedirectToPage("/Index");

        }

    }
}
