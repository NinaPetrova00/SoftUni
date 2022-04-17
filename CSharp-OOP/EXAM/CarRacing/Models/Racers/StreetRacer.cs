using CarRacing.Models.Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Racers
{
    public class StreetRacer : Racer
    {
        private const string RacingBehavior = "aggressive";
        private const int DrivingExperienceConst = 10;
        public StreetRacer(string username, ICar car)
            : base(username, RacingBehavior, DrivingExperienceConst, car)
        {
        }

        public override void Race()
        {
            this.DrivingExperience += 5;
        }
    }
}
