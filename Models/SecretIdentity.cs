using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_Heroes.WebAPI.Models
{
    public class SecretIdentity
    {
        public int Id { get; set; }
        public string Civil_Name { get; set; }
        public int HeroId { get; set; }
        public Hero Hero { get; set; }
    }
}
