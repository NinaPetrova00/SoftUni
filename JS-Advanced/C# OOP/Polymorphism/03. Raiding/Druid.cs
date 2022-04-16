<<<<<<< HEAD
﻿namespace Raiding
{
    public class Druid : BaseHero
    {
        private const int power = 80;
        public Druid(string name)
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
    public class Druid : BaseHero
    {
        private const int power = 80;
        public Druid(string name)
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
