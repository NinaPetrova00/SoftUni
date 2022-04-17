using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
      List<Pet> data;

        public Clinic(int capacity)
        {
            Capacity = capacity;
            data = new List<Pet>();
        }

        public int Capacity { get; set; }

        public int Count => data.Count;
        public void Add(Pet pet)
        {
            if (Capacity > Count)
            {
                data.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            if (data.Exists(x => x.Name == name))
            {
                data.Remove(data.First(x => x.Name == name));
                return true;
            }
            return false;
        }

        public Pet GetPet(string name, string owner)
        {
            if (data.Exists(x => x.Name == name && x.Owner == owner))
            {
                return data.FirstOrDefault(x => x.Name == name && x.Owner == owner);
            }
            return null;
        }

        public Pet GetOldestPet()
        {
            return data.OrderByDescending(x => x.Age).FirstOrDefault();
        }

        public string GetStatistics()
        {
            /* "The clinic has the following patients:
               Pet {Name} with owner: {Owner}
               Pet {Name} with owner: {Owner}
               (…)"  */

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("The clinic has the following patients:");
            foreach (var animal in data)
            {
                sb.AppendLine($"Pet {animal.Name} with owner: {animal.Owner}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
