using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GameAssignment.Data;
using GameAssignment.Models;

namespace GameAssignment.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly GameAssignment.Data.GameDbContext _context;

        public IndexModel(GameAssignment.Data.GameDbContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; }

        public async Task OnGetAsync()
        {
            Game = await _context.Game.ToListAsync();
        }
    }
}
