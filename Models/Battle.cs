using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_Heroes.WebAPI.Models
{
    public class Battle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Beginning { get; set; }
        public DateTime Ending { get; set; }
        public List<HeroBattle> BattlesHeroes { get; set; }

    }
}
