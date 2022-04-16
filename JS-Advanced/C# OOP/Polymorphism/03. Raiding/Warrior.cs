<<<<<<< HEAD
﻿namespace Raiding
{
    public class Warrior : BaseHero
    {
        private const int power = 100;
        public Warrior(string name)
            : base(name, power)
        {
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage";
        }
    }
}
=======
﻿namespace Raiding
{
    public class Warrior : BaseHero
    {
        private const int power = 100;
        public Warrior(string name)
            : base(name, power)
        {
        }

        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage";
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
