<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;
using _07.MilitaryElite.Enumerations;
using _07.MilitaryElite.Interfaces;

namespace _07.MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id,
            string firstName,
            string lastName,
            decimal salary,
            SoldierCorpEnum corp,
            ICollection<IMission> missions)
            : base(id, firstName, lastName, salary, corp)
        {
            this.Missions = missions;
        }

        public ICollection<IMission> Missions { get; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.ToString()
                + "Missions:");

            foreach (var mission in this.Missions)
            {
                stringBuilder.AppendLine($"  {mission}");
            }

            return stringBuilder
                .ToString()
                .TrimEnd();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;
using _07.MilitaryElite.Enumerations;
using _07.MilitaryElite.Interfaces;

namespace _07.MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id,
            string firstName,
            string lastName,
            decimal salary,
            SoldierCorpEnum corp,
            ICollection<IMission> missions)
            : base(id, firstName, lastName, salary, corp)
        {
            this.Missions = missions;
        }

        public ICollection<IMission> Missions { get; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.ToString()
                + "Missions:");

            foreach (var mission in this.Missions)
            {
                stringBuilder.AppendLine($"  {mission}");
            }

            return stringBuilder
                .ToString()
                .TrimEnd();
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
