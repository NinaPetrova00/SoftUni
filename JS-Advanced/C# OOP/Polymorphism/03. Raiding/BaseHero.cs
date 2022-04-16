<<<<<<< HEAD
﻿namespace Raiding
{
    public abstract class BaseHero
    {
        public BaseHero(string name,int power)
        {
            this.Name = name;
            this.Power = power;
        }
        public string Name { get; }

        public int Power { get; }

        public abstract string CastAbility();
    }
}
=======
﻿namespace Raiding
{
    public abstract class BaseHero
    {
        public BaseHero(string name,int power)
        {
            this.Name = name;
            this.Power = power;
        }
        public string Name { get; }

        public int Power { get; }

        public abstract string CastAbility();
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
