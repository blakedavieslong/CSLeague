using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using League.Data;
using League.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace League.Pages.Teams
{
    public class IndexModel : PageModel
    {
        private readonly LeagueContext _context;

        public IList<Team> TeamList { get; set; }

        public SelectList Teams { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SelectedFav { get; set; }

        public IndexModel(LeagueContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            if (string.IsNullOrEmpty(SelectedFav))
            {
                SelectedFav = Request.Cookies["SelectedFavourite"];
            } 
            else if (SelectedFav == "None")
            {
                Response.Cookies.Delete("SelectedFavourite");
            }
            else
            {
                Response.Cookies.Append("SelectedFavourite", SelectedFav, new Microsoft.AspNetCore.Http.CookieOptions { Expires = DateTimeOffset.UtcNow.AddDays(364) });
            }


            IQueryable<string> teamQuery = from t in _context.Teams
                                            orderby t.Name
                                            select t.Name;

            Teams = new SelectList(await teamQuery.ToListAsync());

            TeamList = await _context.Teams
                .Include(t => t.Division)
                .ThenInclude(d => d.Conference)
                .OrderBy(t => (t.Win == 0 && t.Loss == 0 ? 0 : (double)t.Win / t.Win + t.Loss + t.Tie))
                .ThenBy(t => t.Win)
                .ToListAsync();
        }
    }
}