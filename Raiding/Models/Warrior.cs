using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public class Warrior : BaseHero
    {
        const int currentPower = 100;
        public Warrior(string name)
            : base(name, currentPower)
        {
        }
        public override string CastAbility()
        {
            return $"{base.CastAbility()} hit for {currentPower} damage";
        }
    }
    
}
