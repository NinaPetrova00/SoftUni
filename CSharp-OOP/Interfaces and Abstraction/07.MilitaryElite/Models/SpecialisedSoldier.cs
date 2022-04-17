using System;
using System.Collections.Generic;
using System.Text;
using _07.MilitaryElite.Enumerations;
using _07.MilitaryElite.Interfaces;

namespace _07.MilitaryElite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        protected SpecialisedSoldier(int id, string firstName, string lastName, decimal salary,SoldierCorpEnum corp) 
            : base(id, firstName, lastName, salary)
        {
            this.Corp = corp;
        }

        public SoldierCorpEnum Corp { get; }
        public override string ToString()
        {
            return base.ToString()
                  + Environment.NewLine
                  + $"Corps: {this.Corp}"
                  + Environment.NewLine;
        }
    }
}
