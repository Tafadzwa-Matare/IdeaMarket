using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ideaMarket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ideaMarket.Controllers
{
    [Route("api/NewsandArticles")]
    [ApiController]//NewsandArticlesController is an API controller
    public class NewsandArticlesController : Controller
    {
        private readonly ApplicationDbContext db;

        public NewsandArticlesController(ApplicationDbContext db)
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
            var News = await db.News.FirstOrDefaultAsync(u => u.NewsID == id);
            if (News == null)
            {
                return Json(new { success = false, message = "Error While Deleting" });
            }
            db.News.Remove(News);
            await db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete Successful" });

        }
    }
}