using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        List<Ski> data;

        public SkiRental(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Ski>();
        }
        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => data.Count;
        public void Add(Ski ski)
        {
            if (Capacity > Count)
            {
                data.Add(ski);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            if (data.Exists(d => d.Manufacturer == manufacturer && d.Model == model))
            {
                data.Remove(data.FirstOrDefault(d => d.Manufacturer == manufacturer && d.Model == model));
                return true;
            }
            return false;
        }

        public Ski GetNewestSki()
        {
            if (data.Count > 0)
            {
                return data.OrderByDescending(y => y.Year).FirstOrDefault();
            }
            return null;
        }

        public Ski GetSki(string manufacturer, string model)
        {
            if (data.Exists(d => d.Manufacturer == manufacturer && d.Model == model))
            {
                Ski currentSki = data.FirstOrDefault(d => d.Manufacturer == manufacturer && d.Model == model);
                return currentSki;
            }
            return null;
        }

        public string GetStatistics()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"The skis stored in {Name}:");

            foreach (Ski ski in data)
            {
                stringBuilder.AppendLine($"{ski.Manufacturer} - {ski.Model} - {ski.Year}");
            }
            return stringBuilder.ToString().TrimEnd();
        }
    }
}
