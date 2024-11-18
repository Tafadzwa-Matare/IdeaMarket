using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ideaMarket.Data;
using ideaMarket.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ideaMarket.Pages.Platform
{
    [Authorize]
    public class portfolioNewIdeaModel : PageModel
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IWebHostEnvironment webHostEnvironment;
        public portfolioNewIdeaModel(ApplicationDbContext db, UserManager<ApplicationUser> userManager,
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

        public ApplicationUser myUser { get; set; }

        [BindProperty]
        public Ideas Idea { get; set; }

        [BindProperty]
        public IFormFile IdeaPicture { get; set; }

        [BindProperty]
        public IFormFile IdeaPlan { get; set; }

        [TempData]
        public string NewIdeaMessage { get; set; }

        public async Task OnGet()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            myUser = await userManager.FindByIdAsync(userId);

            
        }

        public async Task<IActionResult> OnPostNewIdea()
        {
            Idea.IdeaPicture = UploadIdeaPicture();
            Idea.IdeaPlan = UploadIdeaPlan();

            if (Idea.MinimumCapital <= 100)
            {
                Idea.ideaGrade = "A";
            }
            else if (Idea.MinimumCapital > 100 && Idea.MinimumCapital <= 500)
            {
                Idea.ideaGrade = "B";
            }
            else if (Idea.MinimumCapital > 500 && Idea.MinimumCapital <= 1000)
            {
                Idea.ideaGrade = "C";
            }
            else if (Idea.MinimumCapital > 1000 && Idea.MinimumCapital <= 5000)
            {
                Idea.ideaGrade = "D";
            }
            else if (Idea.MinimumCapital > 5000)
            {
                Idea.ideaGrade = "E";
            }
            else
            {
                Idea.ideaGrade = "UNGRADED";
            }



            if (Idea.IdeaPlan == null)
            {
                TempData["message"] = "MissingPlan";
                return Page();
            }
            if (ModelState.IsValid)
            {               
                db.Ideas.Add(Idea);
                await db.SaveChangesAsync();
                NewIdeaMessage = "New Idea Successfully Uploaded";
                TempData["message"] = "Added";
                return RedirectToPage("/UserPortfolio/PortfolioProfile");
            }
            else{
                TempData["message"] = "FailedUploadNewIdea";
                return Page();
            }
            
        }



        private string UploadIdeaPicture()
        {
            string uniqueFileName = null;

            if (IdeaPicture != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "../wwwroot/IdeaPictures");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + IdeaPicture.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    IdeaPicture.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        private string UploadIdeaPlan()
        {
            string uniqueFileName = null;

            if (IdeaPlan != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "../wwwroot/IdeaPlans");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + IdeaPlan.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    IdeaPlan.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

    }
}