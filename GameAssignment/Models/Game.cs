using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameAssignment.Models
{
    public class Game
    {
        public int GameID { get; set; }
        public string Title { get; set; }
        public int MaximumPlayers { get; set; }
        public int ReleaseYear { get; set; }
    }
}
