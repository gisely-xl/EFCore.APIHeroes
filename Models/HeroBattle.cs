using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_Heroes.WebAPI.Models
{
    public class HeroBattle
    {
        public int HeroId { get; set; }
        public Hero Hero { get; set; }
        public int BattleId { get; set; }
        public Battle Battle { get; set; }
    }
}
