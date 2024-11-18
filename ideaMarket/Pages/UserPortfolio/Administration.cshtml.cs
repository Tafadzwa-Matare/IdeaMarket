using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ideaMarket.Data;
using ideaMarket.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ideaMarket.Pages.UserPortfolio
{
    public class AdministrationModel : PageModel
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IWebHostEnvironment webHostEnvironment;

        public AdministrationModel(ApplicationDbContext db, UserManager<ApplicationUser> userManager,
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
        public News News { get; set; }

        [BindProperty]
        public Articles Articles { get; set; }

        [BindProperty]
        public IFormFile NewsPicture { get; set; }

        [BindProperty]
        public IFormFile ArticlePicture { get; set; }



        public int TotalInvestors { get; set; }
        public int TotalIdeaOwners { get; set; }
        public int TotalMembers { get; set; }




        /* --IdeaMarket CHART VALUES-- */
        //January Values
        public int JanIdeasTotal { get; set; }
        public int JanInvestmentsActivities { get; set; }

        //February Values
        public int FebIdeasTotal { get; set; }
        public int FebInvestmentsActivities { get; set; }

        //March Values
        public int MarIdeasTotal { get; set; }
        public int MarInvestmentsActivities { get; set; }

        //April Values
        public int AprIdeasTotal { get; set; }
        public int AprInvestmentsActivities { get; set; }

        //May Values
        public int MayIdeasTotal { get; set; }
        public int MayInvestmentsActivities { get; set; }

        //June Values
        public int JunIdeasTotal { get; set; }
        public int JunInvestmentsActivities { get; set; }

        //July Values
        public int JulIdeasTotal { get; set; }
        public int JulInvestmentsActivities { get; set; }

        //August Values
        public int AugIdeasTotal { get; set; }
        public int AugInvestmentsActivities { get; set; }

        //September Values
        public int SepIdeasTotal { get; set; }
        public int SepInvestmentsActivities { get; set; }

        //October Values
        public int OctIdeasTotal { get; set; }
        public int OctInvestmentsActivities { get; set; }

        //November Values
        public int NovIdeasTotal { get; set; }
        public int NovInvestmentsActivities { get; set; }

        //December Values
        public int DecIdeasTotal { get; set; }
        public int DecInvestmentsActivities { get; set; }





        public void OnGet()
        {
            TotalMembers = db.Users.Count();
            TotalInvestors = db.UserRoles.Where(m => m.RoleId == "a505bf43-f7d7-4861-ab30-be717662f824").Count();
            TotalIdeaOwners = db.UserRoles.Where(m => m.RoleId == "f27463a3-c79c-463c-823f-4429a4c8786d").Count();


            var Ideas = db.Ideas;
            var Investments = db.Investments;

            //January
            JanIdeasTotal = Ideas.Where(m => m.DateLaunched.Date.Month.Equals(1)).Count();
            JanInvestmentsActivities = Investments.Where(m => m.DateInvested.Date.Month.Equals(1)).Count();

            //February
            FebIdeasTotal = Ideas.Where(m => m.DateLaunched.Date.Month.Equals(2)).Count();
            FebInvestmentsActivities = Investments.Where(m => m.DateInvested.Date.Month.Equals(2)).Count();

            //March
            MarIdeasTotal = Ideas.Where(m => m.DateLaunched.Date.Month.Equals(3)).Count();
            MarInvestmentsActivities = Investments.Where(m => m.DateInvested.Date.Month.Equals(3)).Count();

            //April
            AprIdeasTotal = Ideas.Where(m => m.DateLaunched.Date.Month.Equals(4)).Count();
            AprInvestmentsActivities = Investments.Where(m => m.DateInvested.Date.Month.Equals(4)).Count();

            //May
            MayIdeasTotal = Ideas.Where(m => m.DateLaunched.Date.Month.Equals(5)).Count();
            MayInvestmentsActivities = Investments.Where(m => m.DateInvested.Date.Month.Equals(5)).Count();

            //June
            JunIdeasTotal = Ideas.Where(m => m.DateLaunched.Date.Month.Equals(6)).Count();
            JunInvestmentsActivities = Investments.Where(m => m.DateInvested.Date.Month.Equals(6)).Count();

            //July
            JulIdeasTotal = Ideas.Where(m => m.DateLaunched.Date.Month.Equals(7)).Count();
            JulInvestmentsActivities = Investments.Where(m => m.DateInvested.Date.Month.Equals(7)).Count();

            //August
            AugIdeasTotal = Ideas.Where(m => m.DateLaunched.Date.Month.Equals(8)).Count();
            AugInvestmentsActivities = Investments.Where(m => m.DateInvested.Date.Month.Equals(8)).Count();

            //September
            SepIdeasTotal = Ideas.Where(m => m.DateLaunched.Date.Month.Equals(9)).Count();
            SepInvestmentsActivities = Investments.Where(m => m.DateInvested.Date.Month.Equals(9)).Count();

            //October
            OctIdeasTotal = Ideas.Where(m => m.DateLaunched.Date.Month.Equals(10)).Count();
            OctInvestmentsActivities = Investments.Where(m => m.DateInvested.Date.Month.Equals(10)).Count();

            //November
            NovIdeasTotal = Ideas.Where(m => m.DateLaunched.Date.Month.Equals(11)).Count();
            NovInvestmentsActivities = Investments.Where(m => m.DateInvested.Date.Month.Equals(11)).Count();

            //December
            DecIdeasTotal = Ideas.Where(m => m.DateLaunched.Date.Month.Equals(12)).Count();
            DecInvestmentsActivities = Investments.Where(m => m.DateInvested.Date.Month.Equals(12)).Count();


        }


        public async Task<IActionResult> OnPostNews()
        {
                News.NewsPicture = UploadNewsPicture();
                db.Add(News);
                await db.SaveChangesAsync();
                return RedirectToPage("");
          

        }

        public async Task<IActionResult> OnPostArticles()
        {

                Articles.ArticlePicture = UploadArticlePicture();
                db.Add(Articles);
                await db.SaveChangesAsync();
                return RedirectToPage("");
           
        }


        private string UploadNewsPicture()
        {
            string uniqueFileName = null;

            if (NewsPicture != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "../wwwroot/NewsPictures");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + NewsPicture.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    NewsPicture.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }


        private string UploadArticlePicture()
        {
            string uniqueFileName = null;

            if (ArticlePicture != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "../wwwroot/ArticlesPictures");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + ArticlePicture.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    ArticlePicture.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

    }
}