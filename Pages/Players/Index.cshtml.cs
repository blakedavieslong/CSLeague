using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using League.Data;
using League.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace League.Pages.Players
{
    public class IndexModel : PageModel
    {
        private readonly LeagueContext _context;

        public IList<Player> PlayerList { get; set; }

        public SelectList Teams { get; set; }

        public SelectList Positions { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SelectedTeam { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SelectedPosition { get; set; }

        public string SelectedFav { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchName { get; set; }

        [BindProperty(SupportsGet = true)]
        public string OrderBy { get; set; } = "Name";

        public IndexModel(LeagueContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            IQueryable<string> teamQuery = from t in _context.Teams
                                           orderby t.Name
                                           select t.Name;

            Teams = new SelectList(await teamQuery.ToListAsync());

            IQueryable<string> positionQuery = from p in _context.Players
                                           orderby p.Position
                                           select p.Position;

            Positions = new SelectList(await positionQuery.Distinct().ToListAsync());

            SelectedFav = Request.Cookies["SelectedFavourite"];


            var players = from p in _context.Players
                          .Include(p => p.Team)
                          select p;

            if (!string.IsNullOrEmpty(SelectedTeam))
            {
                players = players.Where(p => p.Team.Name == SelectedTeam);
            }

            if (!string.IsNullOrEmpty(SelectedPosition))
            {
                players = players.Where(p => p.Position == SelectedPosition);
            }

            if (!string.IsNullOrEmpty(SearchName))
            {
                players = players.Where(p => p.Name.Contains(SearchName));
            }

            switch (OrderBy)
            {
                case "Depth":
                    players = players.OrderBy(p => p.Depth);
                    break;
                case "Name":
                    players = players.OrderBy(p => p.Name);
                    break;
                case "Team":
                    players = players.OrderBy(p => p.Team.Name);
                    break;
            }

            PlayerList = await players.ToListAsync();
        }
    }
}