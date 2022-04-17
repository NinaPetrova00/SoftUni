
namespace Artillery.DataProcessor
{
    using Artillery.Data;
    using Artillery.Data.Models.Enums;
    using Newtonsoft.Json;
    using System;
    using System.Linq;

    public class Serializer
    {
        public static string ExportShells(ArtilleryContext context, double shellWeight)
        {
            var result = context.Shells
                .Where(x => x.ShellWeight > shellWeight)
                .Select(x => new
                {
                    ShellWeight = x.ShellWeight,
                    Caliber = x.Caliber,
                    Guns = x.Guns.Where(x => x.GunType == (GunType)3 && x.Range>3000).Select(g => new
                    {
                        GunType = g.GunType,
                        GunWeight = g.GunWeight,
                        BarrelLength = g.BarrelLength,
                        Range = g.Range
                    })
                    .OrderByDescending(g => g.GunWeight)
                    .ToList()
                }).OrderBy(x => x.ShellWeight)
                .ToList();

            string jsonResut =
                JsonConvert.SerializeObject(result, Formatting.Indented);

            return jsonResut;
        }

        public static string ExportGuns(ArtilleryContext context, string manufacturer)
        {
            var result = context.Guns
                 .Where(x => x.Manufacturer.ManufacturerName == manufacturer)
                 .Select(x => new
                 {
                     Manufacturer = x.Manufacturer,
                     GunType = x.GunType,
                     BarrelLength = x.BarrelLength,
                     GunWeight = x.GunWeight,
                     Range = x.Range,
                     Countries = x.CountriesGuns.Where(x => x.Country.ArmySize > 4500000)
                     .Select(c => new
                     {
                         CountryName = c.CountryId,
                         ArmySize = c.


                     })
                 });

            return "TODO";
        }
    }
}
