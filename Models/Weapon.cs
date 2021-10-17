using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_Heroes.WebAPI.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Hero OwnerHero { get; set; }
        public int OwnerHeroId { get; set; }

    }
}
