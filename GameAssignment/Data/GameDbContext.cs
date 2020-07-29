using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GameAssignment.Models;

namespace GameAssignment.Data
{
    public class GameDbContext : DbContext
    {
        public GameDbContext (DbContextOptions<GameDbContext> options)
            : base(options)
        {
        }

        public DbSet<GameAssignment.Models.Game> Game { get; set; }
    }
}
