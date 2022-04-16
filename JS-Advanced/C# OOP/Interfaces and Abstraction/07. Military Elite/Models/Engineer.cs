<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;
using _07.MilitaryElite.Enumerations;
using _07.MilitaryElite.Interfaces;

namespace _07.MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(int id,
            string firstName, 
            string lastName, 
            decimal salary,
            SoldierCorpEnum corp,
            ICollection<IRepair> repairs) 
            : base(id, firstName, lastName, salary, corp)
        {
            this.Repairs = repairs;
        }

        public ICollection<IRepair> Repairs { get; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.ToString() + "Repairs:");

            foreach (var repair in this.Repairs)
            {
                stringBuilder.AppendLine($"  {repair}");
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
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(int id,
            string firstName, 
            string lastName, 
            decimal salary,
            SoldierCorpEnum corp,
            ICollection<IRepair> repairs) 
            : base(id, firstName, lastName, salary, corp)
        {
            this.Repairs = repairs;
        }

        public ICollection<IRepair> Repairs { get; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.ToString() + "Repairs:");

            foreach (var repair in this.Repairs)
            {
                stringBuilder.AppendLine($"  {repair}");
            }

            return stringBuilder
                .ToString()
                .TrimEnd();
        }
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
