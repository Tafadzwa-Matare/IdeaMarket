using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ideaMarket.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ideaMarket.Pages.Platform
{
    public class UserPublicProfileModel : PageModel
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> userManager;

        public UserPublicProfileModel(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            this.db = db;
            this.userManager = userManager;
        }

        [BindProperty]
        public ApplicationUser myUser { get; set; }


        public async Task OnGet(string userId)
        {
            myUser = await userManager.FindByIdAsync(userId);

        }
    }
}