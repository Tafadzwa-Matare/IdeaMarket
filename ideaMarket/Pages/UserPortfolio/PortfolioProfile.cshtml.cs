using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ideaMarket.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ideaMarket.Pages.Platform
{
    [Authorize]
    public class PortfolioModel : PageModel
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IWebHostEnvironment webHostEnvironment;

        public PortfolioModel(ApplicationDbContext db, UserManager<ApplicationUser> userManager,
                                 SignInManager<ApplicationUser> signInManager,
                                 RoleManager<IdentityRole> roleManager,
                                 IWebHostEnvironment webHostEnvironment)
        {
            this.db = db;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.webHostEnvironment = webHostEnvironment;
        }


        [BindProperty]
        public ApplicationUser myUser { get; set; }

        [BindProperty]
        public List<UserRoleView> UserInRole { get; set; }

        [BindProperty]
        public IFormFile ProfileImage { get; set; }

        public class UserRoleView
        {
            public string RoleId { get; set; }
            public string RoleName { get; set; }
            public bool IsSelected { get; set; }
        }


        public async Task OnGet(int confirmEmail)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            myUser = await userManager.FindByIdAsync(userId);

            TempData["messageSignup"] = confirmEmail;

            UserInRole = new List<UserRoleView>();
            foreach (var role in roleManager.Roles)
            {

                var UserRole = new UserRoleView
                {
                    RoleId = role.Id,
                    RoleName = role.Name
                };

                if (await userManager.IsInRoleAsync(myUser, role.Name))
                {
                    UserRole.IsSelected = true;
                }
                else
                {
                    UserRole.IsSelected = false;
                }

                UserInRole.Add(UserRole);

            };
        }


        public async Task<IActionResult> OnPost(/*List<UserRoleView> UserInRole*/)
        {
            
            var thisUser = await userManager.FindByIdAsync(myUser.Id);

            if (thisUser != null)
            {


                //thisUser.ProfilePicture = UploadedFile();
                //thisUser.Job_Title = myUser.Job_Title;

                //await userManager.UpdateAsync(thisUser);
             
               // thisUser.ProfilePicture = UploadedFile();
                thisUser.FirstName = myUser.FirstName;
                thisUser.Surname = myUser.Surname;
                thisUser.PhoneNumber = myUser.PhoneNumber;
                thisUser.Address = myUser.Address;

                if (ProfileImage != null)
                {
                    //Profile Upload
                    if (myUser.ProfilePicture != null)
                    {
                        string filePath = Path.Combine(webHostEnvironment.WebRootPath, "ProfilePictures", myUser.ProfilePicture);
                        System.IO.File.Delete(filePath);
                    }
                    thisUser.ProfilePicture = UploadedFile();
                }
                                   //Roles Upload
                var roles = await userManager.GetRolesAsync(thisUser);
                var result = await userManager.RemoveFromRolesAsync(thisUser, roles);

                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", "Cannot Remove User From Existing Role");
                    return RedirectToPage("");
                }

                result = await userManager.AddToRolesAsync(thisUser,
                    UserInRole.Where(x => x.IsSelected).Select(y => y.RoleName));

                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", "Cannot add selected roles to user");
                    return RedirectToPage("");
                }
                          
                                                       

                await userManager.UpdateAsync(thisUser);
                await userManager.UpdateAsync(thisUser);
                await db.SaveChangesAsync();
                TempData["message"] = "UpdateProfile";
                return RedirectToPage("/UserPortfolio/PortfolioProfile");
            }

            return RedirectToPage("");

        }

        private string UploadedFile()
        {
            string uniqueFileName = null;

            if (ProfileImage != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "ProfilePictures");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + ProfileImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    ProfileImage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

    }
}