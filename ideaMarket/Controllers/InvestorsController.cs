using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ideaMarket.Data;
using ideaMarket.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ideaMarket.Controllers
{
    public class InvestorsController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public InvestorsController(ApplicationDbContext db, UserManager<ApplicationUser> userManager,
                SignInManager<ApplicationUser> signInManager,
                RoleManager<IdentityRole> roleManager)
        {
            this.db = db;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Investors()
        {

            List<InvestorViewModel> myUsers = new List<InvestorViewModel>();
            var myInvestors = await userManager.GetUsersInRoleAsync("Investor");
            foreach (var myInvestor in myInvestors)
            {
                myUsers.Add(new InvestorViewModel {Id = myInvestor.Id, Username = myInvestor.Email, FirstName = myInvestor.FirstName, Surname = myInvestor.Surname, PhoneNumber = myInvestor.PhoneNumber, Email = myInvestor.Email, Address = myInvestor.Address, ProfilePicture = myInvestor.ProfilePicture });
            }
            return View(myUsers);
        }

        [HttpGet]
        public async Task<IActionResult> PortfolioInvestors()
        {

            List<InvestorViewModel> myUsers = new List<InvestorViewModel>();
            var myInvestors = await userManager.GetUsersInRoleAsync("Investor");
            foreach (var myInvestor in myInvestors)
            {
                myUsers.Add(new InvestorViewModel { Id = myInvestor.Id, Username = myInvestor.Email, FirstName = myInvestor.FirstName, Surname = myInvestor.Surname, PhoneNumber = myInvestor.PhoneNumber, Email = myInvestor.Email, Address = myInvestor.Address, ProfilePicture = myInvestor.ProfilePicture });
            }
            return View(myUsers);
        }
    }
}