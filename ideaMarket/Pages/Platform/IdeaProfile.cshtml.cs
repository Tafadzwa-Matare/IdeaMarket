using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ideaMarket.Data;
using ideaMarket.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ideaMarket.Pages.Platform
{
    [Authorize]
    public class IdeaProfileModel : PageModel
    {

        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly ApplicationDbContext db;

        public IdeaProfileModel(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext db)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.db = db;
        }

        [BindProperty]
        public Ideas Idea { get; set; }

        [BindProperty]
        public IEnumerable<Ideas> myIdeas { get; set; }

        [BindProperty]
        public ApplicationUser myUser { get; set; }

        [BindProperty]
        public ApplicationUser thisUser { get; set; }

        [BindProperty]
        public IEnumerable<ApplicationUser> myUsers { get; set; }

        [BindProperty]
        public Investments Investment { get; set; }

        [BindProperty]
        public IList<Investments> IdeaInvestments { get; set; }
        private Task<ApplicationUser> GetCurrentUserAsync() => userManager.GetUserAsync(HttpContext.User);
        public async Task OnGet(int IdeaId)
        {

            IdeaInvestments = await db.Investments
                                .Where(m => m.IdeaID == IdeaId)
                                .ToListAsync();

            //myIdeas = await db.Ideas
            //        .Include(m => m.Investments)
            //        .ThenInclude(e => e.ApplicationUser)
            //        .AsNoTracking()
            //        .ToListAsync();

            myUsers = await userManager.Users.ToListAsync();

            myUser = await GetCurrentUserAsync();
            var userId = myUser?.Id;

            thisUser = await userManager.FindByIdAsync(userId);

            Idea = db.Ideas
                .Include(m => m.Investments)
                    .FirstOrDefault(f => f.IdeaId == IdeaId);


        }

        public async Task<IActionResult> OnPost(int IdeaId)
        {
            if (!ModelState.IsValid)
            {
               
                Investment.IdeaID = Idea.IdeaId;
                Investment.CommitedToInvestment = "NO";
                //Investment.InvestorName = thisUser.FirstName;
                //Investment.InvestorSurname = thisUser.Surname;
                //Investment.InvestorEmail = "tbvukurusi@gmail.com";


                db.Investments.Add(Investment);
                await db.SaveChangesAsync();
                TempData["message"] = "InvestSuccess";
                return RedirectToPage("/Platform/IdeaProfile", new {IdeaId});
            }
            else
            {
                return RedirectToPage("/Index");
            }
        }

        public async Task<IActionResult> OnPostAdjustInvestments(int IdeaId)
        {
            //if (await TryUpdateModelAsync<Investments>(
            //    IdeaInvestments,
            //    "investments",
            //    s => s.CommitedToInvestment, s => s.LastName, s => s.EnrollmentDate))
            //{
            //    await _context.SaveChangesAsync();
            //    return RedirectToPage("./Index");
            //}


            db.Investments.UpdateRange(IdeaInvestments);
            await db.SaveChangesAsync();
            TempData["message"] = "AdjustInvestors";
            return RedirectToPage("/Platform/IdeaProfile", new { IdeaId });

        }
    }
}