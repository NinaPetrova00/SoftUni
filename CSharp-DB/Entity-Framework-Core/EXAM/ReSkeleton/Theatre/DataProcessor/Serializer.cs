namespace Theatre.DataProcessor
{
    using Newtonsoft.Json;
    using System;
    using System.Linq;
    using Theatre.Data;

    public class Serializer
    {
        private static sbyte numbersOfHalls;

        public static string ExportTheatres(TheatreContext context, int numbersOfHalls)
        {
            var theatres = context
               .Theatres
               .ToArray()
               .Where(t => t.NumberOfHalls >= numbersOfHalls && t.Tickets.Count >= 20)
               .Select(t => new
               {
                   Name = t.Name,
                   Halls = t.NumberOfHalls,
                   TotalIncome = t.Tickets
                   .Where(tic => tic.RowNumber <= 5)
                   .Sum(tic => tic.Price),
                   Tickets = t.Tickets
                   .Where(tic => tic.RowNumber <= 5)
                   .Select(tic => new
                   {
                       Price = decimal.Round(tic.Price, 2),
                       RowNumber = tic.RowNumber
                   })
                   .OrderByDescending(tic => tic.Price)
                   .ToArray()
               })
               .OrderByDescending(t => t.Halls)
               .ThenBy(t => t.Name)
               .ToArray();

            string result = JsonConvert.SerializeObject(theatres, Formatting.Indented);
            return result;
        }

        public static string ExportPlays(TheatreContext context, double rating)
        {
            var theatres = context
               .Theatres
               .ToArray()
               .Where(t => t.NumberOfHalls >= numbersOfHalls && t.Tickets.Count >= 20)
               .Select(t => new
               {
                   Name = t.Name,
                   Halls = t.NumberOfHalls,
                   TotalIncome = t.Tickets
                   .Where(tic => tic.RowNumber <= 5)
                   .Sum(tic => tic.Price),
                   Tickets = t.Tickets
                   .Where(tic => tic.RowNumber <= 5)
                   .Select(tic => new
                   {
                       Price = decimal.Round(tic.Price, 2),
                       RowNumber = tic.RowNumber
                   })
                   .OrderByDescending(tic => tic.Price)
                   .ToArray()
               })
               .OrderByDescending(t => t.Halls)
               .ThenBy(t => t.Name)
               .ToArray();

            string result = JsonConvert.SerializeObject(theatres, Formatting.Indented);
            return result;
        }
    }
}
