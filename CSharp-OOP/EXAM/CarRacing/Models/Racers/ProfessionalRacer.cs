using CarRacing.Models.Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Racers
{
    public class ProfessionalRacer : Racer
    {
        private const string RacingBehavior = "strict";
        private const int DrivingExperienceConst = 30;
        public ProfessionalRacer(string username, ICar car)
            : base(username, RacingBehavior, DrivingExperienceConst, car)
        {
            this.DrivingExperience = DrivingExperienceConst;
        }

        public override void Race()
        {
            this.DrivingExperience += 10;
        }
    }
}
