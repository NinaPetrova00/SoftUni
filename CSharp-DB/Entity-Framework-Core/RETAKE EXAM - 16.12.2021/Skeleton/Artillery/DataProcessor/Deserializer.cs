namespace Artillery.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Artillery.Data;
    using Artillery.Data.Models;
    using Artillery.Data.Models.Enums;
    using Artillery.DataProcessor.ImportDto;
    using Newtonsoft.Json;

    public class Deserializer
    {
        private const string ErrorMessage =
                "Invalid data.";
        private const string SuccessfulImportCountry =
            "Successfully import {0} with {1} army personnel.";
        private const string SuccessfulImportManufacturer =
            "Successfully import manufacturer {0} founded in {1}.";
        private const string SuccessfulImportShell =
            "Successfully import shell caliber #{0} weight {1} kg.";
        private const string SuccessfulImportGun =
            "Successfully import gun {0} with a total weight of {1} kg. and barrel length of {2} m.";

        public static string ImportCountries(ArtilleryContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();

            XmlRootAttribute root = new XmlRootAttribute("Countries");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(CountriesImportDto[]), root);
            StringReader stringReader = new StringReader(xmlString);

            var contriesDto = (CountriesImportDto[])xmlSerializer.Deserialize(stringReader);

            foreach (var xmlCountry in contriesDto)
            {
                if (!IsValid(xmlCountry))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var country = new Country
                {
                    CountryName = xmlCountry.CountryName,
                    ArmySize = xmlCountry.ArmySize
                };

                context.Countries.Add(country);
                sb.AppendLine(String.Format(SuccessfulImportCountry, country.CountryName, country.ArmySize));
            }
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        public static string ImportManufacturers(ArtilleryContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();

            XmlRootAttribute root = new XmlRootAttribute("Manufacturers");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ManufacturerImportDto[]), root);
            StringReader stringReader = new StringReader(xmlString);

            var manufacturersDto = (ManufacturerImportDto[])xmlSerializer.Deserialize(stringReader);

            foreach (var xmlManufacturer in manufacturersDto)
            {
                if (!IsValid(xmlManufacturer))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                //foreach (var manName in xmlManufacturer.ManufacturerName.Distinct())
                //{
                //    var name = context.Manufacturers.Find(manName);

                //    if(name == null)
                //    {
                //        sb.AppendLine(ErrorMessage);
                //        continue;
                //    }

                //}
                var manufacturer = new Manufacturer
                {
                    ManufacturerName = xmlManufacturer.ManufacturerName,
                    Founded = xmlManufacturer.Founded
                };


                context.Manufacturers.Add(manufacturer);
                sb.AppendLine(string.Format(SuccessfulImportManufacturer, manufacturer.ManufacturerName, manufacturer.Founded));
            }
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        public static string ImportShells(ArtilleryContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();

            XmlRootAttribute root = new XmlRootAttribute("Shells");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ShellImportDto[]), root);
            StringReader stringReader = new StringReader(xmlString);

            var shellDto = (ShellImportDto[])xmlSerializer.Deserialize(stringReader);

            foreach (var xmlShell in shellDto)
            {
                if (!IsValid(xmlShell))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var shell = new Shell
                {
                    ShellWeight = xmlShell.ShellWeight,
                    Caliber = xmlShell.Caliber
                };

                context.Shells.Add(shell);
                sb.AppendLine(String.Format(SuccessfulImportShell, shell.Caliber, shell.ShellWeight));
            }
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        public static string ImportGuns(ArtilleryContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();

            var guns =
                JsonConvert.DeserializeObject<IEnumerable<GunsImportDto>>(jsonString);

            foreach (var jsonGun in guns)
            {
                if (!IsValid(jsonGun) || !jsonGun.Countries.All(IsValid))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var gun = new Gun
                {
                    ManufacturerId = jsonGun.ManufacturerId,
                    GunWeight = jsonGun.GunWeight,
                    BarrelLength = jsonGun.BarrelLength,
                    NumberBuild = jsonGun.NumberBuild,
                    Range = jsonGun.Range,
                    GunType = jsonGun.GunType.Value,
                    ShellId = jsonGun.ShellId,
                    Countries = jsonGun.Countries.Select(c => new CountryGun
                    {
                        CountryId = c.Id,
                    }).ToList()
                };

                context.Guns.Add(gun);
              
                sb.AppendLine(string.Format(SuccessfulImportGun, gun.GunType,
                    gun.GunWeight, gun.BarrelLength));
            }
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }
        private static bool IsValid(object obj)
        {
            var validator = new ValidationContext(obj);
            var validationRes = new List<ValidationResult>();

            var result = Validator.TryValidateObject(obj, validator, validationRes, true);
            return result;
        }
    }
}
