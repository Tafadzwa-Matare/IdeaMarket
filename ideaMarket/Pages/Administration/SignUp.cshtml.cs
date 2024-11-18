using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using Microsoft.Extensions.WebEncoders;
using System.Threading.Tasks;
using ideaMarket.Controllers;
using ideaMarket.Data;
using ideaMarket.Email;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace ideaMarket.Pages.Administration
{
    public class SignUpModel : PageModel
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IEmailSender emailSender;

        public SignUpModel(ApplicationDbContext db,
                                UserManager<ApplicationUser> userManager,
                                SignInManager<ApplicationUser> signInManager,
                                IEmailSender emailSender)
        {
            this.db = db;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.emailSender = emailSender;
        }


        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required]
            public string FirstName { get; set; }

            [Required]
            public string Surname { get; set; }

            [Display(Name = "UserName")]
            public string Username { get; set; }

            [Display(Name = "Phone Number")]
            public string PhoneNumber { get; set; }

            [EmailAddress]
            public string Email { get; set; }

            [Required]
            public string Address { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }


        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)
            {
                //UserManager service is an API that is responsible for user manipulation, add, update and delete.
                //UserManager has methods like createasync, updateasync and deleteasync
                //it has one attribute IdentityUser which can be edited.
                //user is as object of class IdentityUser with the passed in operators.
                var user = new ApplicationUser {UserName = Input.Email,  FirstName = Input.FirstName, Surname = Input.Surname, PhoneNumber = Input.PhoneNumber, Email = Input.Email, Address = Input.Address };
                var result = await userManager.CreateAsync(user, Input.Password);

                if (result.Succeeded)
                {

                    //SignInManager is service that has same properties as the usermanager service but instead is used for signing a user in and has Sign in methods.

                    var code = await userManager.GenerateEmailConfirmationTokenAsync(user);

                    var callbackUrl = Url.Page(
                        "/Administration/ConfirmEmail",
                        pageHandler: null, 
                        values: new { code=code, userId = user.Id  },
                        protocol: Request.Scheme);


                    await emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                      $"Please confirm your account by Clicking on The following Link:                                                                                                                            " +
                      $" " +
                      $" {(callbackUrl)}                                                                                 " +
                      $"" +                    
                      $"(Please Copy and paste the URL to your browser if the link doesn't work.)");



                    //var confirmationLink = Url.Action("ConfirmEmail", "Email", new { token, email = user.Email }, Request.Scheme);
                    //EmailHelper emailHelper = new EmailHelper();
                    //bool emailResponse = emailHelper.SendEmail("mataretafadzwa@gmail.com", callbackUrl);


                    await signInManager.SignInAsync(user, isPersistent: false);
                  //  return LocalRedirect(returnUrl);
                    //TempData["message"] = "Registered";
                    return RedirectToPage("/Administration/EmailPreConfirmation");
                }

                foreach (var error in result.Errors)
                {
                    TempData["message"] = "RegistrationFailed";
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return Page();
        }


    } 
}