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
    public class ideasModel : PageModel
    {
        private readonly ApplicationDbContext db;

        public ideasModel(ApplicationDbContext db)
        {
            this.db = db;
        }

        [BindProperty]
        public IList<Ideas> Ideas { get; set; }

        public string CurrentFilter { get; set; }

        public string CapitalFilter { get; set; }

        public async Task OnGet(string searchString, string CapitalSearch)
        {
            CurrentFilter = searchString;
            IQueryable<Ideas> SearchIdeas = from s in db.Ideas
                                            orderby s.IdeaId
                                            select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                SearchIdeas = SearchIdeas.Where(s => s.IdeaName.Contains(searchString) || s.IdeaOwner.Contains(searchString) || s.IdeaCriteria.Contains(searchString));
            }


            CapitalFilter = CapitalSearch;
            if (!String.IsNullOrEmpty(CapitalSearch))
            {
                SearchIdeas = SearchIdeas.Where(s => s.ideaGrade.Contains(CapitalSearch));
            }


            Ideas =  await SearchIdeas
                .AsNoTracking()
                .ToListAsync();

            //int pageSize = 3;
            //int pageNumber = (page ?? 1);

        }

        //public async Task OnPostSearch(string searchString)
        //{
        //    if (!string.IsNullOrEmpty(searchString))
        //    {

        //        Ideas = await db.Ideas.Where(i => i.IdeaName == searchString);
        //    }
        //}
    }
}