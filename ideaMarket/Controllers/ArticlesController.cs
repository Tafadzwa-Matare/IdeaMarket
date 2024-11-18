using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ideaMarket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ideaMarket.Controllers
{
    [Route("api/Articles")]
    [ApiController]//NewsandArticlesController is an API controller
    public class ArticlesController : Controller
    {
        private readonly ApplicationDbContext db;

        public ArticlesController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var Article = await db.Articles.FirstOrDefaultAsync(u => u.ArticleID == id);
            if (Article == null)
            {
                return Json(new { success = false, message = "Error While Deleting" });
            }
            db.Articles.Remove(Article);
            await db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete Successful" });

        }
    }
}