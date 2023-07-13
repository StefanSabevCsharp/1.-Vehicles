using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public class Paladin : BaseHero
    {
        const int currentPower = 100;
        public Paladin(string name) 
            : base(name, currentPower)
        {
        }
        public override string CastAbility()
        {
            return $"{base.CastAbility()} healed for {currentPower}";
        }
    }
}
