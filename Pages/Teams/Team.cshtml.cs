using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using League.Data;
using League.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace League.Pages.Teams
{
    public class TeamModel : PageModel
    {
        private readonly LeagueContext _context;

        public Team CurrentTeam { get; set; }

        public IList<Player> PlayerList { get; set; }

        public TeamModel(LeagueContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound("TeamId is null or empty.");
            }

            CurrentTeam = await _context.Teams.FindAsync(id);

            if (CurrentTeam == null)
            {
                return NotFound($"No team found with ID: {id}");
            }

            PlayerList = await _context.Players
                .Where(p => p.TeamId == id)
                .ToListAsync();

            return Page();
        }
    }
}