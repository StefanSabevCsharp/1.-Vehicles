using Raiding.Engine.Interfaces;
using Raiding.Factories;
using Raiding.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Engine
{
    public class Engine : IEngine
    {
        public void Run()
        {
            int n = int.Parse(Console.ReadLine());
            List<IHero> heroes = new List<IHero>();

           while (heroes.Count < n)
            {

                string name = Console.ReadLine();
                string type = Console.ReadLine();
                try
                {
                    IHero hero = HeroFactoryCreator.CreateHero(type, name);
                    if (hero == null)
                    {
                        throw new ArgumentException("Invalid hero!");
                    }
                    else
                    {

                        heroes.Add(hero);
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            int bossPower = int.Parse(Console.ReadLine());
            int totalPower = heroes.Sum(h => h.Power);

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());

            }
            if (totalPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
