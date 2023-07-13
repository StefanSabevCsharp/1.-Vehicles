using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public class Rogue : BaseHero
    {
        const int currentPower = 80;
        public Rogue(string name)
            : base(name, currentPower)
        {
     
        }
        public override string CastAbility()
        {
            return $"{base.CastAbility()} hit for {currentPower} damage";
        }
    }
}
