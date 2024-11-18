using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ideaMarket.Data;
using ideaMarket.Email;
using ideaMarket.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ideaMarket.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(ApplicationDbContext db,
                                UserManager<ApplicationUser> userManager,
                                SignInManager<ApplicationUser> signInManager)
        {
            this.db = db;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task <IActionResult> CreateUserAsync(SignUpUserModel userModel)
        {
            var user = new ApplicationUser()
            {
                UserName = userModel.Email,
                FirstName = userModel.FirstName,
                Surname = userModel.Surname,
                PhoneNumber = userModel.PhoneNumber,
                Email = userModel.Email,
                Address = userModel.Address
            };

            IdentityResult result = await userManager.CreateAsync(user, userModel.Password);

            if (result.Succeeded)
            {
                var token = await userManager.GenerateEmailConfirmationTokenAsync(user);
                var confirmationLink = Url.Action("ConfirmEmail", "Email", new { token, email = user.Email }, Request.Scheme);
                EmailHelper emailHelper = new EmailHelper();
                bool emailResponse = emailHelper.SendEmail(user.Email, confirmationLink);

                if (emailResponse)
                    return RedirectToAction("Index");
                else
                {
                    // log email failed 
                }
            }
            else
            {
                foreach (IdentityError error in result.Errors)
                    ModelState.AddModelError("", error.Description);
            }
            return View(user);
        }




        //private async Task SendEmailConfirmationEmail(ApplicationUser user, string token)
        //{
        //     UserEmailOptions 
        //}




         

    }
}