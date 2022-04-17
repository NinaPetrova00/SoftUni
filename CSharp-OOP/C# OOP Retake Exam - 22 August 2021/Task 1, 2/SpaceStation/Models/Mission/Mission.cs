using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission.Contracts;
using SpaceStation.Models.Planets.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Mission
{
    public class Mission : IMission
    {
        public void Explore(IPlanet planet, ICollection<IAstronaut> astronauts)
        {
            foreach (IAstronaut astronaut in astronauts)
            {
                if (astronaut.Oxygen < 0)
                {
                    //can't go
                    break;
                }

                foreach (string planetItem in planet.Items)
                {
                    if (astronaut.Oxygen < 0)
                    {
                        //can't go
                        break;
                    }
                    astronaut.Breath();
                    astronaut.Bag.Items.Add(planetItem);
                    planet.Items.Remove(planetItem);

                    if (astronaut.Oxygen == 0)
                    {

                    }
                }
            }
        }
    }
}
