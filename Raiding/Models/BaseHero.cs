using Raiding.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models
{
    public abstract class BaseHero : IHero
    {
        string name;
        public BaseHero(string name, int power)
        {
            Name = name;
            Power = power;
        }

        public string Name
        { 
            get => name;
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace!");
                }
                name = value;
            }
        }
        public int Power { get; private set; }

        public virtual string CastAbility()
        {
           return $"{this.GetType().Name} - {Name}";
        }
    }
}
