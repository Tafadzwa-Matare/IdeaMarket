using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ideaMarket.Data;
using ideaMarket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ideaMarket.Pages.Platform
{
    public class ArticlesModel : PageModel
    {

        private readonly ApplicationDbContext db;

        public ArticlesModel(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IList<Articles> Articles { get; set; }

        public async Task OnGet()
        {
            Articles = await db.Articles
                .OrderByDescending(m => m.ArticleID)
                .ToListAsync();
        }
    }
}