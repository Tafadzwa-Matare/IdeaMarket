using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ideaMarket.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ideaMarket.Pages.Administration
{
    public class CreateRoleModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<CreateRoleModel> _logger;

        public CreateRoleModel(SignInManager<ApplicationUser> signInManager,
            ILogger<CreateRoleModel> logger,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            this.roleManager = roleManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        [BindProperty]
        public CreateRoleViewModel Create_Role { get; set; }

        public class CreateRoleViewModel
        {
            [Required]
            public string RoleName { get; set; }
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = Create_Role.RoleName

                };

                IdentityResult result = await roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    return RedirectToPage("/Platform/Portfolio");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return Page();
        }

    }
}