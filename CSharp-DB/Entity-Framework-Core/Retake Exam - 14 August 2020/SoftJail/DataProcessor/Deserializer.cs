namespace SoftJail.DataProcessor
{

    using Data;
    using Newtonsoft.Json;
    using SoftJail.Data.Models;
    using SoftJail.Data.Models.Enums;
    using SoftJail.DataProcessor.ImportDto;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class Deserializer
    {
        public static string ImportDepartmentsCells(SoftJailDbContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();

            var validDepartments = new List<Department>();

            var departmentsCells = JsonConvert
                .DeserializeObject<IEnumerable<DepartmentCellInputModel>>(jsonString);

            foreach (var departmentCell in departmentsCells)
            {
                if (!IsValid(departmentCell) ||
                    !departmentCell.Cells.All(IsValid) ||
                    departmentCell.Cells.Count == 0)
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                /*foreach (var cell in departmentCell.Cells)
                {
                    if (!IsValid(cell))
                    {
                        sb.AppendLine("Invalid Data");
                    }
                }*/

                var department = new Department //-> entity model
                {
                    Name = departmentCell.Name,
                    Cells = departmentCell.Cells.Select(x => new Cell
                    {
                        CellNumber = x.CellNumber,
                        HasWindow = x.HasWindow
                    })
                    .ToList()
                };

                validDepartments.Add(department);

                sb.AppendLine($"Imported {department.Name} with {department.Cells.Count} cells");
            }
            context.Departments.AddRange(validDepartments);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportPrisonersMails(SoftJailDbContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();

            var validPrisoners = new List<Prisoner>();

            var prisonerMails =
                  JsonConvert.DeserializeObject<IEnumerable<PrisonerMailInputModel>>(jsonString);

            foreach (var cuurentPrisoner in prisonerMails)
            {
                if (!IsValid(cuurentPrisoner) ||
                   !cuurentPrisoner.Mails.All(IsValid))
                {
                    sb.AppendLine("Invalid Data");
                    continue;
                }

                //bc ReleaseDate can be null
                var isValidReleaseDate = DateTime.TryParseExact(
                    cuurentPrisoner.ReleaseDate,
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime releaseDate);


                var incarcerationDate = DateTime.ParseExact(cuurentPrisoner.IncarcerationDate,
                      "dd/MM/yyyy", CultureInfo.InvariantCulture);

                var prisoner = new Prisoner
                {
                    FullName = cuurentPrisoner.FullName,
                    Nickname = cuurentPrisoner.Nickname,
                    Age = cuurentPrisoner.Age,
                    Bail = cuurentPrisoner.Bail,
                    CellId = cuurentPrisoner.CellId,
                    ReleaseDate = isValidReleaseDate ? (DateTime?)releaseDate : null,
                    IncarcerationDate = incarcerationDate,
                    Mails = cuurentPrisoner.Mails.Select(m => new Mail
                    {
                        Sender = m.Sender,
                        Address = m.Address,
                        Description = m.Description
                    })
                    .ToList()
                };
                validPrisoners.Add(prisoner);

                sb.AppendLine($"Imported {prisoner.FullName} {prisoner.Age} years old");
            }
            context.Prisoners.AddRange(validPrisoners);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportOfficersPrisoners(SoftJailDbContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();

            var validOfficers = new List<Officer>();

            var officersPrisoners =
                XmlConverter.Deserializer<OfiicerPrisonerInputModel>(xmlString, "Officers");

            foreach (var officerPrisoner in officersPrisoners)
            {
                if (!IsValid(officerPrisoner))
                {
                    sb.AppendLine($"Invalid Data");
                    continue;
                }

                var officer = new Officer
                {
                    FullName = officerPrisoner.Name,
                    Salary = officerPrisoner.Money,
                    DepartmentId = officerPrisoner.DepartmentId,
                    Position = Enum.Parse<Position>(officerPrisoner.Position),
                    Weapon = Enum.Parse<Weapon>(officerPrisoner.Weapon),
                    OfficerPrisoners = officerPrisoner.Prisoners.Select(x => new OfficerPrisoner
                    {
                        PrisonerId = x.Id
                    })
                    .ToList()
                };

                validOfficers.Add(officer);

                sb.AppendLine($"Imported {officer.FullName} ({officer.OfficerPrisoners.Count} prisoners)");
            }

            context.Officers.AddRange(validOfficers);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        private static bool IsValid(object obj)
        {
            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
            var validationResult = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(obj, validationContext, validationResult, true);
            return isValid;
        }
    }
}