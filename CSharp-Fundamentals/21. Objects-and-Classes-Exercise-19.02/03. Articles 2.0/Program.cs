using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{

    public class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] aricleData = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                Article artcile = new Article
                {
                    Title = aricleData[0],
                    Content = aricleData[1],
                    Author = aricleData[2]
                };

                articles.Add(artcile);
            }

            string sortingCriteria = Console.ReadLine();

            List<Article> sorted = new List<Article>();

            if (sortingCriteria == "title")
            {
                sorted = articles
                 .OrderBy(x => x.Title)
                 .ToList();
            }
            else if (sortingCriteria == "content")
            {
                sorted = articles
                    .OrderBy(x => x.Content)
                    .ToList();
            }
            else
            {
                sorted = articles
                 .OrderBy(x => x.Author)
                 .ToList();
            }
            foreach (var article in sorted)
            {
                Console.WriteLine(article);
            }
        }
    }
}
