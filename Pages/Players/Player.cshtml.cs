using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using League.Data;
using League.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace League.Pages.Players
{
    public class PlayerModel : PageModel
    {
        private readonly LeagueContext _context;

        public Player CurrentPlayer { get; set; }

        public PlayerModel(LeagueContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return NotFound("PlayerId is null or empty.");
            }

            CurrentPlayer = await _context.Players
                            .Include(p => p.Team)            
                            .FirstOrDefaultAsync(p => p.PlayerId == id);

            if (CurrentPlayer == null)
            {
                return NotFound($"No player found with ID: {id}");
            }

            return Page();
        }
    }
}