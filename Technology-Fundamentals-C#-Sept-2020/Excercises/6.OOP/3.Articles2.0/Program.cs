using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();
            
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                Article article = new Article(input[0], input[1], input[2]);
                articles.Add(article);
            }

            string sortArg = Console.ReadLine();

            switch (sortArg)
            {
                case "title": articles = articles.OrderBy(x=> x.Title).ToList(); break;
                case "content": articles = articles.OrderBy(x=> x.Content).ToList(); break;
                case "author": articles = articles.OrderBy(x=> x.Author).ToList(); break;
            }

            foreach (Article article in articles)
            {
                Console.WriteLine(article);
            }
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
