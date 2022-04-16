<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<BaseHero> baseHeroes = new List<BaseHero>();

            while (baseHeroes.Count != n)
            {
                try
                {
                    string name = Console.ReadLine();
                    string heroType = Console.ReadLine();

                    if (heroType == "Paladin")
                    {
                        baseHeroes.Add(new Paladin(name));
                    }
                    else if (heroType == "Druid")
                    {
                        baseHeroes.Add(new Druid(name));
                    }
                    else if (heroType == "Warrior")
                    {
                        baseHeroes.Add(new Warrior(name));
                    }
                    else if (heroType == "Rogue")
                    {
                        baseHeroes.Add(new Rogue(name));
                    }
                    else
                    {
                        throw new ArgumentException("Invalid hero!");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            int bossPower = int.Parse(Console.ReadLine());

            foreach (var bashero in baseHeroes)
            {
                Console.WriteLine(bashero.CastAbility());
            }

            int baseHeroesPower = baseHeroes.Sum(x => x.Power);

            if (baseHeroesPower >= bossPower)
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
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<BaseHero> baseHeroes = new List<BaseHero>();

            while (baseHeroes.Count != n)
            {
                try
                {
                    string name = Console.ReadLine();
                    string heroType = Console.ReadLine();

                    if (heroType == "Paladin")
                    {
                        baseHeroes.Add(new Paladin(name));
                    }
                    else if (heroType == "Druid")
                    {
                        baseHeroes.Add(new Druid(name));
                    }
                    else if (heroType == "Warrior")
                    {
                        baseHeroes.Add(new Warrior(name));
                    }
                    else if (heroType == "Rogue")
                    {
                        baseHeroes.Add(new Rogue(name));
                    }
                    else
                    {
                        throw new ArgumentException("Invalid hero!");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            int bossPower = int.Parse(Console.ReadLine());

            foreach (var bashero in baseHeroes)
            {
                Console.WriteLine(bashero.CastAbility());
            }

            int baseHeroesPower = baseHeroes.Sum(x => x.Power);

            if (baseHeroesPower >= bossPower)
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
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
