using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreetRacing
{
    public class Race
    {
        List<Car> Participants;

        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            Name = name;
            Type = type;
            Laps = laps;
            Capacity = capacity;
            MaxHorsePower = maxHorsePower;
            Participants = new List<Car>();
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Laps { get; set; }
        public int Capacity { get; set; }
        public int MaxHorsePower { get; set; }

        public int Count => Participants.Count;

        public void Add(Car car)
        {
            if (!(Participants.Exists(x => x.LicensePlate == car.LicensePlate))
                && Count <= Capacity
                && car.HorsePower <= MaxHorsePower)
            {
                Participants.Add(car);
            }
        }

        public bool Remove(string licensePlate)
        {
            if (Participants.Exists(x => x.LicensePlate == licensePlate))
            {
                Participants
                    .Remove(Participants
                    .FirstOrDefault(x => x.LicensePlate == licensePlate));

                return true;
            }

            return false;
        }

        public Car FindParticipant(string licensePlate)
        {
            if (Participants.Exists(x => x.LicensePlate == licensePlate))
            {
                return Participants
                    .FirstOrDefault(x => x.LicensePlate == licensePlate);
            }
            return null;
        }

        public Car GetMostPowerfulCar()
        {
            if (Participants.Count > 0)
            {
                return Participants
              .OrderByDescending(x => x.HorsePower)
              .FirstOrDefault();
            }
            return null;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Race: {Name} - Type: {Type} (Laps: {Laps})");

            foreach (var car in Participants)
            {
                sb.AppendLine(car.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
