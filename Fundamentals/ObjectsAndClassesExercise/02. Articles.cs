using System.ComponentModel.DataAnnotations;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] article = Console.ReadLine().Split(", ");
            int n = int.Parse(Console.ReadLine());
            Article newArticle = new Article(article[0], article[1], article[2]);
            for (int i = 1; i <= n; i++)
            {
                string[] commands = Console.ReadLine().Split(": ");
                
                if (commands[0] == "Edit")
                {
                    newArticle.Edit(commands[1]);
                }
                else if (commands[0] == "ChangeAuthor")
                {
                    newArticle.ChangeAuthor(commands[1]);
                }
                else if (commands[0] == "Rename")
                {
                    newArticle.RenameTitle(commands[1]);
                }
            }
            Console.WriteLine(newArticle.ToString());
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void RenameTitle(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
