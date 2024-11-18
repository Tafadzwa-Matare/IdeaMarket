using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ideaMarket.Data;
using ideaMarket.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ideaMarket.Pages.Platform
{
    public class PortfolioTopIdeasModel : PageModel
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IWebHostEnvironment webHostEnvironment;

        public PortfolioTopIdeasModel(ApplicationDbContext db, UserManager<ApplicationUser> userManager,
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
        public IList<Ideas> Ideas { get; set; }

        public async Task OnGet()
        {
            Ideas = await db.Ideas
                .Include(s => s.Investments)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}