namespace Theatre.DataProcessor
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;
    using Theatre.Data;
    using Theatre.Data.Models;
    using Theatre.Data.Models.Enums;
    using Theatre.DataProcessor.ImportDto;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfulImportPlay
            = "Successfully imported {0} with genre {1} and a rating of {2}!";

        private const string SuccessfulImportActor
            = "Successfully imported actor {0} as a {1} character!";

        private const string SuccessfulImportTheatre
            = "Successfully imported theatre {0} with #{1} tickets!";

        public static string ImportPlays(TheatreContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();

            XmlRootAttribute xmlRoot = new XmlRootAttribute("Plays");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportPlaysDto[]), xmlRoot);

            using StringReader stringReader = new StringReader(xmlString);

            ImportPlaysDto[] playsDtos = (ImportPlaysDto[])xmlSerializer.Deserialize(stringReader);

            HashSet<Play> validPlays = new HashSet<Play>();

            foreach (ImportPlaysDto playDto in playsDtos)
            {
                if (!IsValid(playDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var isValidDuration = TimeSpan.TryParseExact(playDto.Duration, "c", CultureInfo.InvariantCulture, TimeSpanStyles.None, out TimeSpan validDuration);

                if (!isValidDuration)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if (validDuration.Hours < 1)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var isTypeValid = Enum.TryParse(typeof(Genre), playDto.Genre, out object validPlayType);

                if (!isTypeValid)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Play play = new Play()
                {
                    Title = playDto.Title,
                    Duration = validDuration,
                    Rating = playDto.Rating,
                    Genre = (Genre)validPlayType,
                    Description = playDto.Description,
                    Screenwriter = playDto.Screenwriter
                };

                validPlays.Add(play);
                sb.AppendLine(string.Format(SuccessfulImportPlay, play.Title, play.Genre, play.Rating));
            }
            context.Plays.AddRange(validPlays);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportCasts(TheatreContext context, string xmlString)
        {
            StringBuilder sb = new StringBuilder();

            XmlRootAttribute xmlRoot = new XmlRootAttribute("Casts");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportCastsDto[]), xmlRoot);

            using StringReader stringReader = new StringReader(xmlString);

            ImportCastsDto[] castsDtos = (ImportCastsDto[])xmlSerializer.Deserialize(stringReader);

            HashSet<Cast> validCasts = new HashSet<Cast>();
            foreach (ImportCastsDto castDto in castsDtos)
            {
                if (!IsValid(castDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Cast cast = new Cast()
                {
                    FullName = castDto.FullName,
                    IsMainCharacter = castDto.IsMainCharacter,
                    PhoneNumber = castDto.PhoneNumber,
                    PlayId = castDto.PlayId
                };

                validCasts.Add(cast);
                sb.AppendLine(string.Format(SuccessfulImportActor, cast.FullName, cast.IsMainCharacter));

            }
            context.Casts.AddRange(validCasts);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportTtheatersTickets(TheatreContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();

            ImportTtheatersDto[] theatersDtos =
                JsonConvert.DeserializeObject<ImportTtheatersDto[]>(jsonString);

            HashSet<Theatre> validTheatres = new HashSet<Theatre>();

            foreach (ImportTtheatersDto theaterDto in theatersDtos)
            {
                if (!IsValid(theaterDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                HashSet<Ticket> validTickets = new HashSet<Ticket>();
                foreach (var ticketDto in theaterDto.Tickets)
                {
                    if (!IsValid(ticketDto))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    Ticket ticket = new Ticket()
                    {
                        Price = ticketDto.Price,
                        RowNumber = ticketDto.RowNumber,
                        PlayId = ticketDto.PlayId
                    };
                    validTickets.Add(ticket);
                }

                Theatre theatre = new Theatre()
                {
                    Name = theaterDto.Name,
                    NumberOfHalls = theaterDto.NumberOfHalls,
                    Director = theaterDto.Director,
                    Tickets = validTickets
                };

                validTheatres.Add(theatre);
                sb.AppendLine(string.Format(SuccessfulImportTheatre, theatre.Name, theatre.Tickets.Count));
            }
            context.Theatres.AddRange(validTheatres);
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
