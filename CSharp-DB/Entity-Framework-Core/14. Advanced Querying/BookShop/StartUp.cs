namespace BookShop
{
    using BookShop.Models;
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var dbContext = new BookShopContext();
            DbInitializer.ResetDatabase(dbContext);

            // Problem 2
            // string ageRestrictionString = Console.ReadLine();
            //string result = GetBooksByAgeRestriction(dbContext, ageRestrictionString);

            // Problem 3
            //string ageRestrictionString = Console.ReadLine();
            //string result = GetGoldenBooks(dbContext);

            // Problem 5 
            //int year = int.Parse(Console.ReadLine());
            //string result = GetBooksNotReleasedIn(dbContext, year);

            // Problem 8 
            //string endsWith = Console.ReadLine();
            //string result = GetAuthorNamesEndingIn(dbContext, endsWith);

            // Problem 12
            // string result = CountCopiesByAuthor(dbContext);

            // Problem 13
            //string result = GetTotalProfitByCategory(dbContext);

            // Problem 14
            // string result = GetMostRecentBooks(dbContext);
            //  Console.WriteLine(result);

            //Problem 15
           // Stopwatch sw = new Stopwatch();
          //  sw.Start();

            IncreasePrices(dbContext);

            //Console.WriteLine(sw.ElapsedMilliseconds);
        }

        //Problem 2
        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            StringBuilder sb = new StringBuilder();

            AgeRestriction ageRestriction = Enum.Parse<AgeRestriction>(command, true); //ignoreCase:true

            string[] bookTitles = context
                .Books
                .Where(b => b.AgeRestriction == ageRestriction)
                .OrderBy(b => b.Title)
                .Select(b => b.Title)
                .ToArray();

            foreach (var title in bookTitles)
            {
                sb.AppendLine(title);
            }

            return sb.ToString().TrimEnd();
        }

        //Problem 3
        public static string GetGoldenBooks(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            string[] goldenBookTitles = context
                .Books
                .Where(b => b.EditionType == EditionType.Gold && b.Copies < 5000)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToArray();

            foreach (var title in goldenBookTitles)
            {
                sb.AppendLine(title);
            }

            return sb.ToString().TrimEnd();
        }

        //Problem 5 
        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            StringBuilder sb = new StringBuilder();
            string[] booksNotRealisedInTitles = context
                .Books
                .Where(b => b.ReleaseDate.HasValue && b.ReleaseDate.Value.Year != year)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToArray();

            foreach (var title in booksNotRealisedInTitles)
            {
                sb.AppendLine(title);
            }

            return sb.ToString().TrimEnd();
        }

        // Problem 8 
        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            StringBuilder sb = new StringBuilder();
            string[] authorNames = context
                .Authors
                .ToArray()
                .Where(a => a.FirstName.ToLower().EndsWith(input.ToLower()))
                .Select(a => $"{a.FirstName} {a.LastName}")
                .OrderBy(n => n) //n=string -> FullName
                .ToArray();

            foreach (var name in authorNames)
            {
                sb.AppendLine(name);
            }

            return sb.ToString().TrimEnd();
        }

        // Problem 12
        public static string CountCopiesByAuthor(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var authorWithBookCopies = context
                .Authors
                .Select(a => new
                {
                    FullName = a.FirstName + " " + a.LastName,
                    TotalBookCopies = a.Books.Sum(b => b.Copies)
                })
                .OrderByDescending(a => a.TotalBookCopies)
                .ToArray();

            foreach (var author in authorWithBookCopies)
            {
                sb.AppendLine($"{author.FullName} - {author.TotalBookCopies}");
            }

            return sb.ToString().TrimEnd();
        }

        // Problem 13
        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();
            var categoriesByProfit = context
                .Categories
                .Select(c => new
                {
                    CategoryName = c.Name,
                    TotalProfit = c.CategoryBooks.Sum(cb => cb.Book.Copies * cb.Book.Price)
                })
                .OrderByDescending(c => c.TotalProfit)
                .ThenBy(c => c.CategoryName)
                .ToArray();

            foreach (var category in categoriesByProfit)
            {
                sb.AppendLine($"{category.CategoryName} ${category.TotalProfit:f2}");
            }
            return sb.ToString().TrimEnd();
        }

        // Problem 14
        public static string GetMostRecentBooks(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();
            var categoriesWithMostRecentBooks = context
                .Categories
                .Select(c => new
                {
                    CategoryName = c.Name,
                    MostRecentBooks = c.CategoryBooks
                   .Select(cb => cb.Book)
                   .OrderByDescending(b => b.ReleaseDate)
                   .Select(b => new
                   {
                       BookTitle = b.Title,
                       ReleaseYear = b.ReleaseDate.Value.Year
                   })
                   .Take(3)
                   .ToArray()
                })
                .OrderBy(c => c.CategoryName)
                .ToArray();

            foreach (var category in categoriesWithMostRecentBooks)
            {
                sb.AppendLine($"--{category.CategoryName}");

                foreach (var book in category.MostRecentBooks)
                {
                    sb.AppendLine($"{book.BookTitle} ({book.ReleaseYear})");
                }
            }

            return sb.ToString().TrimEnd();
        }

        // Problem 15
        public static void IncreasePrices(BookShopContext context)
        {
            IQueryable<Book> allBooksBefore2010 = context
                .Books
                .Where(b => b.ReleaseDate.HasValue && b.ReleaseDate.Value.Year < 2010);

            foreach (var book in allBooksBefore2010)
            {
                book.Price += 5;
            }

            context.SaveChanges();
            //context.BulkUpdate(allBooksBefore2010);
        }
    }
}
