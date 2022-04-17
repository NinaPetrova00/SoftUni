using CarRacing.Models.Maps.Contracts;
using CarRacing.Models.Racers.Contracts;
using CarRacing.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Maps
{
    public class Map : IMap
    {
        public string StartRace(IRacer racerOne, IRacer racerTwo)
        {
            double racingBehMulRacerOne = default;
            if (racerOne.RacingBehavior == "strict")
            {
                racingBehMulRacerOne = 1.2;
            }
            else if (racerOne.RacingBehavior == "aggressive")
            {
                racingBehMulRacerOne = 1.1;
            }

            double racingBehMulRacerTwo = default;
            if (racerTwo.RacingBehavior == "strict")
            {
                racingBehMulRacerTwo = 1.2;
            }
            else if (racerTwo.RacingBehavior == "aggressive")
            {
                racingBehMulRacerTwo = 1.1;
            }

            double chanceOfWinningRacerOne = racerOne.Car.HorsePower * racerOne.DrivingExperience * racingBehMulRacerOne;

            double chanceOfWinningRaceTwo = racerTwo.Car.HorsePower * racerTwo.DrivingExperience * racingBehMulRacerTwo;

            if (chanceOfWinningRacerOne > chanceOfWinningRaceTwo)
            {
                return string
                    .Format(OutputMessages.RacerWinsRace, racerOne.Username, racerTwo.Username, racerOne.Username);

            }
            else if (chanceOfWinningRacerOne < chanceOfWinningRaceTwo)
            {
                return string
                    .Format(OutputMessages.RacerWinsRace, racerOne.Username, racerTwo.Username, racerTwo.Username);
            }
            else if (racerOne.IsAvailable() == false)
            {
                return string
                    .Format(OutputMessages.OneRacerIsNotAvailable, racerTwo, racerOne);
            }
            else if (racerTwo.IsAvailable() == false)
            {
                return string
                    .Format(OutputMessages.OneRacerIsNotAvailable, racerOne, racerTwo);
            }
            else /*if (racerOne.IsAvailable() == false && racerTwo.IsAvailable() == false)*/
            {
                return string
                    .Format(OutputMessages.RaceCannotBeCompleted);
            }


        }
    }
}
