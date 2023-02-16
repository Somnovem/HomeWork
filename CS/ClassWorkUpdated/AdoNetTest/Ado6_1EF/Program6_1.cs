using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado6_1EF
{
    internal class Program6_1
    {
        private static void Main(string[] args)
        {
            Console.Title = "TEST EF - CodeFirst";
            //создаем контекст для работы с бд
            NewsDb db = new NewsDb();


            //Author temp = AddAuthor(db);
            //AddArticle(db,temp);
            //ChangeAuthor(db);
            //DeleteAuthor(db);
            //PrintAllAuthors(db);


            PrintAllAuthorsAllArticlesExplicit2(db);

            Console.WriteLine("\npress Enter key...");
            Console.ReadLine();
        }
        private static void AddArticle(NewsDb db,Author a)
        {
            Console.Clear();
            Article article = new Article();
            Console.Write("Title>>");
            article.Title = Console.ReadLine();
            Console.Write("Description>>");
            article.Description = Console.ReadLine();
            article.Author = a;
            db.Articles.Add(article);
            //сохранить изменения в бд и показать сколько роус аффектед(есть асинк)
            db.SaveChanges();
        }
        private static void PrintAllArticles(NewsDb db)
        {
            Console.Clear();
            Console.WriteLine("All articles: ");
            Console.WriteLine("////////////////////////////////////////////////////");
            foreach (Article article in db.Articles)
            {
                Console.WriteLine(article);
            }
            Console.WriteLine("////////////////////////////////////////////////////");
        }
        private static void PrintAllAuthors(NewsDb db)
        {
            Console.Clear();
            Console.WriteLine("All authors: ");
            Console.WriteLine("////////////////////////////////////////////////////");
            foreach (Author author in db.Authors)
            {
                Console.WriteLine(author.Id + " " + author);
            }
            Console.WriteLine("////////////////////////////////////////////////////");
        }
        private static Author AddAuthor(NewsDb db)
        {
            Console.Clear();
            Author author = new Author();
            Console.Write("Firstname>>");
            author.Firstname = Console.ReadLine();
            Console.Write("Lastname>>");
            author.Lastname = Console.ReadLine();
            Console.Write("Birthday>>");
            author.BirthDate = DateTime.Parse(Console.ReadLine());
            db.Authors.Add(author);
            db.SaveChanges();
            return author;
        }
        private static void ChangeAuthor(NewsDb db)
        {
            PrintAllAuthors(db);
            Console.WriteLine("\nEnter Id >> ");
            int id = int.Parse(Console.ReadLine());
            Author author = db.Authors.Where(u=> u.Id == id).FirstOrDefault();
            if (author == null)
            {
                Console.WriteLine("\nNo such Id found!\npress any key...");
                Console.ReadKey();
                return;
            }
            Console.Write("Firstname>>");
            author.Firstname = Console.ReadLine();
            Console.Write("Lastname>>");
            author.Lastname = Console.ReadLine();
            Console.Write("Birthday>>");
            author.BirthDate = DateTime.Parse(Console.ReadLine());
            db.SaveChanges();
        }
        private static void DeleteAuthor(NewsDb db)
        {
            PrintAllAuthors(db);
            Console.WriteLine("\nEnter Id >> ");
            int id = int.Parse(Console.ReadLine());
            Author author = db.Authors.Where(u => u.Id == id).FirstOrDefault();
            if (author == null)
            {
                Console.WriteLine("\nNo such Id found!\npress any key...");
                Console.ReadKey();
                return;
            }
            db.Authors.Remove(author);
            db.SaveChanges();
        }
        private static void PrintAllAuthorsAllArticles(NewsDb db)
        {
            Console.WriteLine("All publications: ");
            var authors = db.Authors.Include("Articles").ToList();
            foreach (Author author in authors)
            {
                Console.WriteLine(author);
                Console.WriteLine("Publications:");
                foreach (Article article in author.Articles.ToList())
                {
                    Console.WriteLine($"{article.Title} - {article.DatePublished.ToShortDateString()}");
                }
            }
        }
        private static void PrintAllAuthorsAllArticlesExplicit(NewsDb db)
        {
            Console.WriteLine("All publications(explicit): ");
            var authors = db.Authors.ToList();
            foreach (Author author in authors)
            {
                Console.WriteLine(author);
                Console.WriteLine("Publications:");

                //явно загружает связанные данные к коллекции данных если автозагрузка не вариант
                db.Entry(author).Collection("Articles").Load();

                foreach (Article article in author.Articles.ToList())
                {
                    Console.WriteLine($"{article.Title} - {article.DatePublished.ToShortDateString()}");
                }
            }
        }
        private static void PrintAllAuthorsAllArticlesExplicit2(NewsDb db)
        {
            Console.WriteLine("All publications(explicit): ");
            var articles = db.Articles.ToList();
            foreach (Article article in articles)
            {
                //сначала загрузить, а уже потом обращаться
                db.Entry(article).Reference("Author").Load();

                Console.WriteLine($"{article.Title} ({article.Author.Firstname}  {article.Author.Lastname}) - {article.DatePublished.ToShortDateString()}");
            }
        }
    }
}
