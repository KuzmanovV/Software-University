using System;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            Article article = new Article(input[0], input[1], input[2]);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] comArgs = Console.ReadLine().Split(": ");

                string command = comArgs[0];

                switch (command)
                {
                    case "Edit": article.Edit(comArgs[1]); break;
                    case "ChangeAuthor": article.ChangeAuthor(comArgs[1]); break;
                    case "Rename": article.Rename(comArgs[1]); break;
                }
            }

            Console.WriteLine(article.ToString());
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

        public string Edit(string content)
        {
            return Content = content;
        }
        public string ChangeAuthor(string author)
        {
            return Author = author;
        }

        public string Rename(string title)
        {
            return Title = title;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

}
