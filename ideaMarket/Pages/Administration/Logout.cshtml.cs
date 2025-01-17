﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ideaMarket.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ideaMarket.Pages.Administration
{
    public class LogoutModel : PageModel
    {
         private readonly SignInManager<ApplicationUser> _signInManager;
            private readonly ILogger _logger;
            public LogoutModel(SignInManager<ApplicationUser> signInManager, ILogger<LogoutModel> logger)
            {
                _signInManager = signInManager;
                _logger = logger;
            }
            public async Task<IActionResult> OnPost()
            {
                await _signInManager.SignOutAsync();
                _logger.LogInformation("User logged out.");
                return RedirectToPage("/Index");
            }
        
    }
}