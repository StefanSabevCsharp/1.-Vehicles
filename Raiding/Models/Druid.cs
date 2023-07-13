using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public class Druid : BaseHero
    {
        const int currentPower = 80;
        public Druid(string name) 
            : base(name, currentPower)
        {

        }
        public override string CastAbility()
        {
            return $"{base.CastAbility()} healed for {currentPower}";
        }
    }
}
