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
    public class NewsModel : PageModel
    {
        private readonly ApplicationDbContext db;

        public NewsModel(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IList<News>  News { get; set; }

        public async Task OnGet()
        {
            News = await db.News
                .OrderByDescending(m => m.NewsID)
                .ToListAsync();
        }
    }
}