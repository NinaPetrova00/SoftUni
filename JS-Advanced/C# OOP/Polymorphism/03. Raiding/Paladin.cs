<<<<<<< HEAD
﻿namespace Raiding
{
    public class Paladin : BaseHero
    {
        private const int power = 100;
        public Paladin(string name)
            : base(name, power)
        {
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} healed for {this.Power}";
        }
    }
}
=======
﻿namespace Raiding
{
    public class Paladin : BaseHero
    {
        private const int power = 100;
        public Paladin(string name)
            : base(name, power)
        {
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} healed for {this.Power}";
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
